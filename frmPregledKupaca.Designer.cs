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
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.btnSpremiPromjene = new System.Windows.Forms.Button();
            this.btnObrisiKupca = new System.Windows.Forms.Button();
            this.btnUrediKupca = new System.Windows.Forms.Button();
            this.btnNoviKupac = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chkbox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.oIBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poslovniPartnerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pi2013HajebdbDataSet = new simba.pi2013HajebdbDataSet();
            this.poslovniPartnerTableAdapter = new simba.pi2013HajebdbDataSetTableAdapters.PoslovniPartnerTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.mtxtOIB = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poslovniPartnerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pi2013HajebdbDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(528, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pretraživanje";
            // 
            // txtTraziKupca
            // 
            this.txtTraziKupca.Location = new System.Drawing.Point(625, 183);
            this.txtTraziKupca.Name = "txtTraziKupca";
            this.txtTraziKupca.Size = new System.Drawing.Size(250, 23);
            this.txtTraziKupca.TabIndex = 3;
            this.txtTraziKupca.TextChanged += new System.EventHandler(this.txtTraziKupca_TextChanged);
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
            // btnSpremiPromjene
            // 
            this.btnSpremiPromjene.BackgroundImage = global::simba.Properties.Resources.SaveIcon;
            this.btnSpremiPromjene.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSpremiPromjene.Location = new System.Drawing.Point(47, 39);
            this.btnSpremiPromjene.Name = "btnSpremiPromjene";
            this.btnSpremiPromjene.Size = new System.Drawing.Size(74, 62);
            this.btnSpremiPromjene.TabIndex = 5;
            this.btnSpremiPromjene.UseVisualStyleBackColor = true;
            this.btnSpremiPromjene.Click += new System.EventHandler(this.btnSpremiPromjene_Click);
            // 
            // btnObrisiKupca
            // 
            this.btnObrisiKupca.BackgroundImage = global::simba.Properties.Resources.ObrisiTepih;
            this.btnObrisiKupca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnObrisiKupca.Location = new System.Drawing.Point(366, 161);
            this.btnObrisiKupca.Name = "btnObrisiKupca";
            this.btnObrisiKupca.Size = new System.Drawing.Size(74, 62);
            this.btnObrisiKupca.TabIndex = 4;
            this.btnObrisiKupca.UseVisualStyleBackColor = true;
            // 
            // btnUrediKupca
            // 
            this.btnUrediKupca.BackgroundImage = global::simba.Properties.Resources.Uredi;
            this.btnUrediKupca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUrediKupca.Location = new System.Drawing.Point(366, 93);
            this.btnUrediKupca.Name = "btnUrediKupca";
            this.btnUrediKupca.Size = new System.Drawing.Size(74, 62);
            this.btnUrediKupca.TabIndex = 3;
            this.btnUrediKupca.UseVisualStyleBackColor = true;
            // 
            // btnNoviKupac
            // 
            this.btnNoviKupac.BackgroundImage = global::simba.Properties.Resources.DodajNovi;
            this.btnNoviKupac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNoviKupac.Location = new System.Drawing.Point(366, 25);
            this.btnNoviKupac.Name = "btnNoviKupac";
            this.btnNoviKupac.Size = new System.Drawing.Size(74, 62);
            this.btnNoviKupac.TabIndex = 2;
            this.btnNoviKupac.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chkbox,
            this.oIBDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.adresaDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.poslovniPartnerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(11, 262);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(894, 275);
            this.dataGridView1.TabIndex = 6;
            // 
            // chkbox
            // 
            this.chkbox.HeaderText = "";
            this.chkbox.Name = "chkbox";
            this.chkbox.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.chkbox.Width = 30;
            // 
            // oIBDataGridViewTextBoxColumn
            // 
            this.oIBDataGridViewTextBoxColumn.DataPropertyName = "OIB";
            this.oIBDataGridViewTextBoxColumn.HeaderText = "OIB";
            this.oIBDataGridViewTextBoxColumn.Name = "oIBDataGridViewTextBoxColumn";
            this.oIBDataGridViewTextBoxColumn.Width = 120;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "Ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            this.imeDataGridViewTextBoxColumn.Width = 110;
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            this.prezimeDataGridViewTextBoxColumn.Width = 110;
            // 
            // adresaDataGridViewTextBoxColumn
            // 
            this.adresaDataGridViewTextBoxColumn.DataPropertyName = "Adresa";
            this.adresaDataGridViewTextBoxColumn.HeaderText = "Adresa";
            this.adresaDataGridViewTextBoxColumn.Name = "adresaDataGridViewTextBoxColumn";
            this.adresaDataGridViewTextBoxColumn.Width = 250;
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
            this.emailDataGridViewTextBoxColumn.Width = 130;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "OIB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ime";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Prezime";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Adresa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Telefon";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Email";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mtxtOIB);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtTelefon);
            this.groupBox1.Controls.Add(this.btnObrisiKupca);
            this.groupBox1.Controls.Add(this.txtAdresa);
            this.groupBox1.Controls.Add(this.btnUrediKupca);
            this.groupBox1.Controls.Add(this.txtPrezime);
            this.groupBox1.Controls.Add(this.btnNoviKupac);
            this.groupBox1.Controls.Add(this.txtIme);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 244);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opcije uređivanja kupaca";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(78, 189);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(237, 23);
            this.txtEmail.TabIndex = 18;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(78, 158);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(133, 23);
            this.txtTelefon.TabIndex = 17;
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(78, 126);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(237, 23);
            this.txtAdresa.TabIndex = 16;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(78, 93);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(157, 23);
            this.txtPrezime.TabIndex = 15;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(78, 60);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(157, 23);
            this.txtIme.TabIndex = 14;
            // 
            // mtxtOIB
            // 
            this.mtxtOIB.Location = new System.Drawing.Point(78, 29);
            this.mtxtOIB.Mask = "00000000000";
            this.mtxtOIB.Name = "mtxtOIB";
            this.mtxtOIB.Size = new System.Drawing.Size(133, 23);
            this.mtxtOIB.TabIndex = 19;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSpremiPromjene);
            this.groupBox2.Controls.Add(this.btnIzlaz);
            this.groupBox2.Location = new System.Drawing.Point(531, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(344, 119);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Globalne opcije";
            // 
            // frmPregledKupaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 549);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtTraziKupca);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPregledKupaca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPregledKupaca";
            this.Load += new System.EventHandler(this.frmPregledKupaca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poslovniPartnerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pi2013HajebdbDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTraziKupca;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.Button btnSpremiPromjene;
        private System.Windows.Forms.Button btnObrisiKupca;
        private System.Windows.Forms.Button btnUrediKupca;
        private System.Windows.Forms.Button btnNoviKupac;
        private System.Windows.Forms.DataGridView dataGridView1;
        private pi2013HajebdbDataSet pi2013HajebdbDataSet;
        private System.Windows.Forms.BindingSource poslovniPartnerBindingSource;
        private pi2013HajebdbDataSetTableAdapters.PoslovniPartnerTableAdapter poslovniPartnerTableAdapter;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn oIBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.MaskedTextBox mtxtOIB;
        private System.Windows.Forms.GroupBox groupBox2;

    }
}