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
		public Random random=new Random();
		public class Individu
		{
			public int batasan = 30;
			public int batasan2 = 10;
			public double fitness = 0;
			public double P = 0; //probabilitas
			public double C = 0; //kumulatif probabilitas
			public List<int> chromosome;
			public int fungsi_objektif;
			public void hitungFungsiObjektif()
			{
				fungsi_objektif = Math.Abs((chromosome[0] + 
					(2 * chromosome[1]) + (3 * chromosome[2]) + (4 * chromosome[3])) - 30);
			}
			public Individu(Random random)
			{
				chromosome = new List<int>();
				chromosome.Add(random.Next(0,this.batasan)); //a
				chromosome.Add(random.Next(0,this.batasan2)); //b
				chromosome.Add(random.Next(0,this.batasan2)); //c
				chromosome.Add(random.Next(0,this.batasan2)); //d
			}

		}
		//Langkah 1
		void inisialisasi()
		{
			richTextBox1.Clear();
			population_size = Convert.ToInt32(numericUpDown1.Value);
			population = new List<Individu>();

			for (int i = 0; i < this.population_size; i++)
			{
				Individu individu = new Individu(random);
				this.population.Add(individu);


				richTextBox1.AppendText("Chromosome[" + (i) + "] = [a;b;c;d] = [" + string.Join(";", this.population[i].chromosome.ToArray()) + "]\r\n");
			}
		}
		//Langkah 2
		void evaluasiKromosom()
		{
			for (int i = 0; i < this.population_size; i++)
			{
				this.population[i].hitungFungsiObjektif(); 
				List<int> kromosom = this.population[i].chromosome;
			}
			var a = this.population.Select(x => x.fungsi_objektif);
			rata2_fungsi_objektif_old = rata2_fungsi_objektif = a.Average();
		}
		//Langkah 3
		void seleksiKromosom()
		{
			double total_fitness = 0d;
			for (int i = 0; i < this.population_size; i++)
			{
				List<int> kromosom = this.population[i].chromosome;
				this.population[i].fitness = 1 / ((double)this.population[i].fungsi_objektif + 1);
				total_fitness += this.population[i].fitness;
				richTextBox3.AppendText(string.Format("fitness[{0}] = 1 / (fungsi_objektif[{1}]+1) = {2}", i, i, this.population[i].fitness) + "\r\n");
			}
			richTextBox3.AppendText("\r\nTotal fitness = " + total_fitness + "\r\n\r\n");

			List<double> Ps = new List<double>();
			//double kumulatif_probabilitas = 0d;
			for (int i = 0; i < this.population_size; i++)
			{
				List<int> kromosom = new List<int>(this.population[i].chromosome);
				this.population[i].P = this.population[i].fitness / total_fitness;
				Ps.Add(this.population[i].P);
				//kumulatif_probabilitas += this.population[i].P;
				Console.WriteLine(string.Join(" + ", Ps)+" = " + Ps.Sum());
				this.population[i].C = Ps.Sum();
				richTextBox3.AppendText(string.Format("P[{0}]   = {1} / {2} = {3}", i, this.population[i].fitness, total_fitness, this.population[i].P) + "\r\n");
			}
			richTextBox3.AppendText("\r\nKumulatif probabilitas:\r\n");
			for (int i = 0; i < this.population_size; i++)
			{
				System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CreateSpecificCulture("eu-ES");
				richTextBox3.AppendText(string.Format("C[{0}]  = {1}\r\n",i, this.population[i].C.ToString(culture)));
			}
			rouleteWheel();
		}
		//Langkah 4
		void crossOver()
		{
			do
			{
				getParents();
				if (parents.Count < 2) richTextBox4.Clear();
			} while (parents.Count < 2);

			Dictionary<int, List<int>> offspring = new Dictionary<int, List<int>>(); //menyimpan hasil persilangan

			for (int i = 0; i < parents.Count; i++)
			{
				int posisi_gen = random.Next(0, 2);
				richTextBox4.AppendText("\r\nPosisi gen[" + i + "] = " + posisi_gen + "\r\n");

				KeyValuePair<int, Individu> parent = parents.ElementAt(i);
				
				KeyValuePair<int, Individu> parent2 = parents.ElementAt((i + 1) % parents.Count);

				List<int> kromosom1 = new List<int>(parent.Value.chromosome);
				List<int> kromosom2 = new List<int>(parent2.Value.chromosome);
				List<int> tmp = new List<int>(kromosom1);

				richTextBox4.AppendText(string.Format("Offspring[{0}] = Chromosome[{1}] >< Chromosome[{2}]\r\n", parent.Key, parent.Key, parent2.Key));
				richTextBox4.AppendText(string.Format("               = [{1}] >< [{2}]\r\n", i, string.Join(";", parent.Value.chromosome), string.Join(";", parent2.Value.chromosome)));
				for (int j = posisi_gen + 1; j < parent.Value.chromosome.Count; j++) //perulangan sebanyak jumlah kromosom
				{
					tmp[j] = kromosom2[j];
				}
				richTextBox4.AppendText(string.Format("               = {0}\r\n", string.Join(";", tmp)));
				offspring.Add(parent.Key, tmp);
			}
			//Memasukkan chromosom dari offspring ke variabel new_populasi yg merupakan populasi baru
			foreach (KeyValuePair<int, List<int>> chromosom in offspring)
			{
				this.new_population[chromosom.Key].chromosome = new List<int>(chromosom.Value);
			}
			richTextBox4.AppendText("\r\nPopulasi Chromosome setelah mengalami proses crossover menjadi:\r\n");
			for (int i = 0; i < new_population.Count; i++)
			{
				richTextBox4.AppendText(string.Format("Chromosome[{0}] = [{1}]\r\n", i, string.Join(";", new_population[i].chromosome)));
			}

		}
		void getParents()
		{
			parents = new Dictionary<int, Individu>();
			//textBox4.AppendText("Kromosom parents:\r\n");
			richTextBox4.AppendText("Crossover rate: " + crossover_rate + "\r\n");

			//Random random = new Random();
			for (int i = 0; i < population_size; i++)
			{

				double rand = random.NextDouble();

				richTextBox4.AppendText("R[" + i + "] = " + rand + "\r\n");
				if (rand < crossover_rate)
				{
					parents.Add(i, new_population[i]); //new_population adalah populasi baru hasil seleksi kromosom
				}
			}
			richTextBox4.AppendText("\r\nKromosom parents:\r\n");
			for (int i = 0; i < parents.Count; i++)
			{
				richTextBox4.AppendText(string.Format("C[{0}] = [{1}]\r\n", parents.ElementAt(i).Key, string.Join(";", parents.ElementAt(i).Value.chromosome.ToArray())));
			}
		}
		void rouleteWheel()
		{
			richTextBox3.AppendText("\r\nProses Roulette Wheel:\r\n\r\n");
			new_population = new List<Individu>();
			//Random random = new Random();
			for (int i = 0; i < population_size; i++)
			{
				double R = random.NextDouble();
				richTextBox3.AppendText("R[" + i + "] =  " + R + "\r\n");
				foreach (Individu individu in population)
				{
					if (R <= individu.C)
					{
						new_population.Add(individu);
						break; //jgn lupa break
					}
				}
			}
			richTextBox3.AppendText("\r\nChromosome hasil proses seleksi\r\n");
			for (int i = 0; i < population_size; i++)
			{
				List<int> kromosom = this.new_population[i].chromosome;
				richTextBox3.AppendText(string.Format("chromosome[{0}] = [{1};{2};{3};{4}]", i, kromosom[0], kromosom[1], kromosom[2], kromosom[3]) + "\r\n");
			}

		}
		
		//Langkah 5
		void mutation()
		{
			int jumlah_kromosom = new_population[0].chromosome.Count;
			int total_gen = jumlah_kromosom * population_size;
			double jumlah_mutasi_ = mutation_rate * total_gen;
			int jumlah_mutasi = (int)Math.Round(jumlah_mutasi_, MidpointRounding.AwayFromZero);
			richTextBox5.AppendText("Jumlah mutasi: " + jumlah_mutasi + "\r\n");
			for (int i = 0; i < jumlah_mutasi; i++)
			{
				int rand = random.Next(1, total_gen);
				int baris = (int)Math.Ceiling(((double)rand) / ((double)jumlah_kromosom)) - 1;
				int kolom = ((rand % jumlah_kromosom) + 3) % jumlah_kromosom;
				int max_acak=kolom > 0 ? 10 : 30;
				this.new_population[baris].chromosome[kolom] = random.Next(0, max_acak);
				richTextBox5.AppendText(string.Format("Posisi gen acak: {0}, ganti chromosom[{1}] index ke-{2} dgn bil. acak: {3}\r\n", rand, baris, kolom, this.new_population[baris].chromosome[kolom]));

			}
			richTextBox5.AppendText("\r\nPopulasi chromosome setelah mengalami proses mutasi:\r\n");
			for (int i = 0; i < new_population.Count; i++)
			{
				richTextBox5.AppendText(string.Format("chromosome[{0}] = [{1}]\r\n", i, string.Join(";", new_population[i].chromosome)));
			}
			foreach (Individu individu in new_population) individu.hitungFungsiObjektif();
			var a = this.new_population.Select(x => x.fungsi_objektif);
			rata2_fungsi_objektif = a.Average();
			richTextBox5.AppendText(string.Format("\r\nRata-rata fungsi objektif setelah seleksi, crossover, dan mutasi adalah = ({0})/{1} = {2}", string.Join("+", a.ToArray()), this.population_size, rata2_fungsi_objektif));
		}
		//parameter pada algoritma genetika
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

		private void btnInisialisasi(object sender, EventArgs e)
		{
			inisialisasi();
			
		}
	
		//Evaluasi Chromosome (Langkah 2)
		private void Button2_Click(object sender, EventArgs e)
		{
			if (this.population == null)
			{
				MessageBox.Show("Inisialisasi dulu"); return;
			}
			richTextBox2.Clear();
			evaluasiKromosom();


		}
		//Seleksi Chromosome (Langkah 3)
		private void BtnSeleksiKromosom_Click(object sender, EventArgs e)
		{

			if (this.population == null)
			{
				MessageBox.Show("Inisialisasi dulu"); return;
			}
			richTextBox3.Clear();
			seleksiKromosom();
		}
		//Crossover (Langkah 4)
		private void BtnCrossOver_Click(object sender, EventArgs e)
		{
			richTextBox4.Clear();

			
			crossover_rate = Convert.ToDouble(txtCrossoverRate.Text.Replace('.', ','));
			crossOver();

		}

		//Mutation (Langkah 5)
		private void BtnMutation_Click(object sender, EventArgs e)
		{
			richTextBox5.Clear();
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
			richTextBox1.Clear(); richTextBox2.Clear(); richTextBox3.Clear(); richTextBox4.Clear(); richTextBox5.Clear();
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
				if (rata2_fungsi_objektif < rata2_fungsi_objektif_old) population = new List<Individu>(new_population);
				//population = new List<Individu>(new_population);
				richTextBox2.AppendText("\r\n-------------[Iterasi ke-"+i+"]---------------\r\n");
				evaluasiKromosom();
				richTextBox3.AppendText("\r\n-------------[Iterasi ke-" + i + "]---------------\r\n");
				seleksiKromosom();
				richTextBox4.AppendText("\r\n-------------[Iterasi ke-" + i + "]---------------\r\n");
				crossOver();
				richTextBox5.AppendText("\r\n-------------[Iterasi ke-" + i + "]---------------\r\n");
				mutation();
			}
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			
		}

		private void TabPage3_Click(object sender, EventArgs e)
		{

		}
	}
}
