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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTraziKupca = new System.Windows.Forms.TextBox();
            this.btnTraziKupca = new System.Windows.Forms.Button();
            this.grpBoxOpcije = new System.Windows.Forms.GroupBox();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.btnSpremiPromjene = new System.Windows.Forms.Button();
            this.btnObrisiKupca = new System.Windows.Forms.Button();
            this.btnUrediKupca = new System.Windows.Forms.Button();
            this.btnNoviKupac = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pi2013HajebdbDataSet = new simba.pi2013HajebdbDataSet();
            this.pi2013HajebdbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pi2013HajebdbDataSet1 = new simba.pi2013HajebdbDataSet1();
            this.kupacBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kupacTableAdapter = new simba.pi2013HajebdbDataSet1TableAdapters.KupacTableAdapter();
            this.oIBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpBoxOpcije.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pi2013HajebdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pi2013HajebdbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pi2013HajebdbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kupacBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pretraživanje";
            // 
            // txtTraziKupca
            // 
            this.txtTraziKupca.Location = new System.Drawing.Point(109, 19);
            this.txtTraziKupca.Name = "txtTraziKupca";
            this.txtTraziKupca.Size = new System.Drawing.Size(250, 23);
            this.txtTraziKupca.TabIndex = 3;
            // 
            // btnTraziKupca
            // 
            this.btnTraziKupca.BackgroundImage = global::simba.Properties.Resources.libros;
            this.btnTraziKupca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTraziKupca.Location = new System.Drawing.Point(135, 48);
            this.btnTraziKupca.Name = "btnTraziKupca";
            this.btnTraziKupca.Size = new System.Drawing.Size(86, 69);
            this.btnTraziKupca.TabIndex = 4;
            this.btnTraziKupca.UseVisualStyleBackColor = true;
            // 
            // grpBoxOpcije
            // 
            this.grpBoxOpcije.Controls.Add(this.btnIzlaz);
            this.grpBoxOpcije.Controls.Add(this.btnSpremiPromjene);
            this.grpBoxOpcije.Controls.Add(this.btnObrisiKupca);
            this.grpBoxOpcije.Controls.Add(this.btnUrediKupca);
            this.grpBoxOpcije.Controls.Add(this.btnNoviKupac);
            this.grpBoxOpcije.Location = new System.Drawing.Point(365, 12);
            this.grpBoxOpcije.Name = "grpBoxOpcije";
            this.grpBoxOpcije.Size = new System.Drawing.Size(526, 110);
            this.grpBoxOpcije.TabIndex = 5;
            this.grpBoxOpcije.TabStop = false;
            this.grpBoxOpcije.Text = "Opcije";
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.BackgroundImage = global::simba.Properties.Resources.izlaz;
            this.btnIzlaz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIzlaz.Location = new System.Drawing.Point(414, 22);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(96, 82);
            this.btnIzlaz.TabIndex = 6;
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // btnSpremiPromjene
            // 
            this.btnSpremiPromjene.BackgroundImage = global::simba.Properties.Resources.SaveIcon;
            this.btnSpremiPromjene.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSpremiPromjene.Location = new System.Drawing.Point(312, 22);
            this.btnSpremiPromjene.Name = "btnSpremiPromjene";
            this.btnSpremiPromjene.Size = new System.Drawing.Size(96, 82);
            this.btnSpremiPromjene.TabIndex = 5;
            this.btnSpremiPromjene.UseVisualStyleBackColor = true;
            // 
            // btnObrisiKupca
            // 
            this.btnObrisiKupca.BackgroundImage = global::simba.Properties.Resources.ObrisiTepih;
            this.btnObrisiKupca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnObrisiKupca.Location = new System.Drawing.Point(210, 22);
            this.btnObrisiKupca.Name = "btnObrisiKupca";
            this.btnObrisiKupca.Size = new System.Drawing.Size(96, 82);
            this.btnObrisiKupca.TabIndex = 4;
            this.btnObrisiKupca.UseVisualStyleBackColor = true;
            // 
            // btnUrediKupca
            // 
            this.btnUrediKupca.BackgroundImage = global::simba.Properties.Resources.Uredi;
            this.btnUrediKupca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUrediKupca.Location = new System.Drawing.Point(108, 22);
            this.btnUrediKupca.Name = "btnUrediKupca";
            this.btnUrediKupca.Size = new System.Drawing.Size(96, 82);
            this.btnUrediKupca.TabIndex = 3;
            this.btnUrediKupca.UseVisualStyleBackColor = true;
            // 
            // btnNoviKupac
            // 
            this.btnNoviKupac.BackgroundImage = global::simba.Properties.Resources.DodajNovi;
            this.btnNoviKupac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNoviKupac.Location = new System.Drawing.Point(6, 22);
            this.btnNoviKupac.Name = "btnNoviKupac";
            this.btnNoviKupac.Size = new System.Drawing.Size(96, 82);
            this.btnNoviKupac.TabIndex = 2;
            this.btnNoviKupac.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oIBDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.adresaDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kupacBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(880, 306);
            this.dataGridView1.TabIndex = 6;
            // 
            // pi2013HajebdbDataSet
            // 
            this.pi2013HajebdbDataSet.DataSetName = "pi2013HajebdbDataSet";
            this.pi2013HajebdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pi2013HajebdbDataSetBindingSource
            // 
            this.pi2013HajebdbDataSetBindingSource.DataSource = this.pi2013HajebdbDataSet;
            this.pi2013HajebdbDataSetBindingSource.Position = 0;
            // 
            // pi2013HajebdbDataSet1
            // 
            this.pi2013HajebdbDataSet1.DataSetName = "pi2013HajebdbDataSet1";
            this.pi2013HajebdbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kupacBindingSource
            // 
            this.kupacBindingSource.DataMember = "Kupac";
            this.kupacBindingSource.DataSource = this.pi2013HajebdbDataSet1;
            // 
            // kupacTableAdapter
            // 
            this.kupacTableAdapter.ClearBeforeFill = true;
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
            // frmPregledKupaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grpBoxOpcije);
            this.Controls.Add(this.btnTraziKupca);
            this.Controls.Add(this.txtTraziKupca);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPregledKupaca";
            this.Text = "frmPregledKupaca";
            this.Load += new System.EventHandler(this.frmPregledKupaca_Load);
            this.grpBoxOpcije.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pi2013HajebdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pi2013HajebdbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pi2013HajebdbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kupacBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTraziKupca;
        private System.Windows.Forms.Button btnTraziKupca;
        private System.Windows.Forms.GroupBox grpBoxOpcije;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.Button btnSpremiPromjene;
        private System.Windows.Forms.Button btnObrisiKupca;
        private System.Windows.Forms.Button btnUrediKupca;
        private System.Windows.Forms.Button btnNoviKupac;
        private System.Windows.Forms.DataGridView dataGridView1;
        private pi2013HajebdbDataSet pi2013HajebdbDataSet;
        private System.Windows.Forms.BindingSource pi2013HajebdbDataSetBindingSource;
        private pi2013HajebdbDataSet1 pi2013HajebdbDataSet1;
        private System.Windows.Forms.BindingSource kupacBindingSource;
        private pi2013HajebdbDataSet1TableAdapters.KupacTableAdapter kupacTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn oIBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;

    }
}