namespace CheckBoxNesnesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tutar = 0;
            if (checkBox_cay.Checked)
            {
                tutar += 8;
            }
            if (checkBox_kahve.Checked)
            {
                tutar += 14;
            }
            if (checkBox_hambrgr.Checked)
            {
                tutar += 40;
            }
            if (checkBox_pizza.Checked)
            {
                tutar += 35;
            }

            lbl_tutarDeger.Text = tutar.ToString() + "TL";
        }
    }
}