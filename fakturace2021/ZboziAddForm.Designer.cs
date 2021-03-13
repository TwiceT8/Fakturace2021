
namespace fakturace2021
{
    partial class ZboziAddForm
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
            this.txtBoxNazevAdd = new System.Windows.Forms.TextBox();
            this.numericZboziAdd = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPridat = new System.Windows.Forms.Button();
            this.btnStorno = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericZboziAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxNazevAdd
            // 
            this.txtBoxNazevAdd.Location = new System.Drawing.Point(102, 22);
            this.txtBoxNazevAdd.Name = "txtBoxNazevAdd";
            this.txtBoxNazevAdd.Size = new System.Drawing.Size(120, 20);
            this.txtBoxNazevAdd.TabIndex = 0;
            // 
            // numericZboziAdd
            // 
            this.numericZboziAdd.Location = new System.Drawing.Point(102, 49);
            this.numericZboziAdd.Name = "numericZboziAdd";
            this.numericZboziAdd.Size = new System.Drawing.Size(120, 20);
            this.numericZboziAdd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Název produktu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cena bez DPH:";
            // 
            // btnPridat
            // 
            this.btnPridat.Location = new System.Drawing.Point(20, 78);
            this.btnPridat.Name = "btnPridat";
            this.btnPridat.Size = new System.Drawing.Size(75, 23);
            this.btnPridat.TabIndex = 4;
            this.btnPridat.Text = "Pridat";
            this.btnPridat.UseVisualStyleBackColor = true;
            // 
            // btnStorno
            // 
            this.btnStorno.Location = new System.Drawing.Point(127, 78);
            this.btnStorno.Name = "btnStorno";
            this.btnStorno.Size = new System.Drawing.Size(75, 23);
            this.btnStorno.TabIndex = 5;
            this.btnStorno.Text = "Storno";
            this.btnStorno.UseVisualStyleBackColor = true;
            // 
            // ZboziAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 116);
            this.Controls.Add(this.btnStorno);
            this.Controls.Add(this.btnPridat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericZboziAdd);
            this.Controls.Add(this.txtBoxNazevAdd);
            this.Name = "ZboziAddForm";
            this.Text = "ZboziAddForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericZboziAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxNazevAdd;
        private System.Windows.Forms.NumericUpDown numericZboziAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPridat;
        private System.Windows.Forms.Button btnStorno;
    }
}