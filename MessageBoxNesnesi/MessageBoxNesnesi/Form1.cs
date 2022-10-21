namespace MessageBoxNesnesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_cikisYap_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Çýkýþ Yapmak Ýstiyor musunuz? ","Bilgilendirme",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
        }
    }
}