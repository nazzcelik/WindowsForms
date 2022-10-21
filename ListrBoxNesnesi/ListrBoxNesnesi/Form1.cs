namespace ListrBoxNesnesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ListBox Count Deðeri: " + listBox1.Items.Count.ToString());
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            string gun = txt_degerGir.Text;
            listBox1.Items.Add(gun);

        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            string silinecekGun = listBox1.SelectedItem.ToString();
            listBox1.Items.Remove(silinecekGun);

            // string silinecekGun2 = listBox1.Items[listBox1.SelectedIndex].ToString();
            // listBox1.Items.Remove(silinecekGun2);
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            MessageBox.Show("ListBox Temizlendi.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             
            listBox1.Items.Add("Cuma");
            listBox1.Items.Add("Cumartesi");
        }
    }
}