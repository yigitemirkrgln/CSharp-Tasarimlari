namespace OdevUygulama20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSorgula_Click(object sender, EventArgs e)
        {
            int sayi;
            sayi = Convert.ToInt32(txtSayi.Text);
            if (sayi % 2 == 0 )
            {
                MessageBox.Show("Sayý Çifttir.");
            }
             else if (sayi % 2 == 1 )
            {
                MessageBox.Show("Sayý Tektir.");
            }
        }
    }
}
