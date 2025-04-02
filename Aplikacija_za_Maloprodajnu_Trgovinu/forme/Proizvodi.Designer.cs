namespace Aplikacija_za_Maloprodajnu_Trgovinu.forme
{
    partial class Proizvodi
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID_Proizvod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kategorija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Količina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jedinica_mjere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUcitaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Proizvod,
            this.Naziv,
            this.Opis,
            this.Cijena,
            this.Kategorija,
            this.Količina,
            this.Jedinica_mjere});
            this.dataGridView1.Location = new System.Drawing.Point(178, 11);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(664, 273);
            this.dataGridView1.TabIndex = 11;
            // 
            // ID_Proizvod
            // 
            this.ID_Proizvod.HeaderText = "ID_Proizvod";
            this.ID_Proizvod.MinimumWidth = 8;
            this.ID_Proizvod.Name = "ID_Proizvod";
            this.ID_Proizvod.Width = 150;
            // 
            // Naziv
            // 
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.MinimumWidth = 8;
            this.Naziv.Name = "Naziv";
            this.Naziv.Width = 150;
            // 
            // Opis
            // 
            this.Opis.HeaderText = "Opis";
            this.Opis.MinimumWidth = 8;
            this.Opis.Name = "Opis";
            this.Opis.Width = 150;
            // 
            // Cijena
            // 
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.MinimumWidth = 8;
            this.Cijena.Name = "Cijena";
            this.Cijena.Width = 150;
            // 
            // Kategorija
            // 
            this.Kategorija.HeaderText = "Kategorija";
            this.Kategorija.MinimumWidth = 6;
            this.Kategorija.Name = "Kategorija";
            this.Kategorija.Width = 125;
            // 
            // Količina
            // 
            this.Količina.HeaderText = "Količina";
            this.Količina.MinimumWidth = 8;
            this.Količina.Name = "Količina";
            this.Količina.Width = 150;
            // 
            // Jedinica_mjere
            // 
            this.Jedinica_mjere.HeaderText = "Jedinica_mjere";
            this.Jedinica_mjere.MinimumWidth = 8;
            this.Jedinica_mjere.Name = "Jedinica_mjere";
            this.Jedinica_mjere.Width = 150;
            // 
            // btnUcitaj
            // 
            this.btnUcitaj.Font = new System.Drawing.Font("Palatino Linotype", 9F);
            this.btnUcitaj.Location = new System.Drawing.Point(12, 20);
            this.btnUcitaj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUcitaj.Name = "btnUcitaj";
            this.btnUcitaj.Size = new System.Drawing.Size(134, 41);
            this.btnUcitaj.TabIndex = 12;
            this.btnUcitaj.Text = "Ucitaj";
            this.btnUcitaj.UseVisualStyleBackColor = true;
            this.btnUcitaj.Click += new System.EventHandler(this.btnUcitaj_Click);
            // 
            // Proizvodi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Aplikacija_za_Maloprodajnu_Trgovinu.Properties.Resources.trgovina2;
            this.ClientSize = new System.Drawing.Size(977, 360);
            this.Controls.Add(this.btnUcitaj);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Proizvodi";
            this.Text = "Proizvodi";
            this.Load += new System.EventHandler(this.Proizvodi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUcitaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Proizvod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kategorija;
        private System.Windows.Forms.DataGridViewTextBoxColumn Količina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jedinica_mjere;
    }
}