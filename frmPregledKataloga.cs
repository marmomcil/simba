using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace simba
{
    public partial class frmPregledKataloga : Form
    {
        public frmPregledKataloga()
        {
            InitializeComponent();
        }

        private string urlSlike;
        private int selectedRowIndex;
        private string sifraTepiha;

        private void frmPregledKataloga_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pi2013HajebdbDataSet1.Tepih' table. You can move, or remove it, as needed.
            this.tepihTableAdapter.Fill(this.pi2013HajebdbDataSet1.Tepih);
                       
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btnDodajTepih, "Dodaj novi tepih");

            System.Windows.Forms.ToolTip ToolTip2 = new System.Windows.Forms.ToolTip();
            ToolTip2.SetToolTip(this.btnAzurirajTepih, "Uredi postojeći tepih");

            System.Windows.Forms.ToolTip ToolTip3 = new System.Windows.Forms.ToolTip();
            ToolTip3.SetToolTip(this.btnIzbrisiTepih, "Obriši postojeći tepih");

            System.Windows.Forms.ToolTip ToolTip4 = new System.Windows.Forms.ToolTip();
            ToolTip4.SetToolTip(this.btnSpremiPromjene, "Spremi promjene");

            System.Windows.Forms.ToolTip ToolTip5 = new System.Windows.Forms.ToolTip();
            ToolTip5.SetToolTip(this.btnIzlaz, "Zatvori Pregled kataloga");

            //odmah na početku postavi da je prvi red u datagridu selektiran i učitaj prvu sliku prvog tepiha (selektiranog tepiha) u imagebox
            selectedRowIndex = 0;
            DataGridViewRow selectedRow = dgvPregledKataloga.Rows[selectedRowIndex];

            urlSlike = Convert.ToString(selectedRow.Cells[7].Value); //index 7 zato jer stupac sa linkom prve slike ima u datagridu index 7

            this.imgTepih.Load(urlSlike);
        }

        /// <summary>
        /// ova metoda se pozove nakon pritiska
        /// gumba za učitavanje
        /// prve slike odabranog tepiha (selektiranog reda u datagridu)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void firstImgBtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgvPregledKataloga.Rows[selectedRowIndex]; //selektirani red u datagridu = index selektiranog reda
            urlSlike = Convert.ToString(selectedRow.Cells[7].Value);

            this.imgTepih.Load(urlSlike);
        }

        /// <summary>
        /// ova metoda se pozove nakon što se pritisne gumb za učitavanje druge slike
        /// selektiranog tepiha (selektiranog u datagridu)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void secondImgBtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgvPregledKataloga.Rows[selectedRowIndex];
            urlSlike = Convert.ToString(selectedRow.Cells[8].Value);

            this.imgTepih.Load(urlSlike);
        }

        /// <summary>
        /// ova metoda se pozove kada korisnik pritisne na neku ćeliju
        /// u datagridu
        /// ova je metoda je potrebna kako bi program "znao" koji je trenutno selektirani
        /// red u datagridu odnosno trenutno selektirani tepih u datagridu 
        /// kako bi znao u kojem redu "tražiti" link za sliku koju treba učitati u pictureboxu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void datagridTepisi_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
            {//ako korisnik klikne na zaglavlje stupca (kako bi sortirao) aplikacija treba "zapamtiti" šifru trenutno selektiranog tepiha kako bi se poslije mogao pozicionirati
                //na taj isti tepih
                sifraTepiha = dgvPregledKataloga.SelectedRows[0].Cells[sifraTepihaDataGridViewTextBoxColumn.Name].Value.ToString();
            }

            else
            {
                selectedRowIndex = e.RowIndex; // argument eventa je red na kojem je pritisnuta tipka miša, a pošto je objekt klase datagrid iz njega možemo "dobiti" index trenutnog reda
                DataGridViewRow selectedRow = dgvPregledKataloga.Rows[selectedRowIndex];
                urlSlike = Convert.ToString(selectedRow.Cells[7].Value); //dohvaća link prve slike tepiha u pritisnutom redu

                //ovaj uvjet provjerava da li smo kliknuli na red tepiha za koji je već učitana slika (prva ili druga) pa ako je već učitana da ne učitava ponovo
                if ((Convert.ToString(selectedRow.Cells[7].Value) != this.imgTepih.ImageLocation) && (Convert.ToString(selectedRow.Cells[8].Value) != this.imgTepih.ImageLocation))
                {
                    this.imgTepih.Load(urlSlike);
                }
            }
        }

        

        private void btnDodajTepih_Click(object sender, EventArgs e)
        {
            frmUredjivanjeKataloga UrediKatalog = new frmUredjivanjeKataloga();
            UrediKatalog.Show();
        }

        private void btnAzurirajTepih_Click(object sender, EventArgs e)
        {

        }

        private void btnIzbrisiTepih_Click(object sender, EventArgs e)
        {

        }

        private void btnSpremiPromjene_Click(object sender, EventArgs e)
        {

        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTraziTepih_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs1 = new BindingSource();
            bs1.DataSource = dgvPregledKataloga.DataSource;
            bs1.Filter = " Convert(SifraTepiha, 'System.String') LIKE '%" + txtTraziTepih.Text + "%' OR Convert(Naziv, 'System.String') LIKE '%" + txtTraziTepih.Text + "%' OR Convert(Dimenzije, 'System.String') LIKE '%" + txtTraziTepih.Text + "%' OR Convert(ZemljaPorijekla, 'System.String') LIKE '%" + txtTraziTepih.Text + "%' OR Convert(Sastav, 'System.String') LIKE '%" + txtTraziTepih.Text + "%' OR Convert(Cvoraza, 'System.String') LIKE '%" + txtTraziTepih.Text + "%' OR Convert(Cijena, 'System.String') LIKE '%" + txtTraziTepih.Text + "%' ";
            dgvPregledKataloga.DataSource = bs1;
        }

        private void dgvPregledKataloga_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {//ukoliko se datagrid sortira onda se ponovo svi podaci učitavaju
            if (!String.IsNullOrEmpty(sifraTepiha) && e.ListChangedType == ListChangedType.Reset)
            {
                int row = tepihBindingSource.Find("SifraTepiha", sifraTepiha);

                dgvPregledKataloga.BeginInvoke((MethodInvoker)delegate()
                {
                    dgvPregledKataloga.Rows[row].Selected = true;
                    dgvPregledKataloga.CurrentCell = dgvPregledKataloga[0, row];
                });
            }
        }
    }
}
