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
    public partial class frmProdajaOdabirKupca : Form
    {
        public frmProdajaOdabirKupca(frmProdajaOdabirTepiha parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        public static List<DataGridViewRow> kupci = new List<DataGridViewRow>();
        public List<DataGridViewRow> tepisi = new List<DataGridViewRow>();
        private int selectedRowIndex;

        frmProdajaOdabirTepiha parentForm;

        private void frmProdajaOdabirKupca_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pi2013HajebdbDataSet.PoslovniPartner' table. You can move, or remove it, as needed.
            this.poslovniPartnerTableAdapter.Fill(this.pi2013HajebdbDataSet.PoslovniPartner);

        }

        //proslijedi listu označenih tepiha iz prethodne forme trenutnoj formi

        public void passTepisi(List<DataGridViewRow> tepisi)
        {
            for (int i = tepisi.Count - 1; i >= 0; i--)
            {
                this.tepisi.Add(tepisi[i]);
            }
        }

        private void nazadGmb_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void odustaniGmb_Click(object sender, EventArgs e)
        {
            parentForm.Close();
            this.Close();
        }

        private void daljeGmb_Click(object sender, EventArgs e)
        {
            frmProdajaGeneriranjeRacuna prodajaGeneriranjeRacuna = new frmProdajaGeneriranjeRacuna(this);
            prodajaGeneriranjeRacuna.passKupci(kupci);
            prodajaGeneriranjeRacuna.passTepisi(tepisi);
            this.Hide();
            prodajaGeneriranjeRacuna.ShowDialog();
            this.Show();
        }

        private void datagridKupci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                //provjera da li je korisnik već odabrao jednog kupca
                //ako da onda se briše prijašnje selektirani kupac i označi se trenutno selektirani
                //moguće je na 1 račun odabrati samo jednog kupca
                foreach (DataGridViewRow row in this.datagridKupci.Rows)
                {
                    if (row.Cells[oIBDataGridViewTextBoxColumn.Name].Value == datagridKupci.Rows[selectedRowIndex].Cells[oIBDataGridViewTextBoxColumn.Name].Value)
                    {//ako dođe do trenutno selektiranog reda njega ne diraj (inače korisnik ne bi mogao uopće odselektirati kupca
                        //jer bi se uvijek checkbox selektiranog novog kupca postavio ne unchecked a dolje opet na checked
                        continue;
                    }
                    if (Convert.ToBoolean(row.Cells[check.Name].Value) == true)
                    {
                        row.Cells[check.Name].Value = false;
                    }
                }

                if (Convert.ToBoolean(datagridKupci.Rows[selectedRowIndex].Cells[check.Name].Value) == false)
                {
                    datagridKupci.Rows[selectedRowIndex].Cells[check.Name].Value = true;

                    kupci.Add(datagridKupci.Rows[selectedRowIndex]);
                }

                else if (Convert.ToBoolean(datagridKupci.Rows[selectedRowIndex].Cells[check.Name].Value) == true)
                {
                    datagridKupci.Rows[selectedRowIndex].Cells[check.Name].Value = false;

                    for (int i = kupci.Count - 1; i >= 0; i--)
                    {
                        if (kupci[i].Cells[oIBDataGridViewTextBoxColumn.Name].Value == datagridKupci.Rows[selectedRowIndex].Cells[oIBDataGridViewTextBoxColumn.Name].Value)
                        {
                            kupci.RemoveAt(i);
                        }
                    }
                }
            }
        }

        private void datagridKupci_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedRowIndex = e.RowIndex;
        }
    }
}
