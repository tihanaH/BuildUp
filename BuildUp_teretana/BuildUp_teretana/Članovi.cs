using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;


namespace BuildUp_teretana
{
    public partial class FrmČlanovi : Form
    {
        public FrmČlanovi()
        {
            InitializeComponent();
            this.CenterToParent();
            PrikaziSveAktivneClanove();
        }

        private void PrikaziSveAktivneClanove()
        {
            List<Clan> clanovi = dohvati_clanove();
            dataGridView1.DataSource = clanovi;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.DefaultCellStyle.BackColor = Color.White;

        }

        private List<Clan> dohvati_clanove()
        {
        using (BuildUp dbcontext = new BuildUp())
            {
                var q =
                    from clanovi in dbcontext.Clans
                    join clanarina in dbcontext.Clanarinas on clanovi.BrojIskaznice equals clanarina.BrojIskaznice
                    where (clanarina.Vrsta=='G'&&clanarina.Godina_uplate==DateTime.Now.Year.ToString())
                    ||(clanarina.Vrsta=='M'&&clanarina.Mjesec_uplate==DateTime.Now.Month.ToString()&&clanarina.Broj_dolazaka>0)


                    select new Clan()
                    {
                        Adresa = clanovi.Adresa,
                        BrojIskaznice = clanovi.BrojIskaznice,
                        Ime = clanovi.Ime,
                        Email = clanovi.Email,
                        Kontakt = clanovi.Kontakt,
                        Prezime = clanovi.Prezime,
                        Spol = clanovi.Spol
                    };
                return q.ToList();
            }
        }

        private void brišiToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void dodajToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void izmjeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private List<Clan> dohvati_neaktivne_clanove()
        {
            using (BuildUp dbContext = new BuildUp())
            {
                var q =
                    from clanovi in dbContext.Clans
                    join clanarina in dbContext.Clanarinas on clanovi.BrojIskaznice equals clanarina.BrojIskaznice
                    where (clanarina.Vrsta == 'G' && clanarina.Godina_uplate != DateTime.Now.Year.ToString())
                    || (clanarina.Vrsta == 'M' &&( clanarina.Mjesec_uplate != DateTime.Now.Month.ToString() || clanarina.Broj_dolazaka == 0))
      
                    select new Clan()
                    {
                        Adresa = clanovi.Adresa,
                        BrojIskaznice = clanovi.BrojIskaznice,
                        Ime = clanovi.Ime,
                        Email = clanovi.Email,
                        Kontakt = clanovi.Kontakt,
                        Prezime = clanovi.Prezime,
                        Spol = clanovi.Spol
                    };
                return q.ToList();
            }
        
        }
        private void promijeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrikaziPopisNeaktivnihClanova();

        }

        private void PrikaziPopisNeaktivnihClanova()
        {

            List<Clan> clanovi = dohvati_neaktivne_clanove();
            btnAktivirajClanarinu.Visible = true;
            btnBack.Visible = true;
            dataGridView1.DataSource = clanovi;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.DefaultCellStyle.BackColor = Color.MistyRose;
            dataGridView1.DefaultCellStyle.BackColor = Color.MistyRose;
        }

