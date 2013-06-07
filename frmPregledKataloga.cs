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
            // TODO: This line of code loads data into the 'pi2013HajebdbDataSet.Tepih' table. You can move, or remove it, as needed.
            this.tepihTableAdapter.Fill(this.pi2013HajebdbDataSet.Tepih);

            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btnNovi, "Dodaj novi tepih");

            System.Windows.Forms.ToolTip ToolTip2 = new System.Windows.Forms.ToolTip();
            ToolTip2.SetToolTip(this.btnUredi, "Uredi postojeći tepih");

            System.Windows.Forms.ToolTip ToolTip3 = new System.Windows.Forms.ToolTip();
            ToolTip3.SetToolTip(this.btnObrisi, "Obriši postojeći tepih");

            System.Windows.Forms.ToolTip ToolTip4 = new System.Windows.Forms.ToolTip();
            ToolTip4.SetToolTip(this.btnSpremi, "Spremi promjene");

            System.Windows.Forms.ToolTip ToolTip5 = new System.Windows.Forms.ToolTip();
            ToolTip5.SetToolTip(this.btnIzlaz, "Zatvori Pregled kataloga");
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
