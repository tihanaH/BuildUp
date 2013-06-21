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
    public partial class DodajClanarinu : Form
    {
        private string brojiskaznice;

        public DodajClanarinu(string brojiskaznice)
        {
            InitializeComponent();
            this.CenterToParent();
            this.brojiskaznice = brojiskaznice;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTip.Text == "") 
            {

            }
            else if (cmbTip.Text == "G") 
            {
                lblBrojDolazaka.Visible = false;
                txtBrojDolazaka.Visible = false;
            }
            else if (cmbTip.Text == "M")
            {
                lblBrojDolazaka.Visible = true;
                txtBrojDolazaka.Visible = true;
            }
        }

        private void DodajClanarinu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbTip.Text == "")
            {
                MessageBox.Show("Niste odabrali tip članarine!");
            }
            else if(cmbTip.Text=="M" &&txtBrojDolazaka.Text=="")
            {
                MessageBox.Show("Niste upisali broj dolazaka!");
            }
            else 
            {
                using (BuildUp dbcontext = new BuildUp()) 
                {
                    

                    Clanarina nova_clanarina=dbcontext.Clanarinas.FirstOrDefault(clanarina=>clanarina.BrojIskaznice==int.Parse(brojiskaznice));

                    nova_clanarina.Mjesec_uplate = DateTime.Now.Month.ToString();
                    nova_clanarina.Godina_uplate = DateTime.Now.Year.ToString();
                    nova_clanarina.Vrsta = cmbTip.Text[0];
                    if (txtBrojDolazaka.Text == "") { nova_clanarina.Broj_dolazaka = 0; }

                    else nova_clanarina.Broj_dolazaka = int.Parse(txtBrojDolazaka.Text);
                  
                    dbcontext.SaveChanges();
                    MessageBox.Show("Uspješno ažurirana članarina!");
                }
                this.Close();
            }
        }
    }
}
