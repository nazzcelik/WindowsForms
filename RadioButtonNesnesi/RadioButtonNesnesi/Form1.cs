namespace RadioButtonNesnesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad, soyad, cinsiyet = " ";
            ad = txt_ad.Text;
            soyad = txt_soyad.Text;
            if(radio_kadin.Checked)
            {
                cinsiyet = "Kadýn";
            }
            else
            {
                cinsiyet = "Erkek";
            }

            MessageBox.Show("Ad Soyad: " + ad + " " + soyad + "\n" + "Cinsiyet: " + cinsiyet);
        }
    }
}