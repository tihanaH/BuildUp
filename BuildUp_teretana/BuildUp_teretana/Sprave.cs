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

    public partial class Sprave : Form
    {
        List<Sprava> sve_sprave;
        Sprava sprava_za_mijenjanje;
        public Sprave()
        {
            InitializeComponent();
            sve_sprave = dohvati_sve_sprave();
            podesi_dataGrid();
        }

        private void podesi_dataGrid()
        {
            dataGridView1.DataSource = sve_sprave;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[2].HeaderText = "Kalorije";
        }


        private List<Sprava> dohvati_sve_sprave()
        {
            using (BuildUp dbcontext = new BuildUp())
            {
                var dohvacene_sprave =
                    dbcontext.GetAll<Sprava>();
                return dohvacene_sprave.ToList();
            }

        }

        private void btnDodajSpravu_Click(object sender, EventArgs e)
        {
            grpDodaj.Visible = true;
            grpPromijeni.Visible = false;
            txtImeDodaneSprave.Text = "";
            txtKalorijeNoveSprave.Text = "";

        }

        private void btnPotvrdiDodavanje_Click(object sender, EventArgs e)
        {
            if (txtKalorijeNoveSprave.Text == "")
            {
                MessageBox.Show("Niste potrošnju kalorija sprave!");
            }
            else if (txtImeDodaneSprave.Text == "")
            {
                MessageBox.Show("Niste upisali ime sprave!");
            }
            else
            {
                Sprava nova_sprava = new Sprava();
                nova_sprava.Naziv = txtImeDodaneSprave.Text;
                nova_sprava.Prosjecna_potrosnja_kalorija = int.Parse(txtKalorijeNoveSprave.Text);
                using (BuildUp dbcontext = new BuildUp())
                {
                    dbcontext.Add(nova_sprava);
                    dbcontext.SaveChanges();
                }
                txtImeDodaneSprave.Text = "";
                txtKalorijeNoveSprave.Text = "";
                MessageBox.Show("Uspješno dodana sprava!");
                sve_sprave = dohvati_sve_sprave();
                podesi_dataGrid();
            }

        }

        private void btnPromijeniSpravu_Click(object sender, EventArgs e)
        {
            grpDodaj.Visible = false;
            grpPromijeni.Visible = true;
            txtNazivPromijenjeni.Text = "";
            txtKalorijePromijenjene.Text = "";
            try
            {
                int indeks_selektiranog_retka = dataGridView1.CurrentCell.RowIndex;
                using (BuildUp dbcontext = new BuildUp())
                {
                    sprava_za_mijenjanje = dbcontext.Spravas.FirstOrDefault(spravu => spravu.ID_sprave == int.Parse(dataGridView1.Rows[indeks_selektiranog_retka].Cells[0].Value.ToString()));
                }
                txtKalorijePromijenjene.Text = sprava_za_mijenjanje.Prosjecna_potrosnja_kalorija.ToString();
                txtNazivPromijenjeni.Text = sprava_za_mijenjanje.Naziv;
            }
            catch
            {
                MessageBox.Show("Nisu uspješno dohvaćeni podaci o spravi ili nema sprave!");
                grpPromijeni.Visible = false;
            }
        }

        private void btnPotvrdiPromjenu_Click(object sender, EventArgs e)
        {
            if (txtNazivPromijenjeni.Text == "")
            {
                MessageBox.Show("Niste unijeli naziv sprave!");
            }
            else if (txtKalorijePromijenjene.Text == "")
            {
                MessageBox.Show("Niste unijeli kalorije sprave!");
            }
            else
            {
                sprava_za_mijenjanje.Naziv = txtNazivPromijenjeni.Text;
                sprava_za_mijenjanje.Prosjecna_potrosnja_kalorija = int.Parse(txtKalorijePromijenjene.Text);
                using (BuildUp dbcontext = new BuildUp())
                {
                    dbcontext.AttachCopy(sprava_za_mijenjanje);
                    dbcontext.SaveChanges();
                }
                txtNazivPromijenjeni.Text = "";
                txtKalorijePromijenjene.Text = "";
                MessageBox.Show("Uspješno promijenjeni podaci o spravi!");
                grpPromijeni.Visible = false;
                sve_sprave = dohvati_sve_sprave();
                podesi_dataGrid();
            }
        }

        private void btnObrisiSpravu_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("Jeste li sigurni da želite obrisati spravu?", "Potvrda", MessageBoxButtons.YesNo);
            if (dialogresult == DialogResult.Yes)
            {
                try
                {
                    int indeks_selektiranog_retka = dataGridView1.CurrentCell.RowIndex;
                    using (BuildUp dbcontext = new BuildUp())
                    {
                        sprava_za_mijenjanje = dbcontext.Spravas.FirstOrDefault(spravu => spravu.ID_sprave == int.Parse(dataGridView1.Rows[indeks_selektiranog_retka].Cells[0].Value.ToString()));
                        dbcontext.Delete(sprava_za_mijenjanje);
                        dbcontext.SaveChanges();
                    }
                    MessageBox.Show("Uspješno obrisana sprava!");
                    sve_sprave = dohvati_sve_sprave();
                    podesi_dataGrid();

                }
                catch
                {
                    MessageBox.Show("Niste odabrali spravu!");
                }
            }
            else if (dialogresult == DialogResult.No)
            { 

            }
        }
    }
}

