
namespace fakturace2021
{
    partial class ZboziForm
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
            this.IdZbozi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NazevZbozi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cenaBezDph = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.naSklade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtBoxFiltrZbozi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pridatZboziToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odebratZboziToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdZbozi,
            this.NazevZbozi,
            this.cenaBezDph,
            this.naSklade});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 79);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(733, 359);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            // 
            // IdZbozi
            // 
            this.IdZbozi.Text = "Id Zbozi";
            // 
            // NazevZbozi
            // 
            this.NazevZbozi.Text = "Nazev";
            this.NazevZbozi.Width = 95;
            // 
            // cenaBezDph
            // 
            this.cenaBezDph.Text = "Cena bez DPH";
            this.cenaBezDph.Width = 94;
            // 
            // naSklade
            // 
            this.naSklade.Text = "Na skladě";
            // 
            // txtBoxFiltrZbozi
            // 
            this.txtBoxFiltrZbozi.Location = new System.Drawing.Point(42, 53);
            this.txtBoxFiltrZbozi.Name = "txtBoxFiltrZbozi";
            this.txtBoxFiltrZbozi.Size = new System.Drawing.Size(100, 20);
            this.txtBoxFiltrZbozi.TabIndex = 2;
            this.txtBoxFiltrZbozi.TextChanged += new System.EventHandler(this.txtBoxFiltrZbozi_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filtr";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pridatZboziToolStripMenuItem,
            this.odebratZboziToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pridatZboziToolStripMenuItem
            // 
            this.pridatZboziToolStripMenuItem.Name = "pridatZboziToolStripMenuItem";
            this.pridatZboziToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.pridatZboziToolStripMenuItem.Text = "Pridat Zbozi";
            this.pridatZboziToolStripMenuItem.Click += new System.EventHandler(this.pridatZboziToolStripMenuItem_Click);
            // 
            // odebratZboziToolStripMenuItem
            // 
            this.odebratZboziToolStripMenuItem.Name = "odebratZboziToolStripMenuItem";
            this.odebratZboziToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.odebratZboziToolStripMenuItem.Text = "Odebrat Zbozi";
            // 
            // ZboziForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxFiltrZbozi);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ZboziForm";
            this.Text = "ZboziForm";
            this.Load += new System.EventHandler(this.ZboziForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader NazevZbozi;
        private System.Windows.Forms.ColumnHeader cenaBezDph;
        private System.Windows.Forms.ColumnHeader naSklade;
        private System.Windows.Forms.TextBox txtBoxFiltrZbozi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader IdZbozi;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pridatZboziToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odebratZboziToolStripMenuItem;
    }
}