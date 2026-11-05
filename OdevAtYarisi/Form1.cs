using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OdevAtYarisi
{
    public partial class Form1 : Form
    {
        private Random rnd;
        public Form1()
        {
            InitializeComponent();
            rnd = new Random();
            timer1.Interval = 50;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pbAt1.Left += rnd.Next(2, 12);
            pbAt2.Left += rnd.Next(2, 12);
            pbAt3.Left += rnd.Next(2, 12);

            int bitisCizgisi = 1140;

            if (pbAt1.Left >= bitisCizgisi)
            {
                timer1.Stop();
                MessageBox.Show("Gülbatur Kazandı!","YARIŞ BİTTİ",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else if (pbAt2.Left >= bitisCizgisi)
            {
                timer1.Stop();
                MessageBox.Show("Yavuzhan Kazandı!", "YARIŞ BİTTİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (pbAt3.Left >= bitisCizgisi)
            {
                timer1.Stop();
                MessageBox.Show("Atılgan Kazandı!", "YARIŞ BİTTİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
