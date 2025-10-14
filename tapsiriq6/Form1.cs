namespace tapsiriq6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string muddet = maskedTextBox1.Text;
            string qrup = textBox1.Text;
            string qalanMuddet = textBox2.Text;

            if (string.IsNullOrWhiteSpace(muddet) || string.IsNullOrWhiteSpace(qrup))
            {
                MessageBox.Show("Zəhmət olmasa bütün xanaları doldurun!");
                return;
            }

            MessageBox.Show($"Rezerv olundu!\nMüddət: {muddet}\nQrup: {qrup}\nQalan müddət: {qalanMuddet}");
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string muddet = maskedTextBox2.Text;
            string qrup = textBox3.Text;
            string qalanMuddet = textBox4.Text;

            if (string.IsNullOrWhiteSpace(muddet) || string.IsNullOrWhiteSpace(qrup))
            {
                MessageBox.Show("Zəhmət olmasa bütün xanaları doldurun!");
                return;
            }

            MessageBox.Show($"Rezerv olundu!\nMüddət: {muddet}\nQrup: {qrup}\nQalan müddət: {qalanMuddet}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string muddet = maskedTextBox3.Text;
            string qrup = textBox5.Text;
            string qalanMuddet = textBox6.Text;

            if (string.IsNullOrWhiteSpace(muddet) || string.IsNullOrWhiteSpace(qrup))
            {
                MessageBox.Show("Zəhmət olmasa bütün xanaları doldurun!");
                return;
            }

            MessageBox.Show($"Rezerv olundu!\nMüddət: {muddet}\nQrup: {qrup}\nQalan müddət: {qalanMuddet}");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string muddet = maskedTextBox4.Text;
            string qrup = textBox7.Text;
            string qalanMuddet = textBox8.Text;

            if (string.IsNullOrWhiteSpace(muddet) || string.IsNullOrWhiteSpace(qrup))
            {
                MessageBox.Show("Zəhmət olmasa bütün xanaları doldurun!");
                return;
            }

            MessageBox.Show($"Rezerv olundu!\nMüddət: {muddet}\nQrup: {qrup}\nQalan müddət: {qalanMuddet}");
        }

    }
}
