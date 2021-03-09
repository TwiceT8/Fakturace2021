
namespace fakturace2021
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnZbozi = new System.Windows.Forms.Button();
            this.btnZakaznici = new System.Windows.Forms.Button();
            this.btnFaktury = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnZbozi
            // 
            this.btnZbozi.Location = new System.Drawing.Point(131, 12);
            this.btnZbozi.Name = "btnZbozi";
            this.btnZbozi.Size = new System.Drawing.Size(114, 68);
            this.btnZbozi.TabIndex = 0;
            this.btnZbozi.Text = "Zbozi";
            this.btnZbozi.UseVisualStyleBackColor = true;
            this.btnZbozi.Click += new System.EventHandler(this.btnZbozi_Click);
            // 
            // btnZakaznici
            // 
            this.btnZakaznici.Location = new System.Drawing.Point(11, 12);
            this.btnZakaznici.Name = "btnZakaznici";
            this.btnZakaznici.Size = new System.Drawing.Size(114, 68);
            this.btnZakaznici.TabIndex = 1;
            this.btnZakaznici.Text = "Zakaznici";
            this.btnZakaznici.UseVisualStyleBackColor = true;
            this.btnZakaznici.Click += new System.EventHandler(this.btnZakaznici_Click);
            // 
            // btnFaktury
            // 
            this.btnFaktury.Location = new System.Drawing.Point(251, 12);
            this.btnFaktury.Name = "btnFaktury";
            this.btnFaktury.Size = new System.Drawing.Size(114, 68);
            this.btnFaktury.TabIndex = 2;
            this.btnFaktury.Text = "faktury";
            this.btnFaktury.UseVisualStyleBackColor = true;
            this.btnFaktury.Click += new System.EventHandler(this.btnFaktury_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 93);
            this.Controls.Add(this.btnFaktury);
            this.Controls.Add(this.btnZakaznici);
            this.Controls.Add(this.btnZbozi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnZbozi;
        private System.Windows.Forms.Button btnZakaznici;
        private System.Windows.Forms.Button btnFaktury;
    }
}

