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
    public partial class frmProdajaGeneriranjeRacuna : Form
    {
        public frmProdajaGeneriranjeRacuna(frmProdajaOdabirKupca parentForm)
        {
            InitializeComponent();
            createDatagrid();
            this.parentForm = parentForm;
            cijena = 0;
            cijenaPDV = 0;
            PDV = 0;
            sum = 0;
            discountFl = 0;
        }

        frmProdajaOdabirKupca parentForm;

        public List<DataGridViewRow> kupci = new List<DataGridViewRow>();
        private double cijena;
        private double PDV;
        private double sum;
        private double discountFl;
        private double cijenaPDV;

        public void passTepisi(List<DataGridViewRow> tepisi)
        {
            //ova petlja ubacije označene tepihe u datagrid po redoslijedu šifre tepiha
            for (int i = tepisi.Count - 1; i >= 0; i--)
            {
                datagridTepisi.Rows.Add(tepisi[i].Cells[0].Value, tepisi[i].Cells[1].Value, tepisi[i].Cells[2].Value, tepisi[i].Cells[3].Value, tepisi[i].Cells[4].Value, tepisi[i].Cells[5].Value, tepisi[i].Cells[6].Value);
                cijena += Convert.ToInt32(tepisi[i].Cells[6].Value);
            }
            cost.Text = Convert.ToString(Math.Round(cijena,2));
            PDV = cijena * 0.25;
            pdv.Text = Convert.ToString(Math.Round(PDV,2));
            cijenaPDV = PDV + cijena;
            costPdv.Text = Convert.ToString(Math.Round(cijenaPDV,2));
            sum = cijenaPDV;
            ukupno.Text = Convert.ToString(Math.Round(sum,2));
        }

        public void passKupci(List<DataGridViewRow> kupci)
        {
            datagridKupac.Rows.Add(kupci[0].Cells[0].Value, kupci[0].Cells[1].Value, kupci[0].Cells[2].Value, kupci[0].Cells[3].Value, kupci[0].Cells[4].Value, kupci[0].Cells[5].Value);
        }

        public void createDatagrid()
        {
            DataGridViewTextBoxColumn oib = new DataGridViewTextBoxColumn();
            oib.Name = "OIB";
            oib.HeaderText = "OIB";
            oib.DataPropertyName = "OIB";
            datagridKupac.Columns.Add(oib);

            DataGridViewTextBoxColumn ime = new DataGridViewTextBoxColumn();
            ime.Name = "Ime";
            ime.HeaderText = "Ime";
            ime.DataPropertyName = "Ime";
            datagridKupac.Columns.Add(ime);

            DataGridViewTextBoxColumn prezime = new DataGridViewTextBoxColumn();
            prezime.Name = "Prezime";
            prezime.HeaderText = "Prezime";
            prezime.DataPropertyName = "Prezime";
            datagridKupac.Columns.Add(prezime);

            DataGridViewTextBoxColumn adresa = new DataGridViewTextBoxColumn();
            adresa.Name = "Adresa";
            adresa.HeaderText = "Adresa";
            adresa.DataPropertyName = "Adresa";
            datagridKupac.Columns.Add(adresa);

            DataGridViewTextBoxColumn telefon = new DataGridViewTextBoxColumn();
            telefon.Name = "Telefon";
            telefon.HeaderText = "Telefon";
            telefon.DataPropertyName = "Telefon";
            datagridKupac.Columns.Add(telefon);

            DataGridViewTextBoxColumn email = new DataGridViewTextBoxColumn();
            email.Name = "Email";
            email.HeaderText = "Email";
            email.DataPropertyName = "Email";
            datagridKupac.Columns.Add(email);

            DataGridViewTextBoxColumn sifraTepiha = new DataGridViewTextBoxColumn();
            sifraTepiha.Name = "SifraTepiha";
            sifraTepiha.HeaderText = "Šifra Tepiha";
            sifraTepiha.DataPropertyName = "SifraTepiha";
            datagridTepisi.Columns.Add(sifraTepiha);

            DataGridViewTextBoxColumn nazivTepiha = new DataGridViewTextBoxColumn();
            nazivTepiha.Name = "NazivTepiha";
            nazivTepiha.HeaderText = "Naziv";
            nazivTepiha.DataPropertyName = "NazivTepiha";
            datagridTepisi.Columns.Add(nazivTepiha);

            DataGridViewTextBoxColumn dimenzijeTepiha = new DataGridViewTextBoxColumn();
            dimenzijeTepiha.Name = "DimenzijeTepiha";
            dimenzijeTepiha.HeaderText = "Dimenzije";
            dimenzijeTepiha.DataPropertyName = "DimenzijeTepiha";
            datagridTepisi.Columns.Add(dimenzijeTepiha);

            DataGridViewTextBoxColumn zemljaPorijekla = new DataGridViewTextBoxColumn();
            zemljaPorijekla.Name = "ZemljaPorijekla";
            zemljaPorijekla.HeaderText = "Zemlja porijekla";
            zemljaPorijekla.DataPropertyName = "ZemljaPorijekla";
            datagridTepisi.Columns.Add(zemljaPorijekla);

            DataGridViewTextBoxColumn sastav = new DataGridViewTextBoxColumn();
            sastav.Name = "Sastav";
            sastav.HeaderText = "Sastav";
            sastav.DataPropertyName = "Sastav";
            datagridTepisi.Columns.Add(sastav);

            DataGridViewTextBoxColumn cvoraza = new DataGridViewTextBoxColumn();
            cvoraza.Name = "Cvoraza";
            cvoraza.HeaderText = "Čvoraza";
            cvoraza.DataPropertyName = "Cvoraza";
            datagridTepisi.Columns.Add(cvoraza);

            DataGridViewTextBoxColumn cijena = new DataGridViewTextBoxColumn();
            cijena.Name = "Cijena";
            cijena.HeaderText = "Cijena";
            cijena.DataPropertyName = "Cijena";
            datagridTepisi.Columns.Add(cijena);
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

        private void zavrsiGmb_Click(object sender, EventArgs e)
        {
        }

        private void popustChk_CheckedChanged(object sender, EventArgs e)
        {
            if (popustChk.Checked == true)
            {
                discountLabel.Visible = true;
                costDiscountLabel.Visible = true;
                discount.Visible = true;
                costDiscount.Visible = true;
                discountFl = cijenaPDV*0.10;
                discount.Text = Convert.ToString(Math.Round(discountFl, 2));
                costDiscount.Text = Convert.ToString((Math.Round((cijena - discountFl), 2)));
                sum = (cijenaPDV - discountFl);
                ukupno.Text = Convert.ToString(Math.Round(sum, 2));
            }

            else
            {
                discountLabel.Visible = false;
                costDiscountLabel.Visible = false;
                discount.Visible = false;
                costDiscount.Visible = false;
                sum = cijenaPDV;
                ukupno.Text = Convert.ToString(Math.Round(sum,2));
            }            
        }
    }
}
