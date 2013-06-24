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
        private int selectedRowIndex;

        frmProdajaOdabirTepiha parentForm;

        private void frmProdajaOdabirKupca_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pi2013HajebdbDataSet.PoslovniPartner' table. You can move, or remove it, as needed.
            this.poslovniPartnerTableAdapter.Fill(this.pi2013HajebdbDataSet.PoslovniPartner);

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

        }

        private void datagridKupci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
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
    }
}
