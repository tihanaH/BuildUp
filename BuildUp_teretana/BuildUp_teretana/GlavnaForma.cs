using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Threading;
namespace BuildUp_teretana
{
    public partial class frmGlavnaForma : Form
    {
        public frmGlavnaForma()
        {
            InitializeComponent();
            //provjeri_izvjesca();
            Thread oThread= new Thread(new ThreadStart(provjeri_izvjesca));
            oThread.Start();
        }

        private void provjeri_izvjesca()
        {
            using (BuildUp dbcontext = new BuildUp())
            {
                bool poslano = false;
                if (DateTime.Now.Month == 1)
                {
                    var izvjestaj = from izvjesce in dbcontext.Obavljeni_izvještajis
                                    where izvjesce.Mjesec == (12).ToString() && izvjesce.Godina == (DateTime.Now.Year - 1).ToString()
                                    select izvjesce;
                    foreach (var izvjesce in izvjestaj)
                    {
                        if (izvjesce.Poslano == false)
                        {

                        }
                        else
                        {
                            poslano = true;
                        }
                    }
                }
                else
                {
                    var izvjestaj = from izvjesce in dbcontext.Obavljeni_izvještajis
                                    where izvjesce.Mjesec == (DateTime.Now.Month - 1).ToString() && izvjesce.Godina == DateTime.Now.Year.ToString()
                                    select izvjesce;
                    foreach (var izvjesce in izvjestaj)
                    {
                        if (izvjesce.Poslano == false)
                        {

                        }
                        else
                        {
                            poslano = true;
                        }
                    }
                }
                if (poslano == true)
                {

                }
                else
                {
                    Obavljeni_izvještaji ovaj_mjesec = new Obavljeni_izvještaji();
                    ovaj_mjesec.Poslano = false;
                    ovaj_mjesec.Mjesec = DateTime.Now.Month.ToString();
                    ovaj_mjesec.Godina = DateTime.Now.Year.ToString();
                    using (BuildUp dbontext = new BuildUp())
                    {
                        Obavljeni_izvještaji proba = dbcontext.Obavljeni_izvještajis.FirstOrDefault(obavljeni => obavljeni.Mjesec == DateTime.Now.Month.ToString() && obavljeni.Godina == DateTime.Now.Year.ToString());
                        if (proba == null)
                        {
                            dbcontext.Add(ovaj_mjesec);
                        }
                        dbcontext.SaveChanges();
                    }
                    List<Clan> lista = dohvati_clanove();
                    foreach (var clan in lista)
                    {
                        if (DateTime.Now.Month == 1)
                        {
                            var prosli_mjesec = from izvjesce in dbcontext.Izvjesces
                                                where izvjesce.BrojIskaznice == clan.BrojIskaznice && izvjesce.Mjesec == 12.ToString()
                                                select izvjesce;
                            var pretprosli_mjesec = from izvjesce in dbcontext.Izvjesces
                                                    where izvjesce.BrojIskaznice == clan.BrojIskaznice && izvjesce.Mjesec == 11.ToString()
                                                    select izvjesce;
                            bool pretprosli = false;
                            foreach (var pret in pretprosli_mjesec)
                            {
                                pretprosli = true;
                            }
                            if (pretprosli == false)
                            {
                                //posalji izvjestaj samo za prosli
                                posalji_samo_za_prosli(dbcontext, clan, 12, DateTime.Now.Year - 1);
                            }
                            else
                            {
                                //usporedi prosli i pretprosli
                                Prosli_pretprosli_1_mjesec(dbcontext, clan, 12, 11, DateTime.Now.Year - 1);
                            }
                        }
                        else
                        {
                            var prosli_mjesec = from izvjesce in dbcontext.Izvjesces
                                                where izvjesce.BrojIskaznice == clan.BrojIskaznice && izvjesce.Mjesec == (DateTime.Now.Month - 1).ToString()
                                                select izvjesce;
                            //Obavljeni_izvještaji pret;
                            bool pretprosli = false;
                            if (DateTime.Now.Month == 2)
                            {
                                var pretprosli_mjesec = from izvjesce in dbcontext.Izvjesces
                                                        where izvjesce.BrojIskaznice == clan.BrojIskaznice && izvjesce.Mjesec == 12.ToString()
                                                        select izvjesce;
                                foreach (var pretpr in pretprosli_mjesec)
                                {
                                    pretprosli = true;
                                    //pret=pretpr;
                                }
                            }
                            else
                            {
                                var pretprosli_mjesec = from izvjesce in dbcontext.Izvjesces
                                                        where izvjesce.BrojIskaznice == clan.BrojIskaznice && izvjesce.Mjesec == (DateTime.Now.Month - 2).ToString()
                                                        select izvjesce;
                                foreach (var pretpr in pretprosli_mjesec)
                                {
                                    pretprosli = true;
                                    //pret=pretpr;
                                }
                            }
                            if (pretprosli == false)
                            {
                                //posalji izvjestaj samo za prosli
                                posalji_samo_za_prosli(dbcontext, clan, DateTime.Now.Month - 1, DateTime.Now.Year);
                            }
                            else
                            {
                                if (DateTime.Now.Month == 2)
                                {
                                    Prosli_pretprosli_1_mjesec(dbcontext, clan, 1, 12, DateTime.Now.Year - 1);
                                }
                                else
                                {
                                    Prosli_pretprosli_1_mjesec(dbcontext, clan, DateTime.Now.Month - 1, DateTime.Now.Month - 2, DateTime.Now.Year);
                                }
                            }
                        }
                        var vrijeme_ovaj_mjesec =
                            from vrijeme in dbcontext.VrijemeNaSpravis
                            where vrijeme.BrojIskaznice == clan.BrojIskaznice
                            select vrijeme;
                        foreach (var update in vrijeme_ovaj_mjesec)
                        {
                            update.Vrijeme = 0;
                        }

                        if (DateTime.Now.Month == 1)
                        {
                        }
                        else
                        {
                            Clanarina clanarin = dbcontext.Clanarinas.FirstOrDefault(c1 => c1.BrojIskaznice == clan.BrojIskaznice);
                            if (clanarin.Vrsta == 'G')
                            {
                                Izvjesce izvjesce_novo = dbcontext.Izvjesces.FirstOrDefault(izvjesc => izvjesc.BrojIskaznice == clan.BrojIskaznice && izvjesc.Mjesec == (DateTime.Now.Month - 1).ToString() && izvjesc.Godina == (DateTime.Now.Year).ToString());
                                Izvjesce novo_izvjesce = new Izvjesce();
                                novo_izvjesce.Godina = DateTime.Now.Year.ToString();
                                novo_izvjesce.Mjesec = DateTime.Now.Month.ToString();
                                novo_izvjesce.Biceps = izvjesce_novo.Biceps;
                                novo_izvjesce.BMI = izvjesce_novo.BMI;
                                novo_izvjesce.BrojIskaznice = izvjesce_novo.BrojIskaznice;
                                novo_izvjesce.List = izvjesce_novo.List;
                                novo_izvjesce.MasnoTkvio = izvjesce_novo.MasnoTkvio;
                                novo_izvjesce.ObujamBokova = izvjesce_novo.ObujamBokova;
                                novo_izvjesce.ObujamPrsa = izvjesce_novo.ObujamPrsa;
                                novo_izvjesce.ObujamStruka = izvjesce_novo.ObujamStruka;
                                novo_izvjesce.PotrosnjaKalorija = izvjesce_novo.PotrosnjaKalorija;
                                novo_izvjesce.Tezina = izvjesce_novo.Tezina;

                                dbcontext.Add(novo_izvjesce);
                                dbcontext.SaveChanges();
                            }
                            else
                            {
                            }
                        }
                        if (DateTime.Now.Month == 1)
                        {
                            var izvj = from izvjesce in dbcontext.Obavljeni_izvještajis
                                       where izvjesce.Mjesec == (12).ToString() && izvjesce.Godina == DateTime.Now.Year.ToString()
                                       select izvjesce;
                            foreach (var izvjesce in izvj)
                            {
                                izvjesce.Poslano = true;
                            }
                        }
                        else
                        {
                            var izvj = from izvjesce in dbcontext.Obavljeni_izvještajis
                                       where izvjesce.Mjesec == (DateTime.Now.Month - 1).ToString() && izvjesce.Godina == DateTime.Now.Year.ToString()
                                       select izvjesce;
                            foreach (var izvjesce in izvj)
                            {
                                izvjesce.Poslano = true;
                            }
                        }
                        dbcontext.SaveChanges();
                    }
                }
            }
            //MessageBox.Show("Napravio sam backup");
        }

