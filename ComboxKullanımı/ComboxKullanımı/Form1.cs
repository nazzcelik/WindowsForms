namespace ComboxKullanımı
{
    public partial class combo_gunler : Form
    {
        public combo_gunler()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            comboBox1.Items.Add("Cumartesi");
            comboBox1.Items.Add("Pazar");
            
            MessageBox.Show("Gün Seçme Ekranına Hoş Geldiniz");
            /*
            comboBox1.Items.Remove("Pazartesi"); // Girilen değeri adına göre kaldırıyor.

            comboBox1.Items.RemoveAt(3); // Girilen değeri index numarasına göre kaldırıyor.
            */
        }

        private void btn_gunSec_Click(object sender, EventArgs e)
        {
            // selectedItem - selectedIndex 
            string secilenGun=comboBox1.SelectedItem.ToString();
            int secilenGunIndex=comboBox1.SelectedIndex;
            MessageBox.Show("Seçtiğiniz Gün: " + secilenGun +" "+Environment.NewLine+"Index Değeri: "+secilenGunIndex);


        }
    }
}