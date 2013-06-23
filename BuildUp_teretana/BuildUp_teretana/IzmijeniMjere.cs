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
    public partial class IzmijeniMjere : Form
    {
        private int broj_iskaznice;
        Izvjesce izvjesce;

        public IzmijeniMjere(int broj_iskaznice)
        {
            InitializeComponent();
            this.broj_iskaznice = broj_iskaznice;
            this.CenterToParent();
            using (BuildUp dbcontext = new BuildUp()) { 
                izvjesce = dbcontext.Izvjesces.FirstOrDefault(izvjesc=>izvjesc.BrojIskaznice == this.broj_iskaznice&&izvjesc.Godina == DateTime.Now.Year.ToString()&&izvjesc.Mjesec == DateTime.Now.Month.ToString());
            }
            txtBedro.Text = izvjesce.Bedro.ToString();
            txtBiceps.Text = izvjesce.Biceps.ToString();
            txtBMI.Text = izvjesce.BMI.ToString();
            txtBokovi.Text = izvjesce.ObujamBokova.ToString();
            txtList.Text = izvjesce.List.ToString();
            txtMasnoTkivo.Text = izvjesce.MasnoTkvio.ToString();
            txtPrsa.Text = izvjesce.ObujamPrsa.ToString();
            txtStruk.Text = izvjesce.ObujamStruka.ToString();
            txtTezina.Text = izvjesce.Tezina.ToString();
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^[0-9]+$");
            if (!regex.IsMatch(txtBedro.Text)||!regex.IsMatch(txtBiceps.Text)||!regex.IsMatch(txtBMI.Text)||!regex.IsMatch(txtBokovi.Text)||!regex.IsMatch(txtList.Text)||!regex.IsMatch(txtMasnoTkivo.Text)||!regex.IsMatch(txtPrsa.Text)||!regex.IsMatch(txtStruk.Text)||!regex.IsMatch(txtTezina.Text)) {
                MessageBox.Show("Ne smije biti slova unutar tekstualnih okvira!");
            }
            else if (txtBedro.Text == "")
            {
                MessageBox.Show("Niste unijeli mjeru bedra!");
            }
            else if (txtBiceps.Text == "")
            {
                MessageBox.Show("Niste unijeli mjeru bicepsa!");
            }
            else if (txtBMI.Text == "")
            {
                MessageBox.Show("Niste unijeli mjeru BMI!");
            }
            else if (txtBokovi.Text == "")
            {
                MessageBox.Show("Niste unijeli mjeru bokova!");
            }
            else if (txtList.Text == "")
            {
                MessageBox.Show("Niste unijeli mjeru lista!");
            }
            else if (txtMasnoTkivo.Text == "")
            {
                MessageBox.Show("Niste unijeli mjeru masnog tkiva!");
            }
            else if (txtPrsa.Text == "")
            {
                MessageBox.Show("Niste unijeli mjeru prsa!");
            }
            else if (txtStruk.Text == "")
            {
                MessageBox.Show("Niste unijeli mjeru struka!");
            }
            else if (txtTezina.Text == "")
            {
                MessageBox.Show("Niste unijeli težinu!");
            }
            else {
                izvjesce.Bedro = int.Parse(txtBedro.Text);
                izvjesce.Biceps = int.Parse(txtBiceps.Text);
                izvjesce.BMI = int.Parse(txtBMI.Text);
                izvjesce.ObujamBokova = int.Parse(txtBokovi.Text);
                izvjesce.List = int.Parse(txtList.Text);
                izvjesce.MasnoTkvio = int.Parse(txtMasnoTkivo.Text);
                izvjesce.ObujamPrsa = int.Parse(txtPrsa.Text);
                izvjesce.ObujamStruka = int.Parse(txtStruk.Text);
                izvjesce.Tezina = int.Parse(txtTezina.Text);
                try
                {
                    using (BuildUp dbcontext = new BuildUp())
                    {
                        dbcontext.AttachCopy(izvjesce);
                        dbcontext.SaveChanges();
                    }
                    MessageBox.Show("Uspješno spremljene promjene!");
                    this.Close();
                }
                catch {
                    MessageBox.Show("Nisu uspješno spremljene promjene!");
                }
            }
        }
    }
}
