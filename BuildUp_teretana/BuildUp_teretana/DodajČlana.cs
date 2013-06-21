using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuildUp_teretana
{
    public partial class FrmDodajČlana : Form
    {
        public FrmDodajČlana()
        {
            InitializeComponent();
            this.CenterToParent();
        }

        private void DodajČlana_Load(object sender, EventArgs e)
        {

        }

        private void btnOkDodajClan_Click(object sender, EventArgs e)
        {
            if (cmbSpol.Text == "")
            {
                MessageBox.Show("Morate odabrati spol");
            }
            else if (txtIme.Text == "")
            {
                MessageBox.Show("Morate upisati ime korisnika!");
            }
            else if (txtPrezime.Text == "")
            {
                MessageBox.Show("Morate upisati prezime korisnika!");
            }
            else if (txtAdresa.Text == "")
            {
                MessageBox.Show("Morate upisati adresu korisnika!");
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Morate upisati Email korisnika!");
            }
            else if (txtTelefon.Text == "")
            {
                MessageBox.Show("Morate upisati telefon korisnika!");
            }
            else if (cmbVrsta.Text == "") 
            {
                MessageBox.Show("Niste odabrali vrstu članarine!");
            }
            else if (cmbVrsta.Text == "M" && txtBrojDolazaka.Text == "") {
                MessageBox.Show("Niste upisali mjesečni broj dolazaka za članarinu!");
            }
            else
            {
                Clan clan = new Clan();
                clan.Adresa = txtAdresa.Text;
                clan.Email = txtEmail.Text;
                clan.Ime = txtIme.Text;
                clan.Prezime = txtPrezime.Text;
                clan.Spol = cmbSpol.Text[0];
                clan.Kontakt = txtTelefon.Text;

                Izvjesce izvjesce = new Izvjesce();
                izvjesce.Clan = clan;
                izvjesce.Godina = DateTime.Now.Year.ToString();
                izvjesce.Mjesec = DateTime.Now.Month.ToString();

                if (txtBokovi.Text == "") izvjesce.ObujamBokova = 0;
                else izvjesce.ObujamBokova = int.Parse(txtBokovi.Text);

                if (txtPrsa.Text == "") izvjesce.ObujamPrsa = 0;
                else izvjesce.ObujamPrsa = int.Parse(txtPrsa.Text);

                if (txtStruk.Text == "") izvjesce.ObujamStruka = 0;
                else izvjesce.ObujamStruka = int.Parse(txtStruk.Text);

                izvjesce.PotrosnjaKalorija = 0;
                if (txtTezina.Text == "") izvjesce.Tezina = 0;
                else izvjesce.Tezina = int.Parse(txtTezina.Text);

                if (txtList.Text == "") izvjesce.List = 0;
                else izvjesce.List = int.Parse(txtList.Text);

                if (txtBMI.Text == "") izvjesce.BMI = 0;
                else izvjesce.List = int.Parse(txtBMI.Text);

                if (txtMasnoTkivo.Text == "") izvjesce.MasnoTkvio = 0;
                else izvjesce.MasnoTkvio = int.Parse(txtMasnoTkivo.Text);

                if (txtBedro.Text == "") izvjesce.Bedro = 0;
                else izvjesce.Bedro = int.Parse(txtBedro.Text);

                if (txtBiceps.Text == "") izvjesce.Biceps = 0;
                else izvjesce.Biceps = int.Parse(txtBiceps.Text);

                Clanarina clanarina = new Clanarina();
                clanarina.Clan = clan;

                if (cmbVrsta.Text == "G")
                {
                    clanarina.Broj_dolazaka = 9999;
                }

                else
                {
                    clanarina.Broj_dolazaka = int.Parse(txtBrojDolazaka.Text);
                }
                
                clanarina.Vrsta = cmbVrsta.Text[0];
                clanarina.Godina_uplate = DateTime.Now.Year.ToString();
                clanarina.Mjesec_uplate = DateTime.Now.Month.ToString();

                using (BuildUp dbcontext = new BuildUp())
                {
                    dbcontext.Add(clan);
                    dbcontext.Add(izvjesce);
                    dbcontext.Add(clanarina);
                    dbcontext.SaveChanges();
                }
                MessageBox.Show("Uspješno dodan član!");
                this.Close();
            }
        }

        private void grpMjere_Enter(object sender, EventArgs e)
        {

        }

        private void cmbVrsta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbVrsta.Text == "M")
            {
                lblDolasci.Visible = true;
                txtBrojDolazaka.Visible = true;
            }

            else
            {
                lblDolasci.Visible = false;
                txtBrojDolazaka.Visible = false;

            }
        }
    }
}
