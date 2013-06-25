namespace simba
{
    partial class frmPregledKataloga
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPregledKataloga));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.btnSpremiPromjene = new System.Windows.Forms.Button();
            this.btnIzbrisiTepih = new System.Windows.Forms.Button();
            this.btnAzurirajTepih = new System.Windows.Forms.Button();
            this.btnDodajTepih = new System.Windows.Forms.Button();
            this.txtTraziTepih = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPregledKataloga = new System.Windows.Forms.DataGridView();
            this.sifraTepihaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dimenzijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zemljaPorijeklaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sastavDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cvorazaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Slika1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Slika2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tepihBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pi2013HajebdbDataSet1 = new simba.pi2013HajebdbDataSet1();
            this.tepihTableAdapter = new simba.pi2013HajebdbDataSet1TableAdapters.TepihTableAdapter();
            this.imgTepih = new System.Windows.Forms.PictureBox();
            this.secondImgBtn = new System.Windows.Forms.Button();
            this.firstImgBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregledKataloga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tepihBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pi2013HajebdbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTepih)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIzlaz);
            this.groupBox1.Controls.Add(this.btnSpremiPromjene);
            this.groupBox1.Controls.Add(this.btnIzbrisiTepih);
            this.groupBox1.Controls.Add(this.btnAzurirajTepih);
            this.groupBox1.Controls.Add(this.btnDodajTepih);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 129);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opcije";
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.BackgroundImage = global::simba.Properties.Resources.izlaz;
            this.btnIzlaz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIzlaz.Location = new System.Drawing.Point(425, 49);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(74, 62);
            this.btnIzlaz.TabIndex = 6;
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // btnSpremiPromjene
            // 
            this.btnSpremiPromjene.BackgroundImage = global::simba.Properties.Resources.SaveIcon;
            this.btnSpremiPromjene.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSpremiPromjene.Location = new System.Drawing.Point(326, 49);
            this.btnSpremiPromjene.Name = "btnSpremiPromjene";
            this.btnSpremiPromjene.Size = new System.Drawing.Size(74, 62);
            this.btnSpremiPromjene.TabIndex = 5;
            this.btnSpremiPromjene.UseVisualStyleBackColor = true;
            this.btnSpremiPromjene.Click += new System.EventHandler(this.btnSpremiPromjene_Click);
            // 
            // btnIzbrisiTepih
            // 
            this.btnIzbrisiTepih.BackgroundImage = global::simba.Properties.Resources.ObrisiTepih;
            this.btnIzbrisiTepih.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIzbrisiTepih.Location = new System.Drawing.Point(225, 49);
            this.btnIzbrisiTepih.Name = "btnIzbrisiTepih";
            this.btnIzbrisiTepih.Size = new System.Drawing.Size(74, 62);
            this.btnIzbrisiTepih.TabIndex = 4;
            this.btnIzbrisiTepih.UseVisualStyleBackColor = true;
            this.btnIzbrisiTepih.Click += new System.EventHandler(this.btnIzbrisiTepih_Click);
            // 
            // btnAzurirajTepih
            // 
            this.btnAzurirajTepih.BackgroundImage = global::simba.Properties.Resources.Uredi;
            this.btnAzurirajTepih.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAzurirajTepih.Location = new System.Drawing.Point(121, 49);
            this.btnAzurirajTepih.Name = "btnAzurirajTepih";
            this.btnAzurirajTepih.Size = new System.Drawing.Size(74, 62);
            this.btnAzurirajTepih.TabIndex = 3;
            this.btnAzurirajTepih.UseVisualStyleBackColor = true;
            this.btnAzurirajTepih.Click += new System.EventHandler(this.btnAzurirajTepih_Click);
            // 
            // btnDodajTepih
            // 
            this.btnDodajTepih.BackgroundImage = global::simba.Properties.Resources.DodajNovi;
            this.btnDodajTepih.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDodajTepih.Location = new System.Drawing.Point(18, 49);
            this.btnDodajTepih.Name = "btnDodajTepih";
            this.btnDodajTepih.Size = new System.Drawing.Size(74, 62);
            this.btnDodajTepih.TabIndex = 2;
            this.btnDodajTepih.UseVisualStyleBackColor = true;
            this.btnDodajTepih.Click += new System.EventHandler(this.btnDodajTepih_Click);
            // 
            // txtTraziTepih
            // 
            this.txtTraziTepih.Location = new System.Drawing.Point(578, 97);
            this.txtTraziTepih.Name = "txtTraziTepih";
            this.txtTraziTepih.Size = new System.Drawing.Size(316, 23);
            this.txtTraziTepih.TabIndex = 17;
            this.txtTraziTepih.TextChanged += new System.EventHandler(this.txtTraziTepih_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(575, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Pretraživanje";
            // 
            // dgvPregledKataloga
            // 
            this.dgvPregledKataloga.AutoGenerateColumns = false;
            this.dgvPregledKataloga.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPregledKataloga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPregledKataloga.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sifraTepihaDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.dimenzijeDataGridViewTextBoxColumn,
            this.zemljaPorijeklaDataGridViewTextBoxColumn,
            this.sastavDataGridViewTextBoxColumn,
            this.cvorazaDataGridViewTextBoxColumn,
            this.cijenaDataGridViewTextBoxColumn,
            this.Slika1,
            this.Slika2});
            this.dgvPregledKataloga.DataSource = this.tepihBindingSource;
            this.dgvPregledKataloga.Location = new System.Drawing.Point(12, 176);
            this.dgvPregledKataloga.Name = "dgvPregledKataloga";
            this.dgvPregledKataloga.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPregledKataloga.Size = new System.Drawing.Size(882, 385);
            this.dgvPregledKataloga.TabIndex = 18;
            this.dgvPregledKataloga.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.datagridTepisi_CellMouseDown);
            this.dgvPregledKataloga.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvPregledKataloga_DataBindingComplete);
            // 
            // sifraTepihaDataGridViewTextBoxColumn
            // 
            this.sifraTepihaDataGridViewTextBoxColumn.DataPropertyName = "SifraTepiha";
            this.sifraTepihaDataGridViewTextBoxColumn.HeaderText = "Sifra tepiha";
            this.sifraTepihaDataGridViewTextBoxColumn.Name = "sifraTepihaDataGridViewTextBoxColumn";
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            // 
            // dimenzijeDataGridViewTextBoxColumn
            // 
            this.dimenzijeDataGridViewTextBoxColumn.DataPropertyName = "Dimenzije";
            this.dimenzijeDataGridViewTextBoxColumn.HeaderText = "Dimenzije";
            this.dimenzijeDataGridViewTextBoxColumn.Name = "dimenzijeDataGridViewTextBoxColumn";
            // 
            // zemljaPorijeklaDataGridViewTextBoxColumn
            // 
            this.zemljaPorijeklaDataGridViewTextBoxColumn.DataPropertyName = "ZemljaPorijekla";
            this.zemljaPorijeklaDataGridViewTextBoxColumn.HeaderText = "Zemlja porijekla";
            this.zemljaPorijeklaDataGridViewTextBoxColumn.Name = "zemljaPorijeklaDataGridViewTextBoxColumn";
            // 
            // sastavDataGridViewTextBoxColumn
            // 
            this.sastavDataGridViewTextBoxColumn.DataPropertyName = "Sastav";
            this.sastavDataGridViewTextBoxColumn.HeaderText = "Sastav";
            this.sastavDataGridViewTextBoxColumn.Name = "sastavDataGridViewTextBoxColumn";
            // 
            // cvorazaDataGridViewTextBoxColumn
            // 
            this.cvorazaDataGridViewTextBoxColumn.DataPropertyName = "Cvoraza";
            this.cvorazaDataGridViewTextBoxColumn.HeaderText = "Cvoraza";
            this.cvorazaDataGridViewTextBoxColumn.Name = "cvorazaDataGridViewTextBoxColumn";
            // 
            // cijenaDataGridViewTextBoxColumn
            // 
            this.cijenaDataGridViewTextBoxColumn.DataPropertyName = "Cijena";
            this.cijenaDataGridViewTextBoxColumn.HeaderText = "Cijena";
            this.cijenaDataGridViewTextBoxColumn.Name = "cijenaDataGridViewTextBoxColumn";
            // 
            // Slika1
            // 
            this.Slika1.DataPropertyName = "Slika1";
            this.Slika1.HeaderText = "Slika1";
            this.Slika1.Name = "Slika1";
            this.Slika1.ReadOnly = true;
            this.Slika1.Visible = false;
            // 
            // Slika2
            // 
            this.Slika2.DataPropertyName = "Slika2";
            this.Slika2.HeaderText = "Slika2";
            this.Slika2.Name = "Slika2";
            this.Slika2.ReadOnly = true;
            this.Slika2.Visible = false;
            // 
            // tepihBindingSource
            // 
            this.tepihBindingSource.DataMember = "Tepih";
            this.tepihBindingSource.DataSource = this.pi2013HajebdbDataSet1;
            // 
            // pi2013HajebdbDataSet1
            // 
            this.pi2013HajebdbDataSet1.DataSetName = "pi2013HajebdbDataSet1";
            this.pi2013HajebdbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tepihTableAdapter
            // 
            this.tepihTableAdapter.ClearBeforeFill = true;
            // 
            // imgTepih
            // 
            this.imgTepih.Location = new System.Drawing.Point(900, 176);
            this.imgTepih.Name = "imgTepih";
            this.imgTepih.Size = new System.Drawing.Size(286, 349);
            this.imgTepih.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgTepih.TabIndex = 19;
            this.imgTepih.TabStop = false;
            // 
            // secondImgBtn
            // 
            this.secondImgBtn.Image = global::simba.Properties.Resources.Actions_go_next_view_icon;
            this.secondImgBtn.Location = new System.Drawing.Point(1078, 531);
            this.secondImgBtn.Name = "secondImgBtn";
            this.secondImgBtn.Size = new System.Drawing.Size(108, 30);
            this.secondImgBtn.TabIndex = 21;
            this.secondImgBtn.UseVisualStyleBackColor = true;
            this.secondImgBtn.Click += new System.EventHandler(this.secondImgBtn_Click);
            // 
            // firstImgBtn
            // 
            this.firstImgBtn.Image = global::simba.Properties.Resources.Actions_go_previous_view_icon;
            this.firstImgBtn.Location = new System.Drawing.Point(900, 531);
            this.firstImgBtn.Name = "firstImgBtn";
            this.firstImgBtn.Size = new System.Drawing.Size(109, 30);
            this.firstImgBtn.TabIndex = 20;
            this.firstImgBtn.UseVisualStyleBackColor = true;
            this.firstImgBtn.Click += new System.EventHandler(this.firstImgBtn_Click);
            // 
            // frmPregledKataloga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 573);
            this.Controls.Add(this.secondImgBtn);
            this.Controls.Add(this.firstImgBtn);
            this.Controls.Add(this.imgTepih);
            this.Controls.Add(this.dgvPregledKataloga);
            this.Controls.Add(this.txtTraziTepih);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmPregledKataloga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregled kataloga";
            this.Load += new System.EventHandler(this.frmPregledKataloga_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregledKataloga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tepihBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pi2013HajebdbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTepih)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnIzbrisiTepih;
        private System.Windows.Forms.Button btnAzurirajTepih;
        private System.Windows.Forms.Button btnDodajTepih;
        private System.Windows.Forms.Button btnSpremiPromjene;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.TextBox txtTraziTepih;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPregledKataloga;
        private pi2013HajebdbDataSet1 pi2013HajebdbDataSet1;
        private System.Windows.Forms.BindingSource tepihBindingSource;
        private pi2013HajebdbDataSet1TableAdapters.TepihTableAdapter tepihTableAdapter;
        private System.Windows.Forms.PictureBox imgTepih;
        private System.Windows.Forms.Button secondImgBtn;
        private System.Windows.Forms.Button firstImgBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifraTepihaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dimenzijeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zemljaPorijeklaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sastavDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cvorazaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Slika1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Slika2;

    }
}