namespace simba
{
    partial class frmProdajaOdabirKupca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProdajaOdabirKupca));
            this.treciKorakHeader = new System.Windows.Forms.PictureBox();
            this.datagridKupci = new System.Windows.Forms.DataGridView();
            this.oIBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.poslovniPartnerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pi2013HajebdbDataSet = new simba.pi2013HajebdbDataSet();
            this.poslovniPartnerTableAdapter = new simba.pi2013HajebdbDataSetTableAdapters.PoslovniPartnerTableAdapter();
            this.odustaniGmb = new System.Windows.Forms.Button();
            this.daljeGmb = new System.Windows.Forms.Button();
            this.nazadGmb = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.treciKorakHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridKupci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poslovniPartnerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pi2013HajebdbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // treciKorakHeader
            // 
            this.treciKorakHeader.Image = global::simba.Properties.Resources._3;
            this.treciKorakHeader.Location = new System.Drawing.Point(12, 12);
            this.treciKorakHeader.Name = "treciKorakHeader";
            this.treciKorakHeader.Size = new System.Drawing.Size(827, 103);
            this.treciKorakHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.treciKorakHeader.TabIndex = 0;
            this.treciKorakHeader.TabStop = false;
            // 
            // datagridKupci
            // 
            this.datagridKupci.AllowUserToAddRows = false;
            this.datagridKupci.AllowUserToDeleteRows = false;
            this.datagridKupci.AllowUserToResizeRows = false;
            this.datagridKupci.AutoGenerateColumns = false;
            this.datagridKupci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridKupci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.datagridKupci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oIBDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.adresaDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.check});
            this.datagridKupci.DataSource = this.poslovniPartnerBindingSource;
            this.datagridKupci.Location = new System.Drawing.Point(12, 121);
            this.datagridKupci.Name = "datagridKupci";
            this.datagridKupci.ReadOnly = true;
            this.datagridKupci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridKupci.Size = new System.Drawing.Size(827, 335);
            this.datagridKupci.TabIndex = 1;
            this.datagridKupci.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridKupci_CellContentClick);
            this.datagridKupci.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.datagridKupci_CellMouseDown);
            // 
            // oIBDataGridViewTextBoxColumn
            // 
            this.oIBDataGridViewTextBoxColumn.DataPropertyName = "OIB";
            this.oIBDataGridViewTextBoxColumn.HeaderText = "OIB";
            this.oIBDataGridViewTextBoxColumn.Name = "oIBDataGridViewTextBoxColumn";
            this.oIBDataGridViewTextBoxColumn.ReadOnly = true;
            this.oIBDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "Ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            this.imeDataGridViewTextBoxColumn.ReadOnly = true;
            this.imeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            this.prezimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.prezimeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // adresaDataGridViewTextBoxColumn
            // 
            this.adresaDataGridViewTextBoxColumn.DataPropertyName = "Adresa";
            this.adresaDataGridViewTextBoxColumn.HeaderText = "Adresa";
            this.adresaDataGridViewTextBoxColumn.Name = "adresaDataGridViewTextBoxColumn";
            this.adresaDataGridViewTextBoxColumn.ReadOnly = true;
            this.adresaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            this.telefonDataGridViewTextBoxColumn.ReadOnly = true;
            this.telefonDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // check
            // 
            this.check.HeaderText = "Označi";
            this.check.Name = "check";
            this.check.ReadOnly = true;
            // 
            // poslovniPartnerBindingSource
            // 
            this.poslovniPartnerBindingSource.DataMember = "PoslovniPartner";
            this.poslovniPartnerBindingSource.DataSource = this.pi2013HajebdbDataSet;
            // 
            // pi2013HajebdbDataSet
            // 
            this.pi2013HajebdbDataSet.DataSetName = "pi2013HajebdbDataSet";
            this.pi2013HajebdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // poslovniPartnerTableAdapter
            // 
            this.poslovniPartnerTableAdapter.ClearBeforeFill = true;
            // 
            // odustaniGmb
            // 
            this.odustaniGmb.Location = new System.Drawing.Point(12, 467);
            this.odustaniGmb.Name = "odustaniGmb";
            this.odustaniGmb.Size = new System.Drawing.Size(84, 33);
            this.odustaniGmb.TabIndex = 2;
            this.odustaniGmb.Text = "Odustani";
            this.odustaniGmb.UseVisualStyleBackColor = true;
            this.odustaniGmb.Click += new System.EventHandler(this.odustaniGmb_Click);
            // 
            // daljeGmb
            // 
            this.daljeGmb.Location = new System.Drawing.Point(755, 467);
            this.daljeGmb.Name = "daljeGmb";
            this.daljeGmb.Size = new System.Drawing.Size(84, 33);
            this.daljeGmb.TabIndex = 3;
            this.daljeGmb.Text = "Dalje";
            this.daljeGmb.UseVisualStyleBackColor = true;
            this.daljeGmb.Click += new System.EventHandler(this.daljeGmb_Click);
            // 
            // nazadGmb
            // 
            this.nazadGmb.Location = new System.Drawing.Point(665, 467);
            this.nazadGmb.Name = "nazadGmb";
            this.nazadGmb.Size = new System.Drawing.Size(84, 33);
            this.nazadGmb.TabIndex = 4;
            this.nazadGmb.Text = "Nazad";
            this.nazadGmb.UseVisualStyleBackColor = true;
            this.nazadGmb.Click += new System.EventHandler(this.nazadGmb_Click);
            // 
            // frmProdajaOdabirKupca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 523);
            this.Controls.Add(this.nazadGmb);
            this.Controls.Add(this.daljeGmb);
            this.Controls.Add(this.odustaniGmb);
            this.Controls.Add(this.datagridKupci);
            this.Controls.Add(this.treciKorakHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(880, 600);
            this.MinimumSize = new System.Drawing.Size(875, 550);
            this.Name = "frmProdajaOdabirKupca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "3. korak - Odaberite kupca";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmProdajaOdabirKupca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.treciKorakHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridKupci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poslovniPartnerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pi2013HajebdbDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox treciKorakHeader;
        private System.Windows.Forms.DataGridView datagridKupci;
        private pi2013HajebdbDataSet pi2013HajebdbDataSet;
        private System.Windows.Forms.BindingSource poslovniPartnerBindingSource;
        private pi2013HajebdbDataSetTableAdapters.PoslovniPartnerTableAdapter poslovniPartnerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn oIBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn check;
        private System.Windows.Forms.Button odustaniGmb;
        private System.Windows.Forms.Button daljeGmb;
        private System.Windows.Forms.Button nazadGmb;

    }
}