        private static void Prosli_pretprosli_1_mjesec(BuildUp dbcontext, Clan clan,int prosli, int pretprosli,int godina)
        {
            try
            {
                var fromAddress = new MailAddress("buildupteretana@gmail.com", "BuildUp teretana");
                Clan clan1;
                using (BuildUp dbcontext1 = new BuildUp())
                {
                    clan1 = dbcontext.Clans.FirstOrDefault(jedan_clan => jedan_clan.BrojIskaznice == clan.BrojIskaznice);
                }
                var toAddress = new MailAddress(clan1.Email, clan1.Prezime + " " + clan1.Ime);
                const string fromPassword = "piprojekt";
                string subject = "Izvještaj za " + prosli + ". mjesec" + godina + ". godine";
                string body = "Sprave\n";
                body += "--------------------\n";
                var sve_sprave_ovaj_mjesec =
                    from vr_spr in dbcontext.VrijemeNaSpravis
                    join spr in dbcontext.Spravas
                        on vr_spr.ID_sprave equals spr.ID_sprave
                    where vr_spr.BrojIskaznice == clan.BrojIskaznice
                    select new
                    {
                        naziv = spr.Naziv,
                        ukupne_kalorije = spr.Prosjecna_potrosnja_kalorija * vr_spr.Vrijeme,
                    };
                int sve_kalorije = 0;
                foreach (var sve in sve_sprave_ovaj_mjesec)
                {
                    body += sve.naziv + "=" + sve.ukupne_kalorije.ToString() + "\n";
                    sve_kalorije += int.Parse(sve.ukupne_kalorije.ToString());
                }
                body += "---------------------\n";
                //tezina,prsa,struk,bokovi,kalorije,masnotkivo,bmi,list,bedro,biceps
                Izvjesce pretprosli_mjesec2 = dbcontext.Izvjesces.FirstOrDefault(izvj => izvj.Mjesec == pretprosli.ToString() && izvj.Godina==godina.ToString()&&izvj.BrojIskaznice == clan1.BrojIskaznice);
                Izvjesce prosli_mjesec2 = dbcontext.Izvjesces.FirstOrDefault(izvj => izvj.Mjesec == prosli.ToString() && izvj.Godina==godina.ToString() && izvj.BrojIskaznice == clan1.BrojIskaznice);
                body += (DateTime.Now.Month - 2).ToString() + " mj tezina:     " + pretprosli_mjesec2.Tezina + " ===>\t " + (DateTime.Now.Month - 1).ToString() + " mj tezina:     " + prosli_mjesec2.Tezina + " ----> \t Razlika= " + (pretprosli_mjesec2.Tezina - prosli_mjesec2.Tezina) + "\n\n";
                body += (DateTime.Now.Month - 2).ToString() + " mj biceps:     " + pretprosli_mjesec2.Biceps + " ===>\t " + (DateTime.Now.Month - 1).ToString() + " mj biceps:     " + prosli_mjesec2.Biceps + " ----> \t Razlika= " + (pretprosli_mjesec2.Biceps - prosli_mjesec2.Biceps) + "\n\n";
                body += (DateTime.Now.Month - 2).ToString() + " mj prsa:       " + pretprosli_mjesec2.ObujamPrsa + " ===>\t " + (DateTime.Now.Month - 1).ToString() + " mj prsa:       " + prosli_mjesec2.ObujamPrsa + " ----> \t Razlika= " + (pretprosli_mjesec2.ObujamPrsa - prosli_mjesec2.ObujamPrsa) + "\n\n";
                body += (DateTime.Now.Month - 2).ToString() + " mj struk:      " + pretprosli_mjesec2.ObujamStruka + " ===>\t " + (DateTime.Now.Month - 1).ToString() + " mj struk:      " + prosli_mjesec2.ObujamStruka + " ----> \t Razlika= " + (pretprosli_mjesec2.ObujamStruka - prosli_mjesec2.ObujamStruka) + "\n\n";
                body += (DateTime.Now.Month - 2).ToString() + " mj bokovi:     " + pretprosli_mjesec2.ObujamBokova + " ===>\t " + (DateTime.Now.Month - 1).ToString() + " mj bokovi:     " + prosli_mjesec2.ObujamBokova + " ----> \t Razlika= " + (pretprosli_mjesec2.ObujamBokova - prosli_mjesec2.ObujamBokova) + "\n\n";
                body += (DateTime.Now.Month - 2).ToString() + " mj kalorije:   " + pretprosli_mjesec2.PotrosnjaKalorija + " ===>\t " + (DateTime.Now.Month - 1).ToString() + " mj kalorije:   " + prosli_mjesec2.PotrosnjaKalorija + " ----> \t Razlika= " + (pretprosli_mjesec2.PotrosnjaKalorija - prosli_mjesec2.PotrosnjaKalorija) + "\n\n";
                body += (DateTime.Now.Month - 2).ToString() + " mj masnotkivo: " + pretprosli_mjesec2.MasnoTkvio + " ===>\t " + (DateTime.Now.Month - 1).ToString() + " mj masnotkivo: " + prosli_mjesec2.MasnoTkvio + " ----> \t Razlika= " + (pretprosli_mjesec2.MasnoTkvio - prosli_mjesec2.MasnoTkvio) + "\n\n";
                body += (DateTime.Now.Month - 2).ToString() + " mj bmi:        " + pretprosli_mjesec2.BMI + " ===>\t " + (DateTime.Now.Month - 1).ToString() + " mj bmi:        " + prosli_mjesec2.BMI + " ----> \t Razlika= " + (pretprosli_mjesec2.BMI - prosli_mjesec2.BMI) + "\n\n";
                body += (DateTime.Now.Month - 2).ToString() + " mj list:       " + pretprosli_mjesec2.List + " ===>\t " + (DateTime.Now.Month - 1).ToString() + " mj list:       " + prosli_mjesec2.List + " ----> \t Razlika= " + (pretprosli_mjesec2.List - prosli_mjesec2.List) + "\n\n";
                body += (DateTime.Now.Month - 2).ToString() + " mj bedro:      " + pretprosli_mjesec2.Bedro + " ===>\t " + (DateTime.Now.Month - 1).ToString() + " mj bedro:      " + prosli_mjesec2.Bedro + " ----> \t Razlika= " + (pretprosli_mjesec2.Bedro - prosli_mjesec2.Bedro) + "\n\n";
                body += "-----------------------------------------------------------------------------------------\n";
                body += "Kalorije za: " + (DateTime.Now.Month - 2).ToString() + " mj: " + pretprosli_mjesec2.PotrosnjaKalorija + ", a za prošli: " + sve_kalorije.ToString() + ", razlika= " + (pretprosli_mjesec2.PotrosnjaKalorija - sve_kalorije).ToString() + "\n";
                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential("buildupteretana@gmail.com", fromPassword)
                };
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                }
            }
            catch
            {

            }
        }

        private static void posalji_samo_za_prosli(BuildUp dbcontext, Clan clan,int prosli,int godina)
        {
            try
            {
                var fromAddress = new MailAddress("buildupteretana@gmail.com", "BuildUp teretana");
                Clan clan1;
                using (BuildUp dbcontext1 = new BuildUp())
                {
                    clan1 = dbcontext.Clans.FirstOrDefault(jedan_clan => jedan_clan.BrojIskaznice == clan.BrojIskaznice);
                }
                var toAddress = new MailAddress(clan1.Email, clan1.Prezime + " " + clan1.Ime);
                const string fromPassword = "piprojekt";
                string subject = "Izvještaj za "+prosli+". mjesec"+godina+". godine";
                string body = "Sprave\n";
                body += "--------------------\n";
                var sve_sprave_ovaj_mjesec =
                    from vr_spr in dbcontext.VrijemeNaSpravis
                    join spr in dbcontext.Spravas
                        on vr_spr.ID_sprave equals spr.ID_sprave
                    where vr_spr.BrojIskaznice == clan.BrojIskaznice
                    select new
                    {
                        naziv = spr.Naziv,
                        ukupne_kalorije = spr.Prosjecna_potrosnja_kalorija * vr_spr.Vrijeme,
                    };
                foreach (var sve in sve_sprave_ovaj_mjesec)
                {
                    body += sve.naziv + "=" + sve.ukupne_kalorije.ToString() + "\n";
                }

                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential("buildupteretana@gmail.com", fromPassword)
                };
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                }
            }
            catch
            {

            }
        }

        private List<Clan> dohvati_clanove()
        {
            using (BuildUp dbcontext = new BuildUp())
            {
                if (DateTime.Now.Month == 1)
                {
                    var q =
                        from clanovi in dbcontext.Clans
                        join clanarina in dbcontext.Clanarinas on clanovi.BrojIskaznice equals clanarina.BrojIskaznice
                        where (clanarina.Vrsta == 'G' && clanarina.Godina_uplate == (DateTime.Now.Year-1).ToString())
                        || (clanarina.Vrsta == 'M' && clanarina.Mjesec_uplate == (12).ToString())


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
                else
                {
                    var q =
                        from clanovi in dbcontext.Clans
                        join clanarina in dbcontext.Clanarinas on clanovi.BrojIskaznice equals clanarina.BrojIskaznice
                        where (clanarina.Vrsta == 'G' && clanarina.Godina_uplate == DateTime.Now.Year.ToString())
                        || (clanarina.Vrsta == 'M' && clanarina.Mjesec_uplate == (DateTime.Now.Month - 1).ToString())


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
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClan_Click(object sender, EventArgs e)
        {
            FrmČlanovi clanovi = new FrmČlanovi();
            this.Hide();
            clanovi.ShowDialog();
            this.Show();
        }
    }
}
