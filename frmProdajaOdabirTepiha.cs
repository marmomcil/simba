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
    public partial class frmProdajaOdabirTepiha : Form
    {
        public frmProdajaOdabirTepiha(frmProdajaTepiha parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        frmProdajaTepiha parentForm;

        private string urlSlike;
        public static List<DataGridViewRow> tepisi = new List<DataGridViewRow>();
        private int selectedRowIndex;

        private void frmProdajaOdabirTepiha_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pi2013HajebdbDataSet2.Tepih' table. You can move, or remove it, as needed.
            this.tepihTableAdapter.Fill(this.pi2013HajebdbDataSet2.Tepih);

            //odmah na početku postavi da je prvi red u datagridu selektiran i učitaj prvu sliku prvog tepiha (selektiranog tepiha) u imagebox
            selectedRowIndex = 0;
            DataGridViewRow selectedRow = datagridTepisi.Rows[selectedRowIndex];

            urlSlike = Convert.ToString(selectedRow.Cells[8].Value); //index 8 zato jer stupac sa linkom prve slike ima u datagridu index 8

            this.slikaTepiha.Load(urlSlike); //učitaj sliku sa dobivenog lika iz datagrida
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
            DataGridViewRow selectedRow = datagridTepisi.Rows[selectedRowIndex]; //selektirani red u datagridu = index selektiranog reda
            urlSlike = Convert.ToString(selectedRow.Cells[8].Value);

            this.slikaTepiha.Load(urlSlike);
        }

        /// <summary>
        /// ova metoda se pozove nakon što se pritisne gumb za učitavanje druge slike
        /// selektiranog tepiha (selektiranog u datagridu)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void secondImgBtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = datagridTepisi.Rows[selectedRowIndex];
            urlSlike = Convert.ToString(selectedRow.Cells[9].Value); //stupac sa linkovima druge slike tepiha ima index 9 u datagridu

            this.slikaTepiha.Load(urlSlike);
        }

        /// <summary>
        /// ova metoda se pozove kada korisnik pritisne na neku čeliju
        /// u datagridu
        /// ova je metoda je potrebna kako bi program "znao" koji je trenutno selektirani
        /// red u datagridu odnosno trenutno selektirani tepih u datagridu 
        /// kako bi znao u kojem redu "tražiti" link za sliku koju treba učitati u pictureboxu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void datagridTepisi_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedRowIndex = e.RowIndex; // argument eventa je red na kojem je pritisnuta tipka miša, a pošto je objekt klase datagrid iz njega možemo "dobiti" index trenutnog reda
            DataGridViewRow selectedRow = datagridTepisi.Rows[selectedRowIndex];
            urlSlike = Convert.ToString(selectedRow.Cells[8].Value); //dohvaća link prve slike tepiha u pritisnutom redu
            
            //ovaj uvjet provjerava da li smo kliknuli na red tepiha za koji je već učitana slika (prva ili druga) pa ako je već učitana da ne učitava ponovo
            //znači ako korisnik klikne na check box da označi red (isti red - slika već učitana), da ne mora čekati da se slika već učitava
            if ((Convert.ToString(selectedRow.Cells[8].Value) != this.slikaTepiha.ImageLocation) && (Convert.ToString(selectedRow.Cells[9].Value) != this.slikaTepiha.ImageLocation))
            {
                this.slikaTepiha.Load(urlSlike);
            }
        }

        /// <summary>
        /// ova metoda će se pozvati kad god korisnik pritisne vrijednost unutar čelije, ali se u njoj provjerava koja je čelija pritisnuta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void datagridTepisi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7) //provjerava da li je pritisnut check box jer me samo u tom slučaju zanima nekakva promjena, ne zanima me ako korisnik npr pritisne ime tepiha
            {
                if (Convert.ToBoolean(datagridTepisi.Rows[selectedRowIndex].Cells[chk.Name].Value) == false) // ako je kučica check boxa prazna...
                {
                    datagridTepisi.Rows[selectedRowIndex].Cells[chk.Name].Value = true; //....onda je označi

                    tepisi.Add(datagridTepisi.Rows[selectedRowIndex]); //dodaj taj odabrani tepih u listu kako bi ga poslije mogli dodati na račun
                }

                else if (Convert.ToBoolean(datagridTepisi.Rows[selectedRowIndex].Cells[chk.Name].Value) == true) //ako je tepih označen....
                {
                    datagridTepisi.Rows[selectedRowIndex].Cells[chk.Name].Value = false; //....onda ga odoznači iz datagrida

                    for (int i = tepisi.Count - 1; i >= 0; i--)
                    {
                        if (tepisi[i].Cells[sifraTepihaDataGridViewTextBoxColumn.Name].Value == datagridTepisi.Rows[selectedRowIndex].Cells[sifraTepihaDataGridViewTextBoxColumn.Name].Value)
                        {//ako je šifra tepiha jedna šifri tepiha u označenom redu ( ako je lista našla tepih koji želimo odoznačiti iz datagrida )
                            tepisi.RemoveAt(i); //ukloni red iz lista na i-toj poziciji
                        }
                    }
                }
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
            frmProdajaOdabirKupca prodajaOdabirKupca = new frmProdajaOdabirKupca(this);

            this.Hide();
            prodajaOdabirKupca.ShowDialog();
            this.Show();
        }
    }
}
