namespace Aplikacija_za_Maloprodajnu_Trgovinu.forme
{
    partial class RacunForma
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
            this.dataGridViewRacun = new System.Windows.Forms.DataGridView();
            this.Kupac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kategorija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proizvod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Količina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ukupna_cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRacun)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRacun
            // 
            this.dataGridViewRacun.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewRacun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRacun.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Kupac,
            this.Kategorija,
            this.Proizvod,
            this.Cijena,
            this.Količina,
            this.Ukupna_cijena});
            this.dataGridViewRacun.Location = new System.Drawing.Point(12, 2);
            this.dataGridViewRacun.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewRacun.Name = "dataGridViewRacun";
            this.dataGridViewRacun.RowHeadersWidth = 62;
            this.dataGridViewRacun.RowTemplate.Height = 28;
            this.dataGridViewRacun.Size = new System.Drawing.Size(1411, 358);
            this.dataGridViewRacun.TabIndex = 7;
            this.dataGridViewRacun.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRacun_CellContentClick);
            // 
            // Kupac
            // 
            this.Kupac.HeaderText = "Kupac";
            this.Kupac.MinimumWidth = 8;
            this.Kupac.Name = "Kupac";
            this.Kupac.Width = 150;
            // 
            // Kategorija
            // 
            this.Kategorija.HeaderText = "Kategorija";
            this.Kategorija.MinimumWidth = 6;
            this.Kategorija.Name = "Kategorija";
            this.Kategorija.Width = 125;
            // 
            // Proizvod
            // 
            this.Proizvod.HeaderText = "Proizvod";
            this.Proizvod.MinimumWidth = 8;
            this.Proizvod.Name = "Proizvod";
            this.Proizvod.Width = 150;
            // 
            // Cijena
            // 
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.MinimumWidth = 8;
            this.Cijena.Name = "Cijena";
            this.Cijena.Width = 150;
            // 
            // Količina
            // 
            this.Količina.HeaderText = "Količina";
            this.Količina.MinimumWidth = 8;
            this.Količina.Name = "Količina";
            this.Količina.Width = 150;
            // 
            // Ukupna_cijena
            // 
            this.Ukupna_cijena.HeaderText = "Ukupna_cijena";
            this.Ukupna_cijena.MinimumWidth = 8;
            this.Ukupna_cijena.Name = "Ukupna_cijena";
            this.Ukupna_cijena.Width = 150;
            // 
            // RacunForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Aplikacija_za_Maloprodajnu_Trgovinu.Properties.Resources.racun;
            this.ClientSize = new System.Drawing.Size(1436, 450);
            this.Controls.Add(this.dataGridViewRacun);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RacunForma";
            this.Text = "Racun";
            this.Load += new System.EventHandler(this.Racun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRacun)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewRacun;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kupac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kategorija;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proizvod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Količina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ukupna_cijena;
    }
}