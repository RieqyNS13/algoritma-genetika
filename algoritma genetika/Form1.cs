using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace algoritma_genetika
{
	public partial class Form1 : Form
	{
		public int population_size = 5;
		public Random random;
		public class Individu
		{
			Random random = new Random();
			public int batasan = 30;
			public double fitness = 0;
			public double P = 0; //probabilitas
			public double C = 0; //kumulatif probabilitas
			public List<int> chromosome;
			public int fungsi_objektif;

			public void hitungFungsiObjektif()
			{
				fungsi_objektif = Math.Abs((chromosome[0] + (2 * chromosome[1]) + (3 * chromosome[2]) + (4 * chromosome[3])) - 30);
			}
			public Individu(Random random)
			{
				chromosome = new List<int>();
				chromosome.Add(random.Next(this.batasan)); //a
				chromosome.Add(random.Next(this.batasan)); //b
				chromosome.Add(random.Next(this.batasan)); //c
				chromosome.Add(random.Next(this.batasan)); //d
			}

		}
		//Langkah 1
		void inisialisasi()
		{
			textBox1.Clear();
			this.population_size = Convert.ToInt32(numericUpDown1.Value);
			this.population = new List<Individu>();
			this.random = new Random();

			for (int i = 0; i < this.population_size; i++)
			{
				this.population.Add(new Individu(random));

				textBox1.AppendText("Chromosome[" + (i) + "] = [a;b;c;d] = [" + string.Join(";", this.population[i].chromosome.ToArray()) + "]\r\n");
			}
		}
		//Langkah 2
		void evaluasiKromosom()
		{
			for (int i = 0; i < this.population_size; i++)
			{
				this.population[i].hitungFungsiObjektif(); //mengitung fungsi objektuf
				List<int> kromosom = this.population[i].chromosome;
				textBox2.AppendText(string.Format("= Abs(({0} + 2*{1} + 3*{2} + 4*{3} ) – 30)", kromosom[0], kromosom[1], kromosom[2], kromosom[3]) + "\r\n");
				textBox2.AppendText(string.Format("= {0}", this.population[i].fungsi_objektif) + "\r\n");
			}
			var a = this.population.Select(x => x.fungsi_objektif);
			rata2_fungsi_objektif_old = rata2_fungsi_objektif = a.Average();
			textBox2.AppendText(string.Format("\r\nRata-rata fungsi objektif ({0})/{1} = {2}", string.Join("+", a.ToArray()), this.population_size, rata2_fungsi_objektif));
		}
		//Langkah 3
		void seleksiKromosom()
		{
			for (int i = 0; i < this.population_size; i++)
			{
				List<int> kromosom = this.population[i].chromosome;
				this.population[i].fitness = 1 / ((double)this.population[i].fungsi_objektif + 1);
				textBox3.AppendText(string.Format("fitness[{0}] = 1 / (fungsi_objektif[{1}]+1) = {2}", i, i, this.population[i].fitness) + "\r\n");
			}
			total_fitness = this.population.Select(x => x.fitness).Sum();
			textBox3.AppendText("\r\nTotal fitness = " + total_fitness + "\r\n\r\n");

			double kumlatif_probabilitas = 0;
			for (int i = 0; i < this.population_size; i++)
			{
				List<int> kromosom = this.population[i].chromosome;
				this.population[i].P = this.population[i].fitness / total_fitness;
				kumlatif_probabilitas += this.population[i].P;
				this.population[i].C = kumlatif_probabilitas;
				textBox3.AppendText(string.Format("P[{0}]   = {1} / {2} = {3}", i, this.population[i].fitness, total_fitness, this.population[i].P) + "\r\n");
			}
			textBox3.AppendText("\r\nKumulatif probabilitas:\r\n");
			for (int i = 0; i < this.population_size; i++)
			{
				textBox3.AppendText("C[{0}  = " + this.population[i].C + "\r\n");
			}
			rouleteWheel();
		}
		//Langkah 4
		void crossOver()
		{
			do
			{
				getParents();
				if (parents.Count < 2) textBox4.Clear();
			} while (parents.Count < 2);

			Dictionary<int, List<int>> offspring = new Dictionary<int, List<int>>(); //menyimpan hasil persilangan

			for (int i = 0; i < parents.Count; i++)
			{
				int posisi_gen = random.Next(0, 2);
				textBox4.AppendText("\r\nPosisi gen[" + i + "] = " + posisi_gen + "\r\n");

				KeyValuePair<int, Individu> parent = parents.ElementAt(i);
				KeyValuePair<int, Individu> parent2 = parents.ElementAt((i + 1) % parents.Count);

				List<int> kromosom1 = parent.Value.chromosome;
				List<int> kromosom2 = parent2.Value.chromosome;
				List<int> tmp = new List<int>(kromosom1);

				textBox4.AppendText(string.Format("Offspring[{0}] = Chromosome[{1}] >< Chromosome[{2}]\r\n", parent.Key, parent.Key, parent2.Key));
				textBox4.AppendText(string.Format("               = [{1}] >< [{2}]\r\n", i, string.Join(";", parent.Value.chromosome), string.Join(";", parent2.Value.chromosome)));
				for (int j = posisi_gen + 1; j < parent.Value.chromosome.Count; j++) //perulangan sebanyak jumlah kromosom
				{
					tmp[j] = kromosom2[j];
				}
				textBox4.AppendText(string.Format("               = {0}\r\n", string.Join(";", tmp)));
				offspring.Add(parent.Key, tmp);
			}
			//Memasukkan chromosom dari offspring ke variabel new_populasi yg merupakan populasi baru
			foreach (KeyValuePair<int, List<int>> chromosom in offspring)
			{
				this.new_population[chromosom.Key].chromosome = chromosom.Value;
			}
			textBox4.AppendText("\r\nPopulasi Chromosome setelah mengalami proses crossover menjadi:\r\n");
			for (int i = 0; i < new_population.Count; i++)
			{
				textBox4.AppendText(string.Format("Chromosome[{0}] = [{1}]\r\n", i, string.Join(";", new_population[i].chromosome)));
			}

		}
		void rouleteWheel()
		{
			textBox3.AppendText("\r\nProses Roulette Wheel:\r\n\r\n");
			new_population = new List<Individu>();
			Random random = new Random();
			for (int i = 0; i < population_size; i++)
			{
				double R = random.NextDouble();
				textBox3.AppendText("R[" + i + "] =  " + R + "\r\n");
				foreach (Individu individu in population)
				{
					if (R <= individu.C)
					{
						new_population.Add(individu);
						break; //jgn lupa break
					}
				}
			}
			textBox3.AppendText("\r\nChromosome hasil proses seleksi\r\n");
			for (int i = 0; i < population_size; i++)
			{
				List<int> kromosom = this.new_population[i].chromosome;
				textBox3.AppendText(string.Format("chromosome[{0}] = [{1};{2};{3};{4}]", i, kromosom[0], kromosom[1], kromosom[2], kromosom[3]) + "\r\n");
			}

		}
		void getParents()
		{
			parents = new Dictionary<int, Individu>();
			//textBox4.AppendText("Kromosom parents:\r\n");
			textBox4.AppendText("Crossover rate: " + crossover_rate + "\r\n");

			Random random = new Random();
			for (int i = 0; i < population_size; i++)
			{

				double rand = random.NextDouble();

				textBox4.AppendText("R[" + i + "] = " + rand + "\r\n");
				if (rand < crossover_rate)
				{
					parents.Add(i, new_population[i]); //new_population adalah populasi baru hasil seleksi kromosom
				}
			}
			textBox4.AppendText("\r\nKromosom parents:\r\n");
			for (int i = 0; i < parents.Count; i++)
			{
				textBox4.AppendText(string.Format("C[{0}] = [{1}]\r\n", parents.ElementAt(i).Key, string.Join(";", parents.ElementAt(i).Value.chromosome.ToArray())));
			}
		}
		//Langkah 5
		void mutation()
		{
			int jumlah_kromosom = new_population[0].chromosome.Count;
			int total_gen = jumlah_kromosom * population_size;
			double jumlah_mutasi_ = mutation_rate * total_gen;
			int jumlah_mutasi = (int)Math.Round(jumlah_mutasi_, MidpointRounding.AwayFromZero);
			textBox5.AppendText("Jumlah mutasi: " + jumlah_mutasi + "\r\n");
			for (int i = 0; i < jumlah_mutasi; i++)
			{
				int rand = random.Next(1, total_gen);
				int baris = (int)Math.Ceiling(((double)rand) / ((double)jumlah_kromosom)) - 1;
				int kolom = ((rand % jumlah_kromosom) + 3) % jumlah_kromosom;
				this.new_population[baris].chromosome[kolom] = random.Next(0, 30);
				textBox5.AppendText(string.Format("Posisi gen acak: {0}, ganti chromosom[{1}] index ke-{2} dgn bil. acak: {3}\r\n", rand, baris, kolom, this.new_population[baris].chromosome[kolom]));

			}
			textBox5.AppendText("\r\nPopulasi chromosome setelah mengalami proses mutasi:\r\n");
			for (int i = 0; i < new_population.Count; i++)
			{
				textBox5.AppendText(string.Format("chromosome[{0}] = [{1}]\r\n", i, string.Join(";", new_population[i].chromosome)));
			}
			foreach (Individu individu in new_population) individu.hitungFungsiObjektif();
			var a = this.new_population.Select(x => x.fungsi_objektif);
			rata2_fungsi_objektif = a.Average();
			textBox5.AppendText(string.Format("\r\nRata-rata fungsi objektif setelah seleksi, crossover, dan mutasi adalah = ({0})/{1} = {2}", string.Join("+", a.ToArray()), this.population_size, rata2_fungsi_objektif));
		}
		//parameter pada algoritma genetika
		double total_fitness;
		double rata2_fungsi_objektif;
		double rata2_fungsi_objektif_old;
		double crossover_rate = 0.45d;
		double mutation_rate = 0.10d;
		//
		public List<Individu> population;
		public List<Individu> new_population;
		public Dictionary<int, Individu> parents;

		public Form1()
		{
			InitializeComponent();

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void Button1_Click(object sender, EventArgs e)
		{

		}


		private void Button1_Click_1(object sender, EventArgs e)
		{

			//Inisialisasi
			inisialisasi();
		}
	
		//Evaluasi Chromosome (Langkah 2)
		private void Button2_Click(object sender, EventArgs e)
		{
			if (this.population == null)
			{
				MessageBox.Show("Inisialisasi dulu"); return;
			}
			
			evaluasiKromosom();


		}
		//Seleksi Chromosome (Langkah 3)
		private void BtnSeleksiKromosom_Click(object sender, EventArgs e)
		{

			if (this.population == null)
			{
				MessageBox.Show("Inisialisasi dulu"); return;
			}
			textBox3.Clear();
			seleksiKromosom();
		}
		//Crossover (Langkah 4)
		private void BtnCrossOver_Click(object sender, EventArgs e)
		{
			textBox4.Clear();
			crossover_rate = Convert.ToDouble(txtCrossoverRate.Text.Replace('.', ','));
			crossOver();

		}

		//Mutation (Langkah 5)
		private void BtnMutation_Click(object sender, EventArgs e)
		{
			if (this.population == null || this.new_population == null)
			{
				MessageBox.Show("Inisialisasi dulu"); return;
			}
			mutation_rate = Convert.ToDouble(txtMutationRate.Text.Replace('.', ','));
			mutation();
		}

		private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		void tampilData(int iterasi, List<Individu> individus)
		{
			List<ListViewItem> items = new List<ListViewItem>();
			foreach(Individu individu in individus)
			{
				ListViewItem item = new ListViewItem("-");
				item.SubItems.Add(individu.chromosome[0].ToString());
				item.SubItems.Add(individu.chromosome[1].ToString());
				item.SubItems.Add(individu.chromosome[2].ToString());
				item.SubItems.Add(individu.chromosome[3].ToString());
				item.SubItems.Add(individu.fungsi_objektif.ToString());
				item.SubItems.Add("");
				items.Add(item);
			}
			items[0].Text = iterasi.ToString();
			items[0].SubItems[6].Text = rata2_fungsi_objektif.ToString();
			listView1.Items.AddRange(items.ToArray());
		}
		private void BtnGenerasi_Click(object sender, EventArgs e)
		{
			listView1.Items.Clear();
			textBox1.Clear();textBox2.Clear();textBox3.Clear();textBox4.Clear();textBox5.Clear();
			inisialisasi();
			evaluasiKromosom();
			tampilData(0, population); //populasi awal
			
			seleksiKromosom();
			crossOver();
			mutation();
			int loop = Convert.ToInt32(numericUpDown2.Value);
			for(int i=1; i<=loop; i++)
			{
				tampilData(i, new_population);
				if (rata2_fungsi_objektif < rata2_fungsi_objektif_old) population = new_population;
				textBox2.AppendText("\r\n-------------[Iterasi ke-"+i+"---------------\r\n");
				evaluasiKromosom();
				textBox3.AppendText("\r\n-------------[Iterasi ke-" + i + "---------------\r\n");
				seleksiKromosom();
				textBox4.AppendText("\r\n-------------[Iterasi ke-" + i + "---------------\r\n");
				crossOver();
				textBox5.AppendText("\r\n-------------[Iterasi ke-" + i + "---------------\r\n");
				mutation();
			}
		}
	}
}
