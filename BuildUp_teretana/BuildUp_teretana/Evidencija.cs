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
                 if (string.Compare(txtPreostaliBrojDolazaka.Text, "2") == 0)
                 {
                 try
                 {
                     var fromAddress = new MailAddress("buildupteretana@gmail.com", "BuildUp teretana");
                     Clan clan;
                     using (BuildUp dbcontext=new BuildUp())
                     {
                         clan = dbcontext.Clans.FirstOrDefault(jedan_clan=> jedan_clan.BrojIskaznice == int.Parse(brojiskaznice));
                     }
                     var toAddress = new MailAddress(clan.Email, clan.Prezime+" "+clan.Ime);
                     const string fromPassword = "piprojekt";
                     const string subject= "Još samo jedan dolazak!";
                     const string body= "Imate dostupan još samo jedan dolazak u teretanu ovog mjeseca!";

                     var smtp = new SmtpClient
                     {
                         Host= "smtp.gmail.com",
                         Port=587,
                         EnableSsl = true,
                         DeliveryMethod = SmtpDeliveryMethod.Network,
                         UseDefaultCredentials = false,
                         Credentials = new NetworkCredential("buildupteretana@gmail.com", fromPassword)
                     };
                     using (var message = new MailMessage(fromAddress, toAddress)
                     {
                         Subject = subject,
                         Body=body
                     })
                     {
                         smtp.Send(message);
                     }
                 }
                 catch
                 {

                 }
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
