using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KareAlanCevreClass.Sınıflar;

namespace KareAlanCevreClass
{
    public partial class Anaform : Form
    {
        public Anaform()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDaire_Click(object sender, EventArgs e)
        { 
            frmDaire daire = new frmDaire();
            daire.Show();
            this.Hide();
        }

        private void btnKare_Click(object sender, EventArgs e)
        {
            frmKare kare = new frmKare();
            kare.Show();
            this.Hide();
        }

        private void btnUcgenPrizma_Click(object sender, EventArgs e)
        {
            frmUcgenPrizma ucgenPrizma = new frmUcgenPrizma();
            ucgenPrizma.Show();
            this.Hide();
        }

        private void btnDikdortgen_Click(object sender, EventArgs e)
        {
            frmDikdortgen dikdortgen = new frmDikdortgen();
            dikdortgen.Show();
            this.Hide();
        }

        private void btnKup_Click(object sender, EventArgs e)
        {
            frmKup kup = new frmKup();
            kup.Show();
            this.Hide();
        }

        private void btnDikdortgenPrizma_Click(object sender, EventArgs e)
        {
            frmDikdortgenPrizma dikdortgenPrizma = new frmDikdortgenPrizma();
            dikdortgenPrizma.Show();
            this.Hide();
        }

        private void btnUcgen_Click(object sender, EventArgs e)
        {
            frmUcgen ucgen = new frmUcgen();
            ucgen.Show();
            this.Hide();
        }
    }
}
