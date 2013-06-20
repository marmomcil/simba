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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSifraTepiha = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCvoraza = new System.Windows.Forms.TextBox();
            this.txtSastav = new System.Windows.Forms.TextBox();
            this.btnObrisiTepih = new System.Windows.Forms.Button();
            this.txtZemljaPorijekla = new System.Windows.Forms.TextBox();
            this.btnUrediTepih = new System.Windows.Forms.Button();
            this.txtDimenzije = new System.Windows.Forms.TextBox();
            this.btnNoviTepih = new System.Windows.Forms.Button();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSpremiPromjene = new System.Windows.Forms.Button();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.txtTraziTepih = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tepihBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pi2013HajebdbDataSet1 = new simba.pi2013HajebdbDataSet1();
            this.tepihTableAdapter = new simba.pi2013HajebdbDataSet1TableAdapters.TepihTableAdapter();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.sifraTepihaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dimenzijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zemljaPorijeklaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sastavDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cvorazaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tepihBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pi2013HajebdbDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCijena);
            this.groupBox1.Controls.Add(this.txtSifraTepiha);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtCvoraza);
            this.groupBox1.Controls.Add(this.txtSastav);
            this.groupBox1.Controls.Add(this.btnObrisiTepih);
            this.groupBox1.Controls.Add(this.txtZemljaPorijekla);
            this.groupBox1.Controls.Add(this.btnUrediTepih);
            this.groupBox1.Controls.Add(this.txtDimenzije);
            this.groupBox1.Controls.Add(this.btnNoviTepih);
            this.groupBox1.Controls.Add(this.txtNaziv);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 262);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opcije uređivanja tepiha";
            // 
            // txtSifraTepiha
            // 
            this.txtSifraTepiha.Location = new System.Drawing.Point(119, 29);
            this.txtSifraTepiha.Name = "txtSifraTepiha";
            this.txtSifraTepiha.Size = new System.Drawing.Size(157, 23);
            this.txtSifraTepiha.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Cijena";
            // 
            // txtCvoraza
            // 
            this.txtCvoraza.Location = new System.Drawing.Point(119, 189);
            this.txtCvoraza.Name = "txtCvoraza";
            this.txtCvoraza.Size = new System.Drawing.Size(157, 23);
            this.txtCvoraza.TabIndex = 18;
            // 
            // txtSastav
            // 
            this.txtSastav.Location = new System.Drawing.Point(119, 158);
            this.txtSastav.Name = "txtSastav";
            this.txtSastav.Size = new System.Drawing.Size(157, 23);
            this.txtSastav.TabIndex = 17;
            // 
            // btnObrisiTepih
            // 
            this.btnObrisiTepih.BackgroundImage = global::simba.Properties.Resources.ObrisiTepih;
            this.btnObrisiTepih.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnObrisiTepih.Location = new System.Drawing.Point(366, 181);
            this.btnObrisiTepih.Name = "btnObrisiTepih";
            this.btnObrisiTepih.Size = new System.Drawing.Size(74, 62);
            this.btnObrisiTepih.TabIndex = 4;
            this.btnObrisiTepih.UseVisualStyleBackColor = true;
            // 
            // txtZemljaPorijekla
            // 
            this.txtZemljaPorijekla.Location = new System.Drawing.Point(119, 126);
            this.txtZemljaPorijekla.Name = "txtZemljaPorijekla";
            this.txtZemljaPorijekla.Size = new System.Drawing.Size(157, 23);
            this.txtZemljaPorijekla.TabIndex = 16;
            // 
            // btnUrediTepih
            // 
            this.btnUrediTepih.BackgroundImage = global::simba.Properties.Resources.Uredi;
            this.btnUrediTepih.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUrediTepih.Location = new System.Drawing.Point(366, 106);
            this.btnUrediTepih.Name = "btnUrediTepih";
            this.btnUrediTepih.Size = new System.Drawing.Size(74, 62);
            this.btnUrediTepih.TabIndex = 3;
            this.btnUrediTepih.UseVisualStyleBackColor = true;
            // 
            // txtDimenzije
            // 
            this.txtDimenzije.Location = new System.Drawing.Point(119, 93);
            this.txtDimenzije.Name = "txtDimenzije";
            this.txtDimenzije.Size = new System.Drawing.Size(157, 23);
            this.txtDimenzije.TabIndex = 15;
            // 
            // btnNoviTepih
            // 
            this.btnNoviTepih.BackgroundImage = global::simba.Properties.Resources.DodajNovi;
            this.btnNoviTepih.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNoviTepih.Location = new System.Drawing.Point(366, 29);
            this.btnNoviTepih.Name = "btnNoviTepih";
            this.btnNoviTepih.Size = new System.Drawing.Size(74, 62);
            this.btnNoviTepih.TabIndex = 2;
            this.btnNoviTepih.UseVisualStyleBackColor = true;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(119, 60);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(157, 23);
            this.txtNaziv.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Šifra tepiha";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Čvoraža";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Naziv";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Sastav";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Dimenzije";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Zemlja porijekla";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSpremiPromjene);
            this.groupBox2.Controls.Add(this.btnIzlaz);
            this.groupBox2.Location = new System.Drawing.Point(550, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(344, 119);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Globalne opcije";
            // 
            // btnSpremiPromjene
            // 
            this.btnSpremiPromjene.BackgroundImage = global::simba.Properties.Resources.SaveIcon;
            this.btnSpremiPromjene.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSpremiPromjene.Location = new System.Drawing.Point(47, 39);
            this.btnSpremiPromjene.Name = "btnSpremiPromjene";
            this.btnSpremiPromjene.Size = new System.Drawing.Size(74, 62);
            this.btnSpremiPromjene.TabIndex = 5;
            this.btnSpremiPromjene.UseVisualStyleBackColor = true;
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.BackgroundImage = global::simba.Properties.Resources.izlaz;
            this.btnIzlaz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIzlaz.Location = new System.Drawing.Point(217, 39);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(74, 62);
            this.btnIzlaz.TabIndex = 6;
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // txtTraziTepih
            // 
            this.txtTraziTepih.Location = new System.Drawing.Point(644, 193);
            this.txtTraziTepih.Name = "txtTraziTepih";
            this.txtTraziTepih.Size = new System.Drawing.Size(250, 23);
            this.txtTraziTepih.TabIndex = 17;
            this.txtTraziTepih.TextChanged += new System.EventHandler(this.txtTraziTepih_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(547, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Pretraživanje";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sifraTepihaDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.dimenzijeDataGridViewTextBoxColumn,
            this.zemljaPorijeklaDataGridViewTextBoxColumn,
            this.sastavDataGridViewTextBoxColumn,
            this.cvorazaDataGridViewTextBoxColumn,
            this.cijenaDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.tepihBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 280);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(882, 315);
            this.dataGridView2.TabIndex = 18;
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
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(119, 223);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(157, 23);
            this.txtCijena.TabIndex = 23;
            // 
            // sifraTepihaDataGridViewTextBoxColumn
            // 
            this.sifraTepihaDataGridViewTextBoxColumn.DataPropertyName = "SifraTepiha";
            this.sifraTepihaDataGridViewTextBoxColumn.HeaderText = "Sifra tepiha";
            this.sifraTepihaDataGridViewTextBoxColumn.Name = "sifraTepihaDataGridViewTextBoxColumn";
            this.sifraTepihaDataGridViewTextBoxColumn.Width = 120;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.Width = 120;
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
            this.zemljaPorijeklaDataGridViewTextBoxColumn.Width = 140;
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
            // frmPregledKataloga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 607);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.txtTraziTepih);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmPregledKataloga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregled kataloga";
            this.Load += new System.EventHandler(this.frmPregledKataloga_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tepihBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pi2013HajebdbDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCvoraza;
        private System.Windows.Forms.TextBox txtSastav;
        private System.Windows.Forms.Button btnObrisiTepih;
        private System.Windows.Forms.TextBox txtZemljaPorijekla;
        private System.Windows.Forms.Button btnUrediTepih;
        private System.Windows.Forms.TextBox txtDimenzije;
        private System.Windows.Forms.Button btnNoviTepih;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSpremiPromjene;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.TextBox txtTraziTepih;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private pi2013HajebdbDataSet1 pi2013HajebdbDataSet1;
        private System.Windows.Forms.BindingSource tepihBindingSource;
        private pi2013HajebdbDataSet1TableAdapters.TepihTableAdapter tepihTableAdapter;
        private System.Windows.Forms.TextBox txtSifraTepiha;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifraTepihaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dimenzijeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zemljaPorijeklaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sastavDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cvorazaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaDataGridViewTextBoxColumn;

    }
}