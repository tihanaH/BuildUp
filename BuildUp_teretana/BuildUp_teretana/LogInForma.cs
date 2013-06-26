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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            this.CenterToParent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtLozinka.Text == "")
            {
                MessageBox.Show("Niste upisali lozinku!");
            }
            else if (txtKorisnickoIme.Text == "")
            {
                MessageBox.Show("Niste upisali username!");
            }
            else
            {
                bool pronadjen = false; 
                using (BuildUp dbcontext = new BuildUp())
                {
                    var lowNums =
                        from zaposlenici in dbcontext.Zaposleniks
                        where zaposlenici.Lozinka == txtLozinka.Text && zaposlenici.KorisnickoIme == txtKorisnickoIme.Text
                        select zaposlenici;       

                    foreach (var zaposlenik in lowNums) 
                    {
                        pronadjen = true; 
                    }
                }
                if (pronadjen == true)
                {
                    frmGlavnaForma glavna_forma = new frmGlavnaForma();
                    this.Hide();
                    txtKorisnickoIme.Text = "";
                    txtLozinka.Text = "";
                    glavna_forma.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Krivi podaci za login!");
                }
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}

