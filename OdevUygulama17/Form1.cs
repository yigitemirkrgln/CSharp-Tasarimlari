namespace OdevUygulama17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSonucuGoster_Click(object sender, EventArgs e)
        {
            byte skor1, skor2;
            skor1 = 4;
            skor2 = 1;
            if (skor1 > skor2)
            {
                MessageBox.Show("Birinci Takým Kazandý");
            }
        }
    }
}
