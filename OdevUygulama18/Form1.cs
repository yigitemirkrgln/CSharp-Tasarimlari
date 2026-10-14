namespace OdevUygulama18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSorgula_Click(object sender, EventArgs e)
        {
            byte yas;
            yas=Convert.ToByte(txtYas.Text);
            if (yas>17)
            {
                MessageBox.Show("Ehliyet Alabilir");
            }
            else
            {
                MessageBox.Show("Ehliyet Alamaz");
            }
        }
    }
}
