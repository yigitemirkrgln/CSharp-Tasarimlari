using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OdevUygulama47
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSorgula_Click(object sender, EventArgs e)
        {
            string ad = txtSorgulaIsim.Text;

            for (int i = 0; i < lbMusteriler.Items.Count; i++)
            {
                if (lbMusteriler.Items[i].ToString() == ad)
                {
                    MessageBox.Show(lbMusteriler.Items[i].ToString() + " Adlı Müşteri Bulundu!", "SORGULAMA SONUCU", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
            }
        }
    }
}
