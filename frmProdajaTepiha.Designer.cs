namespace simba
{
    partial class frmProdajaTepiha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProdajaTepiha));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.daljeGmb = new System.Windows.Forms.Button();
            this.odustaniGmb = new System.Windows.Forms.Button();
            this.prviKorakSidebar = new System.Windows.Forms.PictureBox();
            this.prviKorakHeader = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.prviKorakSidebar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prviKorakHeader)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(198, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(624, 81);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ovaj čarobnjak će vas u par kratkih koraka voditi kroz proces kupovine";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(429, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 44);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dobrodošli!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // daljeGmb
            // 
            this.daljeGmb.Location = new System.Drawing.Point(697, 440);
            this.daljeGmb.Name = "daljeGmb";
            this.daljeGmb.Size = new System.Drawing.Size(142, 44);
            this.daljeGmb.TabIndex = 5;
            this.daljeGmb.Text = "Dalje";
            this.daljeGmb.UseVisualStyleBackColor = true;
            this.daljeGmb.Click += new System.EventHandler(this.daljeGmb_Click);
            // 
            // odustaniGmb
            // 
            this.odustaniGmb.Location = new System.Drawing.Point(500, 440);
            this.odustaniGmb.Name = "odustaniGmb";
            this.odustaniGmb.Size = new System.Drawing.Size(142, 44);
            this.odustaniGmb.TabIndex = 6;
            this.odustaniGmb.Text = "Odustani";
            this.odustaniGmb.UseVisualStyleBackColor = true;
            this.odustaniGmb.Click += new System.EventHandler(this.odustaniGmb_Click);
            // 
            // prviKorakSidebar
            // 
            this.prviKorakSidebar.Image = global::simba.Properties.Resources._0;
            this.prviKorakSidebar.Location = new System.Drawing.Point(12, 140);
            this.prviKorakSidebar.Name = "prviKorakSidebar";
            this.prviKorakSidebar.Size = new System.Drawing.Size(116, 344);
            this.prviKorakSidebar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.prviKorakSidebar.TabIndex = 8;
            this.prviKorakSidebar.TabStop = false;
            // 
            // prviKorakHeader
            // 
            this.prviKorakHeader.Image = global::simba.Properties.Resources._1;
            this.prviKorakHeader.Location = new System.Drawing.Point(12, 12);
            this.prviKorakHeader.Name = "prviKorakHeader";
            this.prviKorakHeader.Size = new System.Drawing.Size(827, 105);
            this.prviKorakHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.prviKorakHeader.TabIndex = 7;
            this.prviKorakHeader.TabStop = false;
            // 
            // frmProdajaTepiha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 507);
            this.Controls.Add(this.prviKorakSidebar);
            this.Controls.Add(this.prviKorakHeader);
            this.Controls.Add(this.odustaniGmb);
            this.Controls.Add(this.daljeGmb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(859, 534);
            this.MinimumSize = new System.Drawing.Size(859, 534);
            this.Name = "frmProdajaTepiha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "1. korak";
            ((System.ComponentModel.ISupportInitialize)(this.prviKorakSidebar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prviKorakHeader)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button daljeGmb;
        private System.Windows.Forms.Button odustaniGmb;
        private System.Windows.Forms.PictureBox prviKorakHeader;
        private System.Windows.Forms.PictureBox prviKorakSidebar;
    }
}