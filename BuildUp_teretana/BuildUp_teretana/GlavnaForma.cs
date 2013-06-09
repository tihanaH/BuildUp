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
    public partial class frmGlavnaForma : Form
    {
        public frmGlavnaForma()
        {
            InitializeComponent();
        }

        private void btnClanovi_Click(object sender, EventArgs e)
        {
             FrmČlanovi FormaClanovi = new FrmČlanovi();
             FormaClanovi.ShowDialog();
        }

        private void btnMjestoVjezbanja_Click(object sender, EventArgs e)
        {
            FrmDodajMjestoVjezbanja DodajMjestoVjezbanja = new FrmDodajMjestoVjezbanja();
            DodajMjestoVjezbanja.ShowDialog();
        }

        private void btnClanarine_Click(object sender, EventArgs e)
        {
            FrmClanarine FormaClanarine = new FrmClanarine();
            FormaClanarine.ShowDialog();
        }
    }
}
