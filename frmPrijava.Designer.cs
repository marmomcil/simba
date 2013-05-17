namespace simba
{
    partial class frmPrijava
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrijava));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kriviUnos = new System.Windows.Forms.Label();
            this.btnPrijava = new System.Windows.Forms.Button();
            this.txtKorisnickoIme = new System.Windows.Forms.ComboBox();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Name = "label2";
            // 
            // kriviUnos
            // 
            this.kriviUnos.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.kriviUnos, "kriviUnos");
            this.kriviUnos.Name = "kriviUnos";
            // 
            // btnPrijava
            // 
            this.btnPrijava.BackColor = System.Drawing.Color.Transparent;
            this.btnPrijava.BackgroundImage = global::simba.Properties.Resources.login;
            resources.ApplyResources(this.btnPrijava, "btnPrijava");
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.UseVisualStyleBackColor = false;
            this.btnPrijava.Click += new System.EventHandler(this.btnPotvrda_Click);
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtKorisnickoIme.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtKorisnickoIme.FormattingEnabled = true;
            this.txtKorisnickoIme.Items.AddRange(new object[] {
            resources.GetString("txtKorisnickoIme.Items"),
            resources.GetString("txtKorisnickoIme.Items1"),
            resources.GetString("txtKorisnickoIme.Items2"),
            resources.GetString("txtKorisnickoIme.Items3"),
            resources.GetString("txtKorisnickoIme.Items4")});
            resources.ApplyResources(this.txtKorisnickoIme, "txtKorisnickoIme");
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.SelectedValueChanged += new System.EventHandler(this.txtKorisnickoIme_SelectedValueChanged);
            // 
            // txtLozinka
            // 
            resources.ApplyResources(this.txtLozinka, "txtLozinka");
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.TextChanged += new System.EventHandler(this.txtLozinka_TextChanged);
            this.txtLozinka.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLozinka_KeyPress);
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.BackgroundImage = global::simba.Properties.Resources._1328101995_Logout;
            resources.ApplyResources(this.btnIzlaz, "btnIzlaz");
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // frmPrijava
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BackgroundImage = global::simba.Properties.Resources.Fresh_Water_Windows_7_Wallpaper_HD;
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.txtKorisnickoIme);
            this.Controls.Add(this.btnPrijava);
            this.Controls.Add(this.kriviUnos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "frmPrijava";
            this.Load += new System.EventHandler(this.frmPrijava_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label kriviUnos;
        private System.Windows.Forms.Button btnPrijava;
        private System.Windows.Forms.ComboBox txtKorisnickoIme;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.Button btnIzlaz;
    }
}

