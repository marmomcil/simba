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
    public partial class frmPrijava : Form
    {
        public int selected;
        public frmPrijava()
        {
            InitializeComponent();
        }

        private void btnPotvrda_Click(object sender, EventArgs e)
        {
            bool loginSuccesful = false;
                if ((selected == 0) && (txtLozinka.Text == "bhajeb"))
                {
                    loginSuccesful = true;
                }

                if ((selected == 1) && (txtLozinka.Text == "mdeskar"))
                {
                    loginSuccesful = true;
                }

                if ((selected == 2) && (txtLozinka.Text == "gbartosek"))
                {
                    loginSuccesful = true;
                }

                if ((selected == 3) && (txtLozinka.Text == "mmomcilovic"))
                {
                    loginSuccesful = true;
                }

                if ((selected == 4) && (txtLozinka.Text == "tcundic"))
                {
                    loginSuccesful = true;
                }

                else if ((txtKorisnickoIme.SelectedIndex == -1) || (txtLozinka.Text == string.Empty))
                {
                    MessageBox.Show("Niste upisali korisničko ime ili lozinku! \r\nMolimo pokušajte ponovno!", "GREŠKA!", MessageBoxButtons.OK);
                }

                else if (loginSuccesful == false)
                {
                    MessageBox.Show("Pogrešno korisničko ime ili lozinka! \r\nMolimo pokušajte ponovno!", "GREŠKA!", MessageBoxButtons.OK);
                }

            if (loginSuccesful == true)
            {
                frmDobrodosli welcome = new frmDobrodosli();
                this.Hide();
                welcome.Show();
            }
            
        }

        private void txtKorisnickoIme_SelectedValueChanged(object sender, EventArgs e)
        {
            selected = txtKorisnickoIme.SelectedIndex;
        }

        private void txtLozinka_TextChanged(object sender, EventArgs e)
        {
            txtLozinka.PasswordChar = '*';
        }

        private void txtLozinka_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Da li ste sigurni da želite izaći iz aplikacije?", "Izlaz iz aplikacije", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                // korisnik je kliknuo "NE"
            }
        }

        private void frmPrijava_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip5 = new System.Windows.Forms.ToolTip();
            ToolTip5.SetToolTip(this.btnPrijava, "Logiranje u aplikaciju");

            System.Windows.Forms.ToolTip ToolTip6 = new System.Windows.Forms.ToolTip();
            ToolTip6.SetToolTip(this.btnIzlaz, "Izlaz iz aplikacije");

            this.AcceptButton = btnPrijava;
        }
    }
}