        private void btnAktivirajClanarinu_Click(object sender, EventArgs e)
        {
            try
            {
                int indeks_selektiranog_retka = dataGridView1.CurrentCell.RowIndex;
                DodajClanarinu dodajclanarinu = new DodajClanarinu(dataGridView1.Rows[indeks_selektiranog_retka].Cells[0].Value.ToString());
                dodajclanarinu.ShowDialog();
                PrikaziPopisNeaktivnihClanova();
            }
            catch
            {
                MessageBox.Show("Nije uspješno selektiran član!");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            btnBack.Visible = false;
            btnAktivirajClanarinu.Visible = false;
            PrikaziSveAktivneClanove();

        }

        private void btnTraziClan_Click(object sender, EventArgs e)
        {
            btnBack.Visible = true;
            dataGridView1.CurrentCell = null;
            
            for (int i = 0;i<dataGridView1.Rows.Count;i++)
            {
                dataGridView1.Rows[i].Visible = true;
                if (string.Compare(dataGridView1.Rows[i].Cells[1].Value.ToString() + " " + dataGridView1.Rows[i].Cells[2].Value.ToString(), txtTraziClan.Text) == 0)
                {
                    
                }
                else 
                {
                    dataGridView1.Rows[i].Visible = false;


                }
            }
        }

        private void evidencijaToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void dolazakToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                int indeks_selektiranog_retka = dataGridView1.CurrentCell.RowIndex;
                FrmEvidencija evidencijadolaska = new FrmEvidencija(dataGridView1.Rows[indeks_selektiranog_retka].Cells[0].Value.ToString());
                evidencijadolaska.ShowDialog();
                PrikaziSveAktivneClanove();
            }
            catch
            {
                MessageBox.Show("Niste odabrali korisnika!");
            }
        }

        private void spraveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sprave forma_sprava = new Sprave();
            forma_sprava.ShowDialog();
        }

        private void programVježbanjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int indeks_selektiranog_retka = dataGridView1.CurrentCell.RowIndex;
                int broj_iskaznice_selektiranog = int.Parse(dataGridView1.Rows[indeks_selektiranog_retka].Cells[0].Value.ToString());
                frmProgramVjezbanja program = new frmProgramVjezbanja(broj_iskaznice_selektiranog);
                program.ShowDialog();
            }
            catch {
                MessageBox.Show("Nema članova ili nije uspješno izvršena naredba!");
            }
        }

        private void odlazakToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                int indeks_selektiranog_retka = dataGridView1.CurrentCell.RowIndex;
                int broj_iskaznice_selektiranog = int.Parse(dataGridView1.Rows[indeks_selektiranog_retka].Cells[0].Value.ToString());
                frmProgramVjezbanja program_vjezbanja = new frmProgramVjezbanja(broj_iskaznice_selektiranog, true);
                program_vjezbanja.ShowDialog();
            }
            catch {
                MessageBox.Show("Nema članova ili nije uspješno izvršena naredba!");
            }
        }

        private void izmijeniMjereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int indeks_selektiranog_retka = dataGridView1.CurrentCell.RowIndex;
                int broj_iskaznice_selektiranog = int.Parse(dataGridView1.Rows[indeks_selektiranog_retka].Cells[0].Value.ToString());
                IzmijeniMjere izmijeni = new IzmijeniMjere(broj_iskaznice_selektiranog);
                izmijeni.ShowDialog();
            }
            catch {
                MessageBox.Show("Nije uspješno selektiran član ili nije uspješno izvršena naredba!");
            }

        }

        private void FrmČlanovi_Load(object sender, EventArgs e)
        {

        }

        private void brišiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int indeks_selektiranog_retka = dataGridView1.CurrentCell.RowIndex;
            using (BuildUp dbContext = new BuildUp())
            {
                var clan_za_brisanje =
                    from clanovi in dbContext.Clans
                    where clanovi.BrojIskaznice == int.Parse(dataGridView1.Rows[indeks_selektiranog_retka].Cells[0].Value.ToString())
                    select clanovi;

                foreach (var clan in clan_za_brisanje)
                {
                    dbContext.Delete(clan);
                }
                dbContext.SaveChanges();
                MessageBox.Show("Član uspješno obrisan!");
                List<Clan> svi_clanovi = dohvati_clanove();
                dataGridView1.DataSource = svi_clanovi;
            }
        }

        private void izmijeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int indeks_selektiranog_retka = dataGridView1.CurrentCell.RowIndex;
            int BrojIskaznice = int.Parse(dataGridView1.Rows[indeks_selektiranog_retka].Cells[0].Value.ToString());
            FrmIzmjeni izmijeniclana = new FrmIzmjeni(BrojIskaznice);
            izmijeniclana.ShowDialog();
            List<Clan> svi_clanovi = dohvati_clanove();
            dataGridView1.DataSource = svi_clanovi;
        }

        private void dodajToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmDodajČlana dodajclana = new FrmDodajČlana();
            dodajclana.ShowDialog();
            List<Clan> svi_clanovi = dohvati_clanove();
            dataGridView1.DataSource = svi_clanovi;
        } 
    }//riješeno, ako imaš još vremena onda ću probati srediti ovo dodavanja? možeš
}
//rekao mi je marko da dodam briši, izmijeni, dodaj pod evidenciju