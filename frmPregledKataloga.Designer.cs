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
            this.grpBoxFilter = new System.Windows.Forms.GroupBox();
            this.txtSifraTepiha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNazivTepiha = new System.Windows.Forms.TextBox();
            this.grpBoxOpcije = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pi2013HajebdbDataSet = new simba.pi2013HajebdbDataSet();
            this.tepihBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tepihTableAdapter = new simba.pi2013HajebdbDataSetTableAdapters.TepihTableAdapter();
            this.sifraTepihaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dimenzijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zemljaPorijeklaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sastavDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cvorazaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnUredi = new System.Windows.Forms.Button();
            this.btnNovi = new System.Windows.Forms.Button();
            this.grpBoxFilter.SuspendLayout();
            this.grpBoxOpcije.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pi2013HajebdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tepihBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBoxFilter
            // 
            this.grpBoxFilter.Controls.Add(this.txtNazivTepiha);
            this.grpBoxFilter.Controls.Add(this.label2);
            this.grpBoxFilter.Controls.Add(this.label1);
            this.grpBoxFilter.Controls.Add(this.txtSifraTepiha);
            this.grpBoxFilter.Location = new System.Drawing.Point(12, 12);
            this.grpBoxFilter.Name = "grpBoxFilter";
            this.grpBoxFilter.Size = new System.Drawing.Size(364, 110);
            this.grpBoxFilter.TabIndex = 0;
            this.grpBoxFilter.TabStop = false;
            this.grpBoxFilter.Text = "Filtriranje";
            // 
            // txtSifraTepiha
            // 
            this.txtSifraTepiha.Location = new System.Drawing.Point(102, 22);
            this.txtSifraTepiha.Name = "txtSifraTepiha";
            this.txtSifraTepiha.Size = new System.Drawing.Size(218, 23);
            this.txtSifraTepiha.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Šifra tepiha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Naziv tepiha";
            // 
            // txtNazivTepiha
            // 
            this.txtNazivTepiha.Location = new System.Drawing.Point(102, 64);
            this.txtNazivTepiha.Name = "txtNazivTepiha";
            this.txtNazivTepiha.Size = new System.Drawing.Size(218, 23);
            this.txtNazivTepiha.TabIndex = 3;
            // 
            // grpBoxOpcije
            // 
            this.grpBoxOpcije.Controls.Add(this.btnIzlaz);
            this.grpBoxOpcije.Controls.Add(this.btnSpremi);
            this.grpBoxOpcije.Controls.Add(this.btnObrisi);
            this.grpBoxOpcije.Controls.Add(this.btnUredi);
            this.grpBoxOpcije.Controls.Add(this.btnNovi);
            this.grpBoxOpcije.Location = new System.Drawing.Point(382, 12);
            this.grpBoxOpcije.Name = "grpBoxOpcije";
            this.grpBoxOpcije.Size = new System.Drawing.Size(526, 110);
            this.grpBoxOpcije.TabIndex = 1;
            this.grpBoxOpcije.TabStop = false;
            this.grpBoxOpcije.Text = "Opcije";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sifraTepihaDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.dimenzijeDataGridViewTextBoxColumn,
            this.zemljaPorijeklaDataGridViewTextBoxColumn,
            this.sastavDataGridViewTextBoxColumn,
            this.cvorazaDataGridViewTextBoxColumn,
            this.cijenaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tepihBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(896, 396);
            this.dataGridView1.TabIndex = 2;
            // 
            // pi2013HajebdbDataSet
            // 
            this.pi2013HajebdbDataSet.DataSetName = "pi2013HajebdbDataSet";
            this.pi2013HajebdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tepihBindingSource
            // 
            this.tepihBindingSource.DataMember = "Tepih";
            this.tepihBindingSource.DataSource = this.pi2013HajebdbDataSet;
            // 
            // tepihTableAdapter
            // 
            this.tepihTableAdapter.ClearBeforeFill = true;
            // 
            // sifraTepihaDataGridViewTextBoxColumn
            // 
            this.sifraTepihaDataGridViewTextBoxColumn.DataPropertyName = "SifraTepiha";
            this.sifraTepihaDataGridViewTextBoxColumn.HeaderText = "SifraTepiha";
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
            this.zemljaPorijeklaDataGridViewTextBoxColumn.HeaderText = "ZemljaPorijekla";
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
            // btnSpremi
            // 
            this.btnSpremi.BackgroundImage = global::simba.Properties.Resources.SaveIcon;
            this.btnSpremi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSpremi.Location = new System.Drawing.Point(312, 22);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(96, 82);
            this.btnSpremi.TabIndex = 5;
            this.btnSpremi.UseVisualStyleBackColor = true;
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackgroundImage = global::simba.Properties.Resources.ObrisiTepih;
            this.btnObrisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnObrisi.Location = new System.Drawing.Point(210, 22);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(96, 82);
            this.btnObrisi.TabIndex = 4;
            this.btnObrisi.UseVisualStyleBackColor = true;
            // 
            // btnUredi
            // 
            this.btnUredi.BackgroundImage = global::simba.Properties.Resources.Uredi;
            this.btnUredi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUredi.Location = new System.Drawing.Point(108, 22);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(96, 82);
            this.btnUredi.TabIndex = 3;
            this.btnUredi.UseVisualStyleBackColor = true;
            // 
            // btnNovi
            // 
            this.btnNovi.BackgroundImage = global::simba.Properties.Resources.DodajNovi;
            this.btnNovi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNovi.Location = new System.Drawing.Point(6, 22);
            this.btnNovi.Name = "btnNovi";
            this.btnNovi.Size = new System.Drawing.Size(96, 82);
            this.btnNovi.TabIndex = 2;
            this.btnNovi.UseVisualStyleBackColor = true;
            // 
            // frmPregledKataloga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 546);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grpBoxOpcije);
            this.Controls.Add(this.grpBoxFilter);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmPregledKataloga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregled kataloga";
            this.Load += new System.EventHandler(this.frmPregledKataloga_Load);
            this.grpBoxFilter.ResumeLayout(false);
            this.grpBoxFilter.PerformLayout();
            this.grpBoxOpcije.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pi2013HajebdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tepihBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSifraTepiha;
        private System.Windows.Forms.TextBox txtNazivTepiha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpBoxOpcije;
        private System.Windows.Forms.Button btnNovi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private pi2013HajebdbDataSet pi2013HajebdbDataSet;
        private System.Windows.Forms.BindingSource tepihBindingSource;
        private pi2013HajebdbDataSetTableAdapters.TepihTableAdapter tepihTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifraTepihaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dimenzijeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zemljaPorijeklaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sastavDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cvorazaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnUredi;
    }
}