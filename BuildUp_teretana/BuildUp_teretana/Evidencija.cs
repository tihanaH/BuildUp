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
    public partial class FrmEvidencija : Form
    {
        Clanarina clanarina;
        private string brojiskaznice;
        public FrmEvidencija(string brojiskaznice)
        {
            InitializeComponent();
            this.brojiskaznice = brojiskaznice;
            this.CenterToParent();
            using (BuildUp dbcontext = new BuildUp())
            {
                clanarina = dbcontext.Clanarinas.FirstOrDefault(preuzeta_clanarina => preuzeta_clanarina.BrojIskaznice == int.Parse(brojiskaznice));
                if (clanarina.Vrsta == 'G') txtPreostaliBrojDolazaka.Text = "Godišnja članarina";
                else txtPreostaliBrojDolazaka.Text = clanarina.Broj_dolazaka.ToString();
            } 
        }

        private void FrmEvidencija_Load(object sender, EventArgs e)
        {

        }

        private void btnDolazakOk_Click(object sender, EventArgs e)
        {
            if (chkPotvrdiDolazak.Checked == true)
            {
                using (BuildUp dbcontext = new BuildUp())
                {
                    clanarina.Broj_dolazaka--;
                    dbcontext.AttachCopy(clanarina);
                    dbcontext.SaveChanges();
                }
                this.Close();
            }
            else
            {
               DialogResult dialogResult =  MessageBox.Show("Niste potvrdili dolazak! Jeste li sigurni da želite napustiti formu?", "Potvrda", MessageBoxButtons.YesNo);
               if (dialogResult == DialogResult.Yes)
               {
                   this.Close();
               }
               else if (dialogResult == DialogResult.No)
               {

               }

            }
        }
    }
}
