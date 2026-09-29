using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OdevSayfa35SiraSizde
{
    public partial class Form1 : Form
    {
        int sayi1 = 100;
        string deger;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDegerGoster_Click(object sender, EventArgs e)
        {
            MessageBox.Show(deger = sayi1.ToString());
        }
    }
}
