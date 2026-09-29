using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace OdevUygulama11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbLambaAcKapat_CheckedChanged(object sender, EventArgs e)
        {
            bool secim;
            secim = cbLambaAcKapat.Checked; //Checked özelliği True veya False değerleri alır.
            lblTrueFalse.Text = secim.ToString();
        }
    }
}
