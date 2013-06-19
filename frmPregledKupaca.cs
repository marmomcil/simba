using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace simba
{
    public partial class frmPregledKupaca : Form
    {
        public frmPregledKupaca()
        {
            InitializeComponent();
        }

        
        private void frmPregledKupaca_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pi2013HajebdbDataSet.PoslovniPartner' table. You can move, or remove it, as needed.
            this.poslovniPartnerTableAdapter.Fill(this.pi2013HajebdbDataSet.PoslovniPartner);

            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btnNoviKupac, "Dodaj novog kupca");

            System.Windows.Forms.ToolTip ToolTip2 = new System.Windows.Forms.ToolTip();
            ToolTip2.SetToolTip(this.btnUrediKupca, "Uredi postojećeg kupca");

            System.Windows.Forms.ToolTip ToolTip3 = new System.Windows.Forms.ToolTip();
            ToolTip3.SetToolTip(this.btnObrisiKupca, "Obriši postojećeg kupca");

            System.Windows.Forms.ToolTip ToolTip4 = new System.Windows.Forms.ToolTip();
            ToolTip4.SetToolTip(this.btnSpremiPromjene, "Spremi promjene");

            System.Windows.Forms.ToolTip ToolTip5 = new System.Windows.Forms.ToolTip();
            ToolTip5.SetToolTip(this.btnIzlaz, "Zatvori Pregled kupaca");

            
        }

        private void txtTraziKupca_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            //bs.Filter = "Ime like '%" + txtTraziKupca.Text + "%'";
            bs.Filter = " OIB LIKE '%" + txtTraziKupca.Text + "%' OR Ime LIKE '%" + txtTraziKupca.Text + "%' OR Prezime LIKE '%" + txtTraziKupca.Text + "%' OR Adresa LIKE '%" + txtTraziKupca.Text + "%' OR Telefon LIKE '%" + txtTraziKupca.Text + "%' OR Email LIKE '%" + txtTraziKupca.Text + "%' ";
            dataGridView1.DataSource = bs;
        }

        private void btnSpremiPromjene_Click(object sender, EventArgs e)
        {

        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
