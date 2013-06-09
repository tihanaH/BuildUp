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
        }

        private void txtLozinka_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnLogin_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmGlavnaForma GlavnaForma = new frmGlavnaForma();
            GlavnaForma.ShowDialog();
        }
    }
}
