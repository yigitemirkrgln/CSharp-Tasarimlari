namespace OdevUygulama19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            byte sayi1, sayi2;
            sayi1 = Convert.ToByte(txtSayi1.Text);
            sayi2 = Convert.ToByte(txtSayi2.Text);

            if (sayi1 > sayi2)
            {
                MessageBox.Show("1.Sayý 2.Sayýdan Büyüktür");
            }
            else if (sayi1 < sayi2)
            {
                MessageBox.Show("2.Sayý 1.Sayýdan Büyüktür");
            }
            else if (sayi1 == sayi2)
            {
                MessageBox.Show("Sayýlar Birbirine Eþittir.");
            }
        }
    }
}
