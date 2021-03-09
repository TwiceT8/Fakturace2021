
namespace fakturace2021
{
    partial class FakturaceForm
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
            this.ZboziFakturace = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ZakaznikFakturace = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DatumFakturace = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ZboziFakturace,
            this.ZakaznikFakturace,
            this.DatumFakturace});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 72);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(821, 371);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ZboziFakturace
            // 
            this.ZboziFakturace.Text = "Zbozi";
            this.ZboziFakturace.Width = 199;
            // 
            // ZakaznikFakturace
            // 
            this.ZakaznikFakturace.Text = "zákazník";
            this.ZakaznikFakturace.Width = 124;
            // 
            // DatumFakturace
            // 
            this.DatumFakturace.Text = "Datum";
            // 
            // FakturaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 443);
            this.Controls.Add(this.listView1);
            this.Name = "FakturaceForm";
            this.Text = "FakturaceForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ZboziFakturace;
        private System.Windows.Forms.ColumnHeader ZakaznikFakturace;
        private System.Windows.Forms.ColumnHeader DatumFakturace;
    }
}