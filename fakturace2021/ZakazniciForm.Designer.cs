
namespace fakturace2021
{
    partial class ZakazniciForm
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.Nazev = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Typ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Adresa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ico = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Telefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.IdZakaznici = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdZakaznici,
            this.Nazev,
            this.Typ,
            this.Adresa,
            this.Ico,
            this.Email,
            this.Telefon});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(14, 79);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(733, 359);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            // 
            // Nazev
            // 
            this.Nazev.Text = "Nazev";
            this.Nazev.Width = 96;
            // 
            // Typ
            // 
            this.Typ.Text = "Typ";
            this.Typ.Width = 80;
            // 
            // Adresa
            // 
            this.Adresa.Text = "Adresa";
            this.Adresa.Width = 128;
            // 
            // Ico
            // 
            this.Ico.Text = "IČO";
            this.Ico.Width = 85;
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.Width = 103;
            // 
            // Telefon
            // 
            this.Telefon.Text = "Telefon";
            this.Telefon.Width = 108;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "filtr";
            // 
            // IdZakaznici
            // 
            this.IdZakaznici.Text = "Id";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Firma",
            "Zivnostnik",
            "Vše"});
            this.comboBox1.Location = new System.Drawing.Point(37, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ZakazniciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Name = "ZakazniciForm";
            this.Text = "ZakazniciForm";
            this.Load += new System.EventHandler(this.ZakazniciForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Nazev;
        private System.Windows.Forms.ColumnHeader Typ;
        private System.Windows.Forms.ColumnHeader Adresa;
        private System.Windows.Forms.ColumnHeader Ico;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader Telefon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader IdZakaznici;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}