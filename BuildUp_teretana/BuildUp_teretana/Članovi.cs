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
    public partial class FrmČlanovi : Form
    {
        public FrmČlanovi()
        {
            InitializeComponent();
            this.CenterToParent();
            List<Clan> clanovi=dohvati_clanove();
            dataGridView1.DataSource = clanovi;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private List<Clan> dohvati_clanove()
        {
        using (BuildUp dbContext = new BuildUp())
            {
                var q =
                    from clanovi in dbContext.Clans
                    select new Clan()
                    {
                        Adresa = clanovi.Adresa,
                        BrojIskaznice = clanovi.BrojIskaznice,
                        Ime = clanovi.Ime,
                        Kontakt = clanovi.Kontakt,
                        Prezime = clanovi.Prezime,
                        Spol = clanovi.Spol
                    };
                return q.ToList();
            }
        }

        private void brišiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int indeks_selektiranog_retka = dataGridView1.CurrentCell.RowIndex;
            using (BuildUp dbContext = new BuildUp())
            {
                var clan_za_brisanje =
                    from clanovi in dbContext.Clans
                    where  clanovi.BrojIskaznice == int.Parse(dataGridView1.Rows[indeks_selektiranog_retka].Cells[0].Value.ToString())
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
    }
}
