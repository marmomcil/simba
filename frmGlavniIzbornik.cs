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
    public partial class frmGlavniIzbornik : Form
    {
        public frmGlavniIzbornik()
        {
            InitializeComponent();
        }

        private void glavniIzbornik_Load(object sender, EventArgs e)
        {
            //postavljanjem kursora na gumb za pregled i uređivanje kataloga, pojavljuje se label sa istoimenom informacijom
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btnKatalog, "Pregled i uređivanje kataloga");

            //postavljanjem kursora na gumb za pregled i uređivanje kupaca, pojavljuje se label sa istoimenom informacijom
            System.Windows.Forms.ToolTip ToolTip2 = new System.Windows.Forms.ToolTip();
            ToolTip2.SetToolTip(this.btnKupci, "Pregled i uređivanje kupaca");

            //postavljanjem kursora na gumb za prodaju i naplatu proizvoda, pojavljuje se label sa istoimenom informacijom
            System.Windows.Forms.ToolTip ToolTip3 = new System.Windows.Forms.ToolTip();
            ToolTip3.SetToolTip(this.btnProdaja, "Prodaja i naplata proizvoda");

            //postavljanjem kursora na gumb za izlaz iz aplikacije, pojavljuje se label sa istoimenom informacijom
            System.Windows.Forms.ToolTip ToolTip4 = new System.Windows.Forms.ToolTip();
            ToolTip4.SetToolTip(this.btnIzlaz, "Izlaz iz aplikacije");

            this.toolStripStatusLabel1.Text = System.DateTime.Today.ToLongDateString();
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Da li ste sigurni da želite izaći iz aplikacije?", "IZLAZ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            Application.Exit();
        }

        private void btnKatalog_Click(object sender, EventArgs e)
        {
            frmPregledKataloga Katalog = new frmPregledKataloga();
            Katalog.ShowDialog(this);
        }

        private void btnKupci_Click(object sender, EventArgs e)
        {
            frmPregledKupaca Kupci = new frmPregledKupaca();
            Kupci.ShowDialog(this);
        }

        private void btnProdaja_Click(object sender, EventArgs e)
        {
            frmProdajaTepiha Prodaja = new frmProdajaTepiha();
            Prodaja.ShowDialog(this);
        }
    }
}
