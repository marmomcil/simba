namespace simba
{
    partial class frmGlavniIzbornik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGlavniIzbornik));
            this.btnKatalog = new System.Windows.Forms.Button();
            this.btnKupci = new System.Windows.Forms.Button();
            this.btnProdaja = new System.Windows.Forms.Button();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKatalog
            // 
            this.btnKatalog.BackgroundImage = global::simba.Properties.Resources.Catalog20Icon2_333154_std;
            this.btnKatalog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKatalog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnKatalog.Location = new System.Drawing.Point(39, 27);
            this.btnKatalog.Name = "btnKatalog";
            this.btnKatalog.Size = new System.Drawing.Size(118, 100);
            this.btnKatalog.TabIndex = 0;
            this.btnKatalog.UseVisualStyleBackColor = true;
            this.btnKatalog.Click += new System.EventHandler(this.btnKatalog_Click);
            // 
            // btnKupci
            // 
            this.btnKupci.BackgroundImage = global::simba.Properties.Resources.kupac;
            this.btnKupci.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKupci.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnKupci.Location = new System.Drawing.Point(229, 105);
            this.btnKupci.Name = "btnKupci";
            this.btnKupci.Size = new System.Drawing.Size(118, 100);
            this.btnKupci.TabIndex = 1;
            this.btnKupci.UseVisualStyleBackColor = true;
            this.btnKupci.Click += new System.EventHandler(this.btnKupci_Click);
            // 
            // btnProdaja
            // 
            this.btnProdaja.BackgroundImage = global::simba.Properties.Resources.cash_reg;
            this.btnProdaja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProdaja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnProdaja.Location = new System.Drawing.Point(415, 181);
            this.btnProdaja.Name = "btnProdaja";
            this.btnProdaja.Size = new System.Drawing.Size(118, 100);
            this.btnProdaja.TabIndex = 2;
            this.btnProdaja.UseVisualStyleBackColor = true;
            this.btnProdaja.Click += new System.EventHandler(this.btnProdaja_Click);
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.BackgroundImage = global::simba.Properties.Resources.izlaz;
            this.btnIzlaz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIzlaz.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnIzlaz.Location = new System.Drawing.Point(598, 266);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(118, 100);
            this.btnIzlaz.TabIndex = 3;
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 433);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(756, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // frmGlavniIzbornik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::simba.Properties.Resources.Fresh_Water_Windows_7_Wallpaper_HD;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(756, 455);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.btnProdaja);
            this.Controls.Add(this.btnKupci);
            this.Controls.Add(this.btnKatalog);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGlavniIzbornik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GLAVNI IZBORNIK";
            this.Load += new System.EventHandler(this.glavniIzbornik_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKatalog;
        private System.Windows.Forms.Button btnKupci;
        private System.Windows.Forms.Button btnProdaja;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}