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
    public partial class frmPregledKataloga : Form
    {
        public frmPregledKataloga()
        {
            InitializeComponent();
        }
              

        private void frmPregledKataloga_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pi2013HajebdbDataSet1.Tepih' table. You can move, or remove it, as needed.
            this.tepihTableAdapter.Fill(this.pi2013HajebdbDataSet1.Tepih);
                       
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btnNoviTepih, "Dodaj novi tepih");

            System.Windows.Forms.ToolTip ToolTip2 = new System.Windows.Forms.ToolTip();
            ToolTip2.SetToolTip(this.btnUrediTepih, "Uredi postojeći tepih");

            System.Windows.Forms.ToolTip ToolTip3 = new System.Windows.Forms.ToolTip();
            ToolTip3.SetToolTip(this.btnObrisiTepih, "Obriši postojeći tepih");

            System.Windows.Forms.ToolTip ToolTip4 = new System.Windows.Forms.ToolTip();
            ToolTip4.SetToolTip(this.btnSpremiPromjene, "Spremi promjene");

            System.Windows.Forms.ToolTip ToolTip5 = new System.Windows.Forms.ToolTip();
            ToolTip5.SetToolTip(this.btnIzlaz, "Zatvori Pregled kataloga");
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTraziTepih_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs1 = new BindingSource();
            bs1.DataSource = dataGridView2.DataSource;
            bs1.Filter = " Convert(SifraTepiha, 'System.String') LIKE '%" + txtTraziTepih.Text + "%' OR Convert(Naziv, 'System.String') LIKE '%" + txtTraziTepih.Text + "%' OR Convert(Dimenzije, 'System.String') LIKE '%" + txtTraziTepih.Text + "%' OR Convert(ZemljaPorijekla, 'System.String') LIKE '%" + txtTraziTepih.Text + "%' OR Convert(Sastav, 'System.String') LIKE '%" + txtTraziTepih.Text + "%' OR Convert(Cvoraza, 'System.String') LIKE '%" + txtTraziTepih.Text + "%' OR Convert(Cijena, 'System.String') LIKE '%" + txtTraziTepih.Text + "%' ";
            dataGridView2.DataSource = bs1;
        }
    }
}
