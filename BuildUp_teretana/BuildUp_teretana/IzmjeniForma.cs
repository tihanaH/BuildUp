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
    public partial class FrmIzmjeni : Form
    {
        private Clan izmijenjeni_clan;

        public FrmIzmjeni(int BrojIskaznice)
        {
            InitializeComponent();
            this.CenterToParent();
            using (BuildUp dbcontext = new BuildUp())
            {
                izmijenjeni_clan = dbcontext.Clans.FirstOrDefault(clan => clan.BrojIskaznice == BrojIskaznice);
            }

            txtImeIzmjeni.Text = izmijenjeni_clan.Ime;
            txtEmailIzmjeni.Text = izmijenjeni_clan.Email;
            txtAdresaIzmjeni.Text = izmijenjeni_clan.Adresa;
            txtPrezimeIzmjeni.Text = izmijenjeni_clan.Prezime;
            txtTelefonIzmjeni.Text = izmijenjeni_clan.Kontakt; 

        }

        private void FrmIzmjeni_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSpremiPromjene_Click(object sender, EventArgs e)
        {
            if (txtTelefonIzmjeni.Text == "") {
                MessageBox.Show("Niste upisali telefon!");
            }
            else if (txtPrezimeIzmjeni.Text == "") {
                MessageBox.Show("Niste upisali prezime!");
            }
            else if (txtImeIzmjeni.Text == "") {
                MessageBox.Show("Niste upisali ime!");
            }
            else if (txtEmailIzmjeni.Text == "") {
                MessageBox.Show("Niste upisali e-mail!");
            }
            else if (txtAdresaIzmjeni.Text == "")
            {
                MessageBox.Show("Niste upisali adresu!");
            }
            else {

                izmijenjeni_clan.Adresa = txtAdresaIzmjeni.Text;
                izmijenjeni_clan.Email = txtEmailIzmjeni.Text;
                izmijenjeni_clan.Ime = txtImeIzmjeni.Text;
                izmijenjeni_clan.Prezime = txtPrezimeIzmjeni.Text;
                izmijenjeni_clan.Kontakt = txtTelefonIzmjeni.Text;

                using (BuildUp dbcontext = new BuildUp()) 
                {
                    dbcontext.AttachCopy(izmijenjeni_clan);
                    dbcontext.SaveChanges();
                }
                MessageBox.Show("Uspješno izmijenjeni podaci o članu!");
                this.Close();
            }

        }
    }
}
