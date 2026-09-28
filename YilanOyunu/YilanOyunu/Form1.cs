using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YilanOyunu
{
    public partial class Form1 : Form
    {
        List<Point> yilan;
        int sutunAdet, satirAdet, hucreGenisligi, hucreYuksekligi, yonX, yonY, skor;
        Random rnd = new Random();
        Point yem;
        bool yonDegisti = false;

        private void pnlOyun_Paint(object sender, PaintEventArgs e)
        {
            //Yılan Vücudu
            bool basMi = true;
            foreach (Point bogum in yilan)
            {
                HucreBoya(e.Graphics, bogum, basMi ? Brushes.LawnGreen : Brushes.Green);
                basMi = false;
            }

            HucreBoya(e.Graphics, yem, Brushes.Red);
        }

        private void tmrOyun_Tick(object sender, EventArgs e)
        {
            //Hareket Etmesi İçin Timer

            yonDegisti = false;
            Point yeniBas = new Point(yilan[0].X + yonX, yilan[0].Y + yonY);

            // Oyunu Sonlandırma
            if (yeniBas.X >= sutunAdet || yeniBas.X < 0 || yeniBas.Y >= satirAdet || yeniBas.Y < 0 || yilan.Any(bogum => bogum.X == yeniBas.X && bogum.Y == yeniBas.Y) && yeniBas != yilan[yilan.Count -1 ])
            {
                tmrOyun.Stop();
                MessageBox.Show("Oyun Bitti! Skorunuz: " + skor.ToString("000"));   
                OyunuHazirla();
                pnlOyun.Refresh();
                return;
            }

            yilan.Insert(0, yeniBas);

            // Yem Yutma Mekaniği
            if (yeniBas == yem)
            {
                skor++;
                lblSkor.Text = skor.ToString("000");
                YemUret();
            }
            else
            {
                yilan.RemoveAt(yilan.Count - 1);
            }


            pnlOyun.Refresh();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            //Yön Tuşları İle Kontrol

            if (yonDegisti)
                return base.ProcessCmdKey(ref msg, keyData);

            if (keyData == Keys.Up || keyData == Keys.Down || keyData == Keys.Right || keyData == Keys.Left)
                tmrOyun.Start();    
            int x = 0, y = 0;
            if (keyData == Keys.Up)
                y = -1;
            else if (keyData == Keys.Down)
                y = 1;
            else if (keyData == Keys.Right)
                x  = 1;
            else if (keyData == Keys.Left)
                x = -1;

            // Hatalı Yön
            if (yonX != -x && yonY != -y)
            {
                yonX = x;
                yonY = y;
                yonDegisti = true;
            }
            
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void HucreBoya(Graphics graphics, Point bogum, Brush firca )
        {
           int x = bogum.X * hucreGenisligi;
           int y = bogum.Y * hucreYuksekligi;
            graphics.FillRectangle(firca, x, y, hucreGenisligi, hucreYuksekligi);
            graphics.DrawRectangle(Pens.Black, x, y, hucreGenisligi, hucreYuksekligi);

        }

        public Form1()
        {
            //Metodlar
            InitializeComponent();
            OyunuHazirla();
        }

        private void OyunuHazirla()
        {
            //Oyun Mekanikleri
            lblSkor.Text = skor.ToString("000");
            skor = 0;   
            sutunAdet  = 15;
            satirAdet = 15;
            hucreGenisligi = pnlOyun.Width / sutunAdet;
            hucreYuksekligi = pnlOyun.Height / satirAdet;

            int basX = sutunAdet / 2;
            int basY = satirAdet / 2;
            yilan = new List<Point>()
            {
                new Point(basX, basY),
                new Point(basX - 1, basY),
                new Point(basX - 2, basY),
                
            };
            yonX = +1;
            yonY = 0;
            //Yem Oluşturma

            YemUret();
        }

        private void YemUret()
        {
            do
            {
                yem = new Point(rnd.Next(sutunAdet), rnd.Next(satirAdet));
            } while (yilan.Any(bogum => bogum.X == yem.X && bogum.Y == yem.Y)); 

        }

        private void lblBilgi_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
