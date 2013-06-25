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
    public partial class frmProdajaTepiha : Form
    {
        public frmProdajaTepiha()
        {
            InitializeComponent();
        }

        private void odustaniGmb_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void daljeGmb_Click(object sender, EventArgs e)
        {
            //pošalji referencu forme roditelja (prvi korak wizarda) formi djetetu (drugi korak wizarda) kako bi na gumb odustani mogao sve forme pogasiti(odnosno ugasiti cijeli wizard)
            frmProdajaOdabirTepiha prodajaOdabirTepiha = new frmProdajaOdabirTepiha(this);

            this.Hide();
            prodajaOdabirTepiha.ShowDialog();
            this.Show();
        }
    }
}
