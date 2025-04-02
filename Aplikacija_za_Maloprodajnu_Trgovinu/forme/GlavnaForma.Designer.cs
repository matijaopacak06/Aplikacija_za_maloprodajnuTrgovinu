namespace Aplikacija_za_Maloprodajnu_Trgovinu.forme
{
    partial class GlavnaForma
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
            this.btnKasa = new System.Windows.Forms.Button();
            this.btnRačun = new System.Windows.Forms.Button();
            this.btnProizvodi = new System.Windows.Forms.Button();
            this.btnKupci = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKasa
            // 
            this.btnKasa.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKasa.Location = new System.Drawing.Point(11, 227);
            this.btnKasa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKasa.Name = "btnKasa";
            this.btnKasa.Size = new System.Drawing.Size(152, 50);
            this.btnKasa.TabIndex = 1;
            this.btnKasa.Text = "Kasa";
            this.btnKasa.UseVisualStyleBackColor = true;
            this.btnKasa.Click += new System.EventHandler(this.btnKasa_Click);
            // 
            // btnRačun
            // 
            this.btnRačun.BackColor = System.Drawing.Color.Transparent;
            this.btnRačun.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRačun.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRačun.Location = new System.Drawing.Point(12, 11);
            this.btnRačun.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRačun.Name = "btnRačun";
            this.btnRačun.Size = new System.Drawing.Size(152, 50);
            this.btnRačun.TabIndex = 2;
            this.btnRačun.Text = "Račun";
            this.btnRačun.UseVisualStyleBackColor = false;
            
            // 
            // btnProizvodi
            // 
            this.btnProizvodi.BackColor = System.Drawing.Color.Transparent;
            this.btnProizvodi.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnProizvodi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnProizvodi.Location = new System.Drawing.Point(396, 227);
            this.btnProizvodi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProizvodi.Name = "btnProizvodi";
            this.btnProizvodi.Size = new System.Drawing.Size(152, 50);
            this.btnProizvodi.TabIndex = 3;
            this.btnProizvodi.Text = "Proizvodi";
            this.btnProizvodi.UseVisualStyleBackColor = false;
            this.btnProizvodi.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnKupci
            // 
            this.btnKupci.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKupci.Location = new System.Drawing.Point(396, 11);
            this.btnKupci.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKupci.Name = "btnKupci";
            this.btnKupci.Size = new System.Drawing.Size(152, 50);
            this.btnKupci.TabIndex = 4;
            this.btnKupci.Text = "Kupci";
            this.btnKupci.UseVisualStyleBackColor = true;
            this.btnKupci.Click += new System.EventHandler(this.btnKupci_Click);
            // 
            // GlavnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Aplikacija_za_Maloprodajnu_Trgovinu.Properties.Resources.trgovina2;
            this.ClientSize = new System.Drawing.Size(572, 287);
            this.Controls.Add(this.btnKupci);
            this.Controls.Add(this.btnProizvodi);
            this.Controls.Add(this.btnRačun);
            this.Controls.Add(this.btnKasa);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GlavnaForma";
            this.Text = "GlavnaForma";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnKasa;
        private System.Windows.Forms.Button btnRačun;
        private System.Windows.Forms.Button btnProizvodi;
        private System.Windows.Forms.Button btnKupci;
    }
}