using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuildUp_teretana
{
    public partial class frmProgramVjezbanja : Form
    {
        private int brojiskaznice;
        bool tko_je_pozvao_formu = false;
        public frmProgramVjezbanja(int broj_iskaznice_selektiranog)
        {
            InitializeComponent();
            this.CenterToParent();
            brojiskaznice = broj_iskaznice_selektiranog;
            dohvati_sprave_korisnika();
            
        }

        public frmProgramVjezbanja(int broj_iskaznice_selektiranog, bool tko_je_pozvao_formu) {
            InitializeComponent();
            this.CenterToParent();
            brojiskaznice = broj_iskaznice_selektiranog;
            btnDodajSpravu.Visible = false;
            grpNovoVrijeme.Visible = false;
            btnObrisiSpravu.Visible = false;
            btnPotvrdi.Visible = false;
            grpOvotjedno.Visible = true;
            this.tko_je_pozvao_formu = true;
            dohvati_sprave_korisnika();
        }

        private void dohvati_sprave_korisnika() {
            using (BuildUp dbcontext = new BuildUp()) {
                var clan_na_spravama =
                    from vrijemeNaSpravi in dbcontext.VrijemeNaSpravis
                    join sprave in dbcontext.Spravas on vrijemeNaSpravi.ID_sprave equals
                        sprave.ID_sprave
                    where vrijemeNaSpravi.BrojIskaznice == brojiskaznice
                    select new
                    {
                        vrijeme = vrijemeNaSpravi.Vrijeme,
                        SpravaNaziv = sprave.Naziv,
                        SpravaId = sprave.ID_sprave,
                        SpraveKalorije = sprave.Prosjecna_potrosnja_kalorija
                    };
                dataGridView1.DataSource = clan_na_spravama.ToList();
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            try
            {
                grpNovoVrijeme.Enabled = true;
                int indeks_selektiranog_retka = dataGridView1.CurrentCell.RowIndex;
                txtVrijemeNaSpravi.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
            }
            catch
            {
                grpNovoVrijeme.Enabled = false;
            }
        }

        private void frmProgramVjezbanja_Load(object sender, EventArgs e)
        {

        }

        private void btnDodajSpravu_Click(object sender, EventArgs e)
        {
            Sprave dodaj_spravu = new Sprave(brojiskaznice);
            dodaj_spravu.ShowDialog();
            dohvati_sprave_korisnika();
        }

        private void btnObrisiSpravu_Click(object sender, EventArgs e)
        {
            try
            {
                int indeks_selektiranog_retka = dataGridView1.CurrentCell.RowIndex;
                using (BuildUp dbcontext = new BuildUp()) {
                    var za_brisanje =
                        from program in dbcontext.VrijemeNaSpravis
                        where program.ID_sprave == int.Parse(dataGridView1.Rows[indeks_selektiranog_retka].Cells[2].Value.ToString()) && program.BrojIskaznice == brojiskaznice
                        select program;
                    foreach (var program in za_brisanje) {
                        dbcontext.Delete(program);
                    }
                    dbcontext.SaveChanges();
                }
                MessageBox.Show("Uspješno izbrisana sprava iz programa!");
                dohvati_sprave_korisnika();
            }
            catch {
                MessageBox.Show("Nije uspješno obrisana sprava!");
            }
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^[0-9]+$");
            if(!regex.IsMatch(txtVrijemeNaSpravi.Text))
            {
                MessageBox.Show("Morate unijeti samo brojeve!");
            }
            else if (txtVrijemeNaSpravi.Text == "") {
                MessageBox.Show("Niste unijeli vrijeme za spravu!");
            }
            else
            {
                try
                {
                    int indeks_selektiranog_retka = dataGridView1.CurrentCell.RowIndex;
                    using (BuildUp dbcontext = new BuildUp())
                    {
                        var za_brisanje =
                            from program in dbcontext.VrijemeNaSpravis
                            where program.ID_sprave == int.Parse(dataGridView1.Rows[indeks_selektiranog_retka].Cells[2].Value.ToString()) && program.BrojIskaznice == brojiskaznice
                            select program;
                        foreach (var program in za_brisanje)
                        {
                            program.Vrijeme = int.Parse(txtVrijemeNaSpravi.Text);
                            dbcontext.AttachCopy(program);
                        }
                        dbcontext.SaveChanges();
                    }
                    MessageBox.Show("Uspješno ažurirano vrijeme na spravi u programu!");
                    dohvati_sprave_korisnika();
                }
                catch
                {
                    MessageBox.Show("Nije uspješno ažurirano vrijeme programa!");
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                grpNovoVrijeme.Enabled = true;
                int indeks_selektiranog_retka = dataGridView1.CurrentCell.RowIndex;
                txtVrijemeNaSpravi.Text = dataGridView1.Rows[indeks_selektiranog_retka].Cells[0].Value.ToString();
            }
            catch
            {
                grpNovoVrijeme.Enabled = false;
            }
        }

        List<int> izmijenjeni_redovi = new List<int>();

        private void btnOvotjedno_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^[0-9]+$");
            if (!regex.IsMatch(txtOvotjedno.Text))
            {
                MessageBox.Show("Morate unijeti samo brojeve!");
            }
            else if (txtOvotjedno.Text == "")
            {
                MessageBox.Show("Niste unijeli ovotjedno vrijeme za spravu!");
            }
            else {
                try
                {
                    int indeks_selektiranog_retka = dataGridView1.CurrentCell.RowIndex;
                    using (BuildUp dbcontext = new BuildUp())
                    {
                        var za_azuriranje =
                            from program in dbcontext.VrijemeNaSpravis
                            where program.ID_sprave == int.Parse(dataGridView1.Rows[indeks_selektiranog_retka].Cells[2].Value.ToString()) && program.BrojIskaznice == brojiskaznice
                            select program;
                        foreach (var program in za_azuriranje)
                        {
                            program.Vrijeme = int.Parse(txtOvotjedno.Text)+program.Vrijeme;
                            dbcontext.AttachCopy(program);
                        }
                        dbcontext.SaveChanges();
                    }
                    MessageBox.Show("Uspješno ažurirano vrijeme na spravi u programu!");
                    dohvati_sprave_korisnika();
                    izmijenjeni_redovi.Add(indeks_selektiranog_retka);
                    foreach (int redak in izmijenjeni_redovi) {
                        dataGridView1.Rows[redak].DefaultCellStyle.BackColor = Color.MistyRose;
                    }
                    
                }
                catch {
                    MessageBox.Show("Nije uspješno ažurirano ovotjedno vrijeme programa!");
                }
            }
        }
    }
}
