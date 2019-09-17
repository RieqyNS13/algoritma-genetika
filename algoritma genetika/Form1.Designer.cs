namespace algoritma_genetika
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.label1 = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.BtnInisialisasi = new System.Windows.Forms.Button();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.btnEvaluasiKromosom = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.label4 = new System.Windows.Forms.Label();
			this.btnSeleksiKromosom = new System.Windows.Forms.Button();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.txtCrossoverRate = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.btnCrossOver = new System.Windows.Forms.Button();
			this.tabPage5 = new System.Windows.Forms.TabPage();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.btnMutation = new System.Windows.Forms.Button();
			this.txtMutationRate = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.tabPage6 = new System.Windows.Forms.TabPage();
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colFungsiObjektif = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colRata2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.btnGenerasi = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.tabPage2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.tabPage4.SuspendLayout();
			this.tabPage5.SuspendLayout();
			this.tabPage6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Controls.Add(this.tabPage5);
			this.tabControl1.Controls.Add(this.tabPage6);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(878, 492);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this.numericUpDown1);
			this.tabPage1.Controls.Add(this.textBox1);
			this.tabPage1.Controls.Add(this.BtnInisialisasi);
			this.tabPage1.Location = new System.Drawing.Point(4, 25);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(870, 463);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Inisialisasi";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(110, 17);
			this.label1.TabIndex = 4;
			this.label1.Text = "Jumlah populasi";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(124, 5);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
			this.numericUpDown1.TabIndex = 3;
			this.numericUpDown1.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
			// 
			// textBox1
			// 
			this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox1.Location = new System.Drawing.Point(8, 65);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox1.Size = new System.Drawing.Size(854, 392);
			this.textBox1.TabIndex = 1;
			// 
			// BtnInisialisasi
			// 
			this.BtnInisialisasi.Location = new System.Drawing.Point(11, 36);
			this.BtnInisialisasi.Name = "BtnInisialisasi";
			this.BtnInisialisasi.Size = new System.Drawing.Size(75, 23);
			this.BtnInisialisasi.TabIndex = 0;
			this.BtnInisialisasi.Text = "Acak";
			this.BtnInisialisasi.UseVisualStyleBackColor = true;
			this.BtnInisialisasi.Click += new System.EventHandler(this.btnInisialisasi);
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.btnEvaluasiKromosom);
			this.tabPage2.Controls.Add(this.textBox2);
			this.tabPage2.Controls.Add(this.label2);
			this.tabPage2.Location = new System.Drawing.Point(4, 25);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(870, 463);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Evaluasi kromosom";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// btnEvaluasiKromosom
			// 
			this.btnEvaluasiKromosom.Location = new System.Drawing.Point(11, 42);
			this.btnEvaluasiKromosom.Name = "btnEvaluasiKromosom";
			this.btnEvaluasiKromosom.Size = new System.Drawing.Size(75, 23);
			this.btnEvaluasiKromosom.TabIndex = 2;
			this.btnEvaluasiKromosom.Text = "Hitung";
			this.btnEvaluasiKromosom.UseVisualStyleBackColor = true;
			this.btnEvaluasiKromosom.Click += new System.EventHandler(this.Button2_Click);
			// 
			// textBox2
			// 
			this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox2.Location = new System.Drawing.Point(11, 71);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox2.Size = new System.Drawing.Size(851, 384);
			this.textBox2.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(8, 20);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(337, 17);
			this.label2.TabIndex = 0;
			this.label2.Text = "fungsi_objektif(chromosome) = | (a+2b+3c+4d) – 30 |";
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.label4);
			this.tabPage3.Controls.Add(this.btnSeleksiKromosom);
			this.tabPage3.Controls.Add(this.textBox3);
			this.tabPage3.Controls.Add(this.label3);
			this.tabPage3.Location = new System.Drawing.Point(4, 25);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(870, 463);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Seleksi Kromosom";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(8, 34);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(406, 17);
			this.label4.TabIndex = 3;
			this.label4.Text = "Rumus untuk mencari probabilitas: P[i] = fitness[i] / total_fitness";
			// 
			// btnSeleksiKromosom
			// 
			this.btnSeleksiKromosom.Location = new System.Drawing.Point(11, 68);
			this.btnSeleksiKromosom.Name = "btnSeleksiKromosom";
			this.btnSeleksiKromosom.Size = new System.Drawing.Size(75, 23);
			this.btnSeleksiKromosom.TabIndex = 2;
			this.btnSeleksiKromosom.Text = "Seleksi kromosom";
			this.btnSeleksiKromosom.UseVisualStyleBackColor = true;
			this.btnSeleksiKromosom.Click += new System.EventHandler(this.BtnSeleksiKromosom_Click);
			// 
			// textBox3
			// 
			this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox3.Location = new System.Drawing.Point(8, 97);
			this.textBox3.Multiline = true;
			this.textBox3.Name = "textBox3";
			this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox3.Size = new System.Drawing.Size(773, 316);
			this.textBox3.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(8, 17);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(246, 17);
			this.label3.TabIndex = 0;
			this.label3.Text = "fungsi fitness = (1/(1+fungsi_objektif))";
			// 
			// tabPage4
			// 
			this.tabPage4.Controls.Add(this.txtCrossoverRate);
			this.tabPage4.Controls.Add(this.label6);
			this.tabPage4.Controls.Add(this.label5);
			this.tabPage4.Controls.Add(this.textBox4);
			this.tabPage4.Controls.Add(this.btnCrossOver);
			this.tabPage4.Location = new System.Drawing.Point(4, 25);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage4.Size = new System.Drawing.Size(870, 463);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "Crossover";
			this.tabPage4.UseVisualStyleBackColor = true;
			// 
			// txtCrossoverRate
			// 
			this.txtCrossoverRate.Location = new System.Drawing.Point(112, 0);
			this.txtCrossoverRate.Name = "txtCrossoverRate";
			this.txtCrossoverRate.Size = new System.Drawing.Size(100, 22);
			this.txtCrossoverRate.TabIndex = 5;
			this.txtCrossoverRate.Text = "0,45";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(10, 3);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(105, 17);
			this.label6.TabIndex = 4;
			this.label6.Text = "Crossover rate:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(10, 37);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(294, 17);
			this.label5.TabIndex = 3;
			this.label5.Text = "Metode yang digunakan adalah one-cut point";
			// 
			// textBox4
			// 
			this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox4.Location = new System.Drawing.Point(13, 86);
			this.textBox4.Multiline = true;
			this.textBox4.Name = "textBox4";
			this.textBox4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox4.Size = new System.Drawing.Size(773, 327);
			this.textBox4.TabIndex = 2;
			// 
			// btnCrossOver
			// 
			this.btnCrossOver.Location = new System.Drawing.Point(8, 57);
			this.btnCrossOver.Name = "btnCrossOver";
			this.btnCrossOver.Size = new System.Drawing.Size(75, 23);
			this.btnCrossOver.TabIndex = 0;
			this.btnCrossOver.Text = "Hitung";
			this.btnCrossOver.UseVisualStyleBackColor = true;
			this.btnCrossOver.Click += new System.EventHandler(this.BtnCrossOver_Click);
			// 
			// tabPage5
			// 
			this.tabPage5.Controls.Add(this.textBox5);
			this.tabPage5.Controls.Add(this.btnMutation);
			this.tabPage5.Controls.Add(this.txtMutationRate);
			this.tabPage5.Controls.Add(this.label7);
			this.tabPage5.Location = new System.Drawing.Point(4, 25);
			this.tabPage5.Name = "tabPage5";
			this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage5.Size = new System.Drawing.Size(870, 463);
			this.tabPage5.TabIndex = 4;
			this.tabPage5.Text = "Mutasi";
			this.tabPage5.UseVisualStyleBackColor = true;
			// 
			// textBox5
			// 
			this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox5.Location = new System.Drawing.Point(8, 77);
			this.textBox5.Multiline = true;
			this.textBox5.Name = "textBox5";
			this.textBox5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox5.Size = new System.Drawing.Size(773, 327);
			this.textBox5.TabIndex = 8;
			// 
			// btnMutation
			// 
			this.btnMutation.Location = new System.Drawing.Point(11, 33);
			this.btnMutation.Name = "btnMutation";
			this.btnMutation.Size = new System.Drawing.Size(75, 23);
			this.btnMutation.TabIndex = 7;
			this.btnMutation.Text = "Hitung";
			this.btnMutation.UseVisualStyleBackColor = true;
			this.btnMutation.Click += new System.EventHandler(this.BtnMutation_Click);
			// 
			// txtMutationRate
			// 
			this.txtMutationRate.Location = new System.Drawing.Point(100, 3);
			this.txtMutationRate.Name = "txtMutationRate";
			this.txtMutationRate.Size = new System.Drawing.Size(100, 22);
			this.txtMutationRate.TabIndex = 6;
			this.txtMutationRate.Text = "0,10";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(8, 3);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(95, 17);
			this.label7.TabIndex = 5;
			this.label7.Text = "Mutation rate:";
			// 
			// tabPage6
			// 
			this.tabPage6.Controls.Add(this.listView1);
			this.tabPage6.Controls.Add(this.btnGenerasi);
			this.tabPage6.Controls.Add(this.label8);
			this.tabPage6.Controls.Add(this.numericUpDown2);
			this.tabPage6.Location = new System.Drawing.Point(4, 25);
			this.tabPage6.Name = "tabPage6";
			this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage6.Size = new System.Drawing.Size(870, 463);
			this.tabPage6.TabIndex = 5;
			this.tabPage6.Text = "Iterasi";
			this.tabPage6.UseVisualStyleBackColor = true;
			// 
			// listView1
			// 
			this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.colA,
            this.colB,
            this.colC,
            this.colD,
            this.colFungsiObjektif,
            this.colRata2});
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(11, 42);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(851, 413);
			this.listView1.TabIndex = 3;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Iterasi";
			// 
			// colA
			// 
			this.colA.Text = "a";
			// 
			// colB
			// 
			this.colB.Text = "b";
			// 
			// colC
			// 
			this.colC.Text = "c";
			// 
			// colD
			// 
			this.colD.Text = "d";
			// 
			// colFungsiObjektif
			// 
			this.colFungsiObjektif.Text = "Fungsi objektif";
			this.colFungsiObjektif.Width = 182;
			// 
			// colRata2
			// 
			this.colRata2.Text = "Rata2 fungsi objektif";
			this.colRata2.Width = 113;
			// 
			// btnGenerasi
			// 
			this.btnGenerasi.Location = new System.Drawing.Point(186, 14);
			this.btnGenerasi.Name = "btnGenerasi";
			this.btnGenerasi.Size = new System.Drawing.Size(75, 23);
			this.btnGenerasi.TabIndex = 2;
			this.btnGenerasi.Text = "Generasi";
			this.btnGenerasi.UseVisualStyleBackColor = true;
			this.btnGenerasi.Click += new System.EventHandler(this.BtnGenerasi_Click);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(8, 14);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(46, 17);
			this.label8.TabIndex = 1;
			this.label8.Text = "Iterasi";
			// 
			// numericUpDown2
			// 
			this.numericUpDown2.Location = new System.Drawing.Point(60, 14);
			this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown2.Name = "numericUpDown2";
			this.numericUpDown2.Size = new System.Drawing.Size(120, 22);
			this.numericUpDown2.TabIndex = 0;
			this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(878, 492);
			this.Controls.Add(this.tabControl1);
			this.Name = "Form1";
			this.Text = "Aplikasi algen sederhana by kelompok 3";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			this.tabPage4.ResumeLayout(false);
			this.tabPage4.PerformLayout();
			this.tabPage5.ResumeLayout(false);
			this.tabPage5.PerformLayout();
			this.tabPage6.ResumeLayout(false);
			this.tabPage6.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Button BtnInisialisasi;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnEvaluasiKromosom;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnSeleksiKromosom;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Button btnCrossOver;
		private System.Windows.Forms.TextBox txtCrossoverRate;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TabPage tabPage5;
		private System.Windows.Forms.Button btnMutation;
		private System.Windows.Forms.TextBox txtMutationRate;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TabPage tabPage6;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.NumericUpDown numericUpDown2;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader colFungsiObjektif;
		private System.Windows.Forms.Button btnGenerasi;
		private System.Windows.Forms.ColumnHeader colA;
		private System.Windows.Forms.ColumnHeader colB;
		private System.Windows.Forms.ColumnHeader colC;
		private System.Windows.Forms.ColumnHeader colD;
		private System.Windows.Forms.ColumnHeader colRata2;
	}
}

