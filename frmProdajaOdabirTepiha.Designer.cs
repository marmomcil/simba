namespace simba
{
    partial class frmProdajaOdabirTepiha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProdajaOdabirTepiha));
            this.datagridTepisi = new System.Windows.Forms.DataGridView();
            this.tepihBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pi2013HajebdbDataSet2 = new simba.pi2013HajebdbDataSet2();
            this.tepihTableAdapter = new simba.pi2013HajebdbDataSet2TableAdapters.TepihTableAdapter();
            this.daljeGmb = new System.Windows.Forms.Button();
            this.nazadGmb = new System.Windows.Forms.Button();
            this.odustaniGmb = new System.Windows.Forms.Button();
            this.secondImgBtn = new System.Windows.Forms.Button();
            this.firstImgBtn = new System.Windows.Forms.Button();
            this.slikaTepiha = new System.Windows.Forms.PictureBox();
            this.drugiKorakHeader = new System.Windows.Forms.PictureBox();
            this.sifraTepihaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dimenzijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zemljaPorijeklaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sastavDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cvorazaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Slika1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Slika2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.datagridTepisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tepihBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pi2013HajebdbDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slikaTepiha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugiKorakHeader)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridTepisi
            // 
            this.datagridTepisi.AllowUserToAddRows = false;
            this.datagridTepisi.AllowUserToDeleteRows = false;
            this.datagridTepisi.AllowUserToResizeRows = false;
            this.datagridTepisi.AutoGenerateColumns = false;
            this.datagridTepisi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridTepisi.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.datagridTepisi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.datagridTepisi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sifraTepihaDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.dimenzijeDataGridViewTextBoxColumn,
            this.zemljaPorijeklaDataGridViewTextBoxColumn,
            this.sastavDataGridViewTextBoxColumn,
            this.cvorazaDataGridViewTextBoxColumn,
            this.cijenaDataGridViewTextBoxColumn,
            this.chk,
            this.Slika1,
            this.Slika2});
            this.datagridTepisi.DataSource = this.tepihBindingSource;
            this.datagridTepisi.Location = new System.Drawing.Point(4, 136);
            this.datagridTepisi.Name = "datagridTepisi";
            this.datagridTepisi.ReadOnly = true;
            this.datagridTepisi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridTepisi.Size = new System.Drawing.Size(617, 328);
            this.datagridTepisi.TabIndex = 1;
            this.datagridTepisi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridTepisi_CellContentClick);
            this.datagridTepisi.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.datagridTepisi_CellMouseDown);
            // 
            // tepihBindingSource
            // 
            this.tepihBindingSource.DataMember = "Tepih";
            this.tepihBindingSource.DataSource = this.pi2013HajebdbDataSet2;
            // 
            // pi2013HajebdbDataSet2
            // 
            this.pi2013HajebdbDataSet2.DataSetName = "pi2013HajebdbDataSet2";
            this.pi2013HajebdbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tepihTableAdapter
            // 
            this.tepihTableAdapter.ClearBeforeFill = true;
            // 
            // daljeGmb
            // 
            this.daljeGmb.Location = new System.Drawing.Point(747, 470);
            this.daljeGmb.Name = "daljeGmb";
            this.daljeGmb.Size = new System.Drawing.Size(108, 33);
            this.daljeGmb.TabIndex = 4;
            this.daljeGmb.Text = "Dalje";
            this.daljeGmb.UseVisualStyleBackColor = true;
            this.daljeGmb.Click += new System.EventHandler(this.daljeGmb_Click);
            // 
            // nazadGmb
            // 
            this.nazadGmb.Location = new System.Drawing.Point(627, 470);
            this.nazadGmb.Name = "nazadGmb";
            this.nazadGmb.Size = new System.Drawing.Size(109, 33);
            this.nazadGmb.TabIndex = 5;
            this.nazadGmb.Text = "Nazad";
            this.nazadGmb.UseVisualStyleBackColor = true;
            this.nazadGmb.Click += new System.EventHandler(this.nazadGmb_Click);
            // 
            // odustaniGmb
            // 
            this.odustaniGmb.Location = new System.Drawing.Point(4, 470);
            this.odustaniGmb.Name = "odustaniGmb";
            this.odustaniGmb.Size = new System.Drawing.Size(84, 33);
            this.odustaniGmb.TabIndex = 6;
            this.odustaniGmb.Text = "Odustani";
            this.odustaniGmb.UseVisualStyleBackColor = true;
            this.odustaniGmb.Click += new System.EventHandler(this.odustaniGmb_Click);
            // 
            // secondImgBtn
            // 
            this.secondImgBtn.Image = global::simba.Properties.Resources.Actions_go_next_view_icon;
            this.secondImgBtn.Location = new System.Drawing.Point(747, 434);
            this.secondImgBtn.Name = "secondImgBtn";
            this.secondImgBtn.Size = new System.Drawing.Size(108, 30);
            this.secondImgBtn.TabIndex = 3;
            this.secondImgBtn.UseVisualStyleBackColor = true;
            this.secondImgBtn.Click += new System.EventHandler(this.secondImgBtn_Click);
            // 
            // firstImgBtn
            // 
            this.firstImgBtn.Image = global::simba.Properties.Resources.Actions_go_previous_view_icon;
            this.firstImgBtn.Location = new System.Drawing.Point(627, 434);
            this.firstImgBtn.Name = "firstImgBtn";
            this.firstImgBtn.Size = new System.Drawing.Size(109, 30);
            this.firstImgBtn.TabIndex = 2;
            this.firstImgBtn.UseVisualStyleBackColor = true;
            this.firstImgBtn.Click += new System.EventHandler(this.firstImgBtn_Click);
            // 
            // slikaTepiha
            // 
            this.slikaTepiha.Location = new System.Drawing.Point(627, 136);
            this.slikaTepiha.Name = "slikaTepiha";
            this.slikaTepiha.Size = new System.Drawing.Size(228, 292);
            this.slikaTepiha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.slikaTepiha.TabIndex = 2;
            this.slikaTepiha.TabStop = false;
            // 
            // drugiKorakHeader
            // 
            this.drugiKorakHeader.Image = global::simba.Properties.Resources._2;
            this.drugiKorakHeader.Location = new System.Drawing.Point(4, 12);
            this.drugiKorakHeader.Name = "drugiKorakHeader";
            this.drugiKorakHeader.Size = new System.Drawing.Size(851, 108);
            this.drugiKorakHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.drugiKorakHeader.TabIndex = 0;
            this.drugiKorakHeader.TabStop = false;
            // 
            // sifraTepihaDataGridViewTextBoxColumn
            // 
            this.sifraTepihaDataGridViewTextBoxColumn.DataPropertyName = "SifraTepiha";
            this.sifraTepihaDataGridViewTextBoxColumn.HeaderText = "Šifra tepiha";
            this.sifraTepihaDataGridViewTextBoxColumn.Name = "sifraTepihaDataGridViewTextBoxColumn";
            this.sifraTepihaDataGridViewTextBoxColumn.ReadOnly = true;
            this.sifraTepihaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            this.nazivDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dimenzijeDataGridViewTextBoxColumn
            // 
            this.dimenzijeDataGridViewTextBoxColumn.DataPropertyName = "Dimenzije";
            this.dimenzijeDataGridViewTextBoxColumn.HeaderText = "Dimenzije";
            this.dimenzijeDataGridViewTextBoxColumn.Name = "dimenzijeDataGridViewTextBoxColumn";
            this.dimenzijeDataGridViewTextBoxColumn.ReadOnly = true;
            this.dimenzijeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // zemljaPorijeklaDataGridViewTextBoxColumn
            // 
            this.zemljaPorijeklaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.zemljaPorijeklaDataGridViewTextBoxColumn.DataPropertyName = "ZemljaPorijekla";
            this.zemljaPorijeklaDataGridViewTextBoxColumn.HeaderText = "Zemlja porijekla";
            this.zemljaPorijeklaDataGridViewTextBoxColumn.Name = "zemljaPorijeklaDataGridViewTextBoxColumn";
            this.zemljaPorijeklaDataGridViewTextBoxColumn.ReadOnly = true;
            this.zemljaPorijeklaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.zemljaPorijeklaDataGridViewTextBoxColumn.Width = 86;
            // 
            // sastavDataGridViewTextBoxColumn
            // 
            this.sastavDataGridViewTextBoxColumn.DataPropertyName = "Sastav";
            this.sastavDataGridViewTextBoxColumn.HeaderText = "Sastav";
            this.sastavDataGridViewTextBoxColumn.Name = "sastavDataGridViewTextBoxColumn";
            this.sastavDataGridViewTextBoxColumn.ReadOnly = true;
            this.sastavDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cvorazaDataGridViewTextBoxColumn
            // 
            this.cvorazaDataGridViewTextBoxColumn.DataPropertyName = "Cvoraza";
            this.cvorazaDataGridViewTextBoxColumn.HeaderText = "Čvoraza";
            this.cvorazaDataGridViewTextBoxColumn.Name = "cvorazaDataGridViewTextBoxColumn";
            this.cvorazaDataGridViewTextBoxColumn.ReadOnly = true;
            this.cvorazaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cijenaDataGridViewTextBoxColumn
            // 
            this.cijenaDataGridViewTextBoxColumn.DataPropertyName = "Cijena";
            this.cijenaDataGridViewTextBoxColumn.HeaderText = "Cijena";
            this.cijenaDataGridViewTextBoxColumn.Name = "cijenaDataGridViewTextBoxColumn";
            this.cijenaDataGridViewTextBoxColumn.ReadOnly = true;
            this.cijenaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // chk
            // 
            this.chk.HeaderText = "Označi";
            this.chk.Name = "chk";
            this.chk.ReadOnly = true;
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
            // frmProdajaOdabirTepiha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(867, 523);
            this.Controls.Add(this.odustaniGmb);
            this.Controls.Add(this.nazadGmb);
            this.Controls.Add(this.daljeGmb);
            this.Controls.Add(this.secondImgBtn);
            this.Controls.Add(this.firstImgBtn);
            this.Controls.Add(this.slikaTepiha);
            this.Controls.Add(this.datagridTepisi);
            this.Controls.Add(this.drugiKorakHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(880, 600);
            this.MinimumSize = new System.Drawing.Size(875, 550);
            this.Name = "frmProdajaOdabirTepiha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2. korak - Odaberite tepih";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmProdajaOdabirTepiha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridTepisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tepihBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pi2013HajebdbDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slikaTepiha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugiKorakHeader)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox drugiKorakHeader;
        private System.Windows.Forms.DataGridView datagridTepisi;
        private pi2013HajebdbDataSet2 pi2013HajebdbDataSet2;
        private System.Windows.Forms.BindingSource tepihBindingSource;
        private pi2013HajebdbDataSet2TableAdapters.TepihTableAdapter tepihTableAdapter;
        private System.Windows.Forms.PictureBox slikaTepiha;
        private System.Windows.Forms.Button firstImgBtn;
        private System.Windows.Forms.Button secondImgBtn;
        private System.Windows.Forms.Button daljeGmb;
        private System.Windows.Forms.Button nazadGmb;
        private System.Windows.Forms.Button odustaniGmb;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifraTepihaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dimenzijeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zemljaPorijeklaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sastavDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cvorazaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chk;
        private System.Windows.Forms.DataGridViewTextBoxColumn Slika1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Slika2;
    }
}