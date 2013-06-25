namespace simba
{
    partial class frmPregledKupaca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPregledKupaca));
            this.label1 = new System.Windows.Forms.Label();
            this.txtTraziKupca = new System.Windows.Forms.TextBox();
            this.dgvPregledKupaca = new System.Windows.Forms.DataGridView();
            this.oIBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poslovniPartnerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pi2013HajebdbDataSet = new simba.pi2013HajebdbDataSet();
            this.poslovniPartnerTableAdapter = new simba.pi2013HajebdbDataSetTableAdapters.PoslovniPartnerTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.btnSpremiPromjene = new System.Windows.Forms.Button();
            this.btnDodajKupca = new System.Windows.Forms.Button();
            this.btnAzurirajKupca = new System.Windows.Forms.Button();
            this.btnIzbrisiKupca = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregledKupaca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poslovniPartnerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pi2013HajebdbDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(573, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pretraživanje";
            // 
            // txtTraziKupca
            // 
            this.txtTraziKupca.Location = new System.Drawing.Point(576, 83);
            this.txtTraziKupca.Name = "txtTraziKupca";
            this.txtTraziKupca.Size = new System.Drawing.Size(298, 23);
            this.txtTraziKupca.TabIndex = 3;
            this.txtTraziKupca.TextChanged += new System.EventHandler(this.txtTraziKupca_TextChanged);
            // 
            // dgvPregledKupaca
            // 
            this.dgvPregledKupaca.AutoGenerateColumns = false;
            this.dgvPregledKupaca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPregledKupaca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPregledKupaca.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oIBDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.adresaDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dgvPregledKupaca.DataSource = this.poslovniPartnerBindingSource;
            this.dgvPregledKupaca.Location = new System.Drawing.Point(12, 163);
            this.dgvPregledKupaca.MaximumSize = new System.Drawing.Size(866, 256);
            this.dgvPregledKupaca.MinimumSize = new System.Drawing.Size(866, 256);
            this.dgvPregledKupaca.Name = "dgvPregledKupaca";
            this.dgvPregledKupaca.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvPregledKupaca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPregledKupaca.Size = new System.Drawing.Size(866, 256);
            this.dgvPregledKupaca.TabIndex = 6;
            // 
            // oIBDataGridViewTextBoxColumn
            // 
            this.oIBDataGridViewTextBoxColumn.DataPropertyName = "OIB";
            this.oIBDataGridViewTextBoxColumn.HeaderText = "OIB";
            this.oIBDataGridViewTextBoxColumn.Name = "oIBDataGridViewTextBoxColumn";
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "Ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            // 
            // adresaDataGridViewTextBoxColumn
            // 
            this.adresaDataGridViewTextBoxColumn.DataPropertyName = "Adresa";
            this.adresaDataGridViewTextBoxColumn.HeaderText = "Adresa";
            this.adresaDataGridViewTextBoxColumn.Name = "adresaDataGridViewTextBoxColumn";
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIzlaz);
            this.groupBox1.Controls.Add(this.btnSpremiPromjene);
            this.groupBox1.Controls.Add(this.btnDodajKupca);
            this.groupBox1.Controls.Add(this.btnAzurirajKupca);
            this.groupBox1.Controls.Add(this.btnIzbrisiKupca);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 145);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opcije";
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.BackgroundImage = global::simba.Properties.Resources.izlaz;
            this.btnIzlaz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIzlaz.Location = new System.Drawing.Point(425, 51);
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
            this.btnSpremiPromjene.Location = new System.Drawing.Point(327, 51);
            this.btnSpremiPromjene.Name = "btnSpremiPromjene";
            this.btnSpremiPromjene.Size = new System.Drawing.Size(74, 62);
            this.btnSpremiPromjene.TabIndex = 5;
            this.btnSpremiPromjene.UseVisualStyleBackColor = true;
            this.btnSpremiPromjene.Click += new System.EventHandler(this.btnSpremiPromjene_Click);
            // 
            // btnDodajKupca
            // 
            this.btnDodajKupca.BackgroundImage = global::simba.Properties.Resources.DodajNovi;
            this.btnDodajKupca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDodajKupca.Location = new System.Drawing.Point(21, 51);
            this.btnDodajKupca.Name = "btnDodajKupca";
            this.btnDodajKupca.Size = new System.Drawing.Size(74, 62);
            this.btnDodajKupca.TabIndex = 2;
            this.btnDodajKupca.UseVisualStyleBackColor = true;
            this.btnDodajKupca.Click += new System.EventHandler(this.btnDodajKupca_Click);
            // 
            // btnAzurirajKupca
            // 
            this.btnAzurirajKupca.BackgroundImage = global::simba.Properties.Resources.Uredi;
            this.btnAzurirajKupca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAzurirajKupca.Location = new System.Drawing.Point(124, 51);
            this.btnAzurirajKupca.Name = "btnAzurirajKupca";
            this.btnAzurirajKupca.Size = new System.Drawing.Size(74, 62);
            this.btnAzurirajKupca.TabIndex = 3;
            this.btnAzurirajKupca.UseVisualStyleBackColor = true;
            this.btnAzurirajKupca.Click += new System.EventHandler(this.btnAzurirajKupca_Click);
            // 
            // btnIzbrisiKupca
            // 
            this.btnIzbrisiKupca.BackgroundImage = global::simba.Properties.Resources.ObrisiTepih;
            this.btnIzbrisiKupca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIzbrisiKupca.Location = new System.Drawing.Point(227, 51);
            this.btnIzbrisiKupca.Name = "btnIzbrisiKupca";
            this.btnIzbrisiKupca.Size = new System.Drawing.Size(74, 62);
            this.btnIzbrisiKupca.TabIndex = 4;
            this.btnIzbrisiKupca.UseVisualStyleBackColor = true;
            this.btnIzbrisiKupca.Click += new System.EventHandler(this.btnIzbrisiKupca_Click);
            // 
            // frmPregledKupaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 437);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvPregledKupaca);
            this.Controls.Add(this.txtTraziKupca);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPregledKupaca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPregledKupaca";
            this.Load += new System.EventHandler(this.frmPregledKupaca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregledKupaca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poslovniPartnerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pi2013HajebdbDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTraziKupca;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.Button btnSpremiPromjene;
        private System.Windows.Forms.Button btnIzbrisiKupca;
        private System.Windows.Forms.Button btnAzurirajKupca;
        private System.Windows.Forms.Button btnDodajKupca;
        private System.Windows.Forms.DataGridView dgvPregledKupaca;
        private pi2013HajebdbDataSet pi2013HajebdbDataSet;
        private System.Windows.Forms.BindingSource poslovniPartnerBindingSource;
        private pi2013HajebdbDataSetTableAdapters.PoslovniPartnerTableAdapter poslovniPartnerTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn oIBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;

    }
}