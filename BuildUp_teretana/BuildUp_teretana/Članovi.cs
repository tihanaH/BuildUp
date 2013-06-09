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
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDodajClan_Click(object sender, EventArgs e)
        {
            FrmDodajČlana FormaDodajClana = new FrmDodajČlana();
            FormaDodajClana.ShowDialog();
        }

        private void btnIzmjeniClan_Click(object sender, EventArgs e)
        {
            FrmIzmjeni FormaIzmjeni = new FrmIzmjeni();
            FormaIzmjeni.ShowDialog();
        }

        private void btnEvidencija_Click(object sender, EventArgs e)
        {
            FrmEvidencija FormaEvidencija = new FrmEvidencija();
            FormaEvidencija.ShowDialog();
        }

        private void btnDodajMjestoVjezbanjaClan_Click(object sender, EventArgs e)
        {
            FrmDodajČlanuMjestoVježbanja FormaDodajClanuMjestoVjezbanja = new FrmDodajČlanuMjestoVježbanja();
            FormaDodajClanuMjestoVjezbanja.ShowDialog();
        }
    }
}
