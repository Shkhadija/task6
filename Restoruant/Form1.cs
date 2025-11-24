namespace Restoruant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double total = 0;
        private void button4_Click(object sender, EventArgs e)
        {

            double b = Convert.ToDouble(textBox2.Text);
            if (total < b)
            {
                label1.Text = (b - total).ToString() + " Azn";

            }
            else
            {
                label1.Text = "Xəta baş verdi";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Burger - 4.3 Azn");
            total += 4.3;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Toyuq - 8.7 Azn");
            total += 8.7;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("HotDog - 2.5 Azn");
            total += 2.5;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Bud səbəti - 12.9 Azn");
            total += 12.9;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Pizza - 16 Azn");
            total += 16;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Xaş - 6 Azn");
            total += 6;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Dolma - 4.1 Azn");
            total += 4.1;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Kola - 2.3 Azn");
            total += 2.3;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Limonad - 1.8 Azn");
            total += 1.8;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Tort - 5 Azn");
            total += 5;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Qəhvə - 3.2 Azn");
            total += 3.2;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Çay - 1.4 Azn");
            total += 1.4;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = total.ToString() + " Azn";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox1.Clear();
            total = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Silinsinmi?", "Diqqət", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                switch (listBox1.SelectedItem)
                {
                    case "Burger - 4.3 Azn":
                        total -= 4.3;
                        break;
                    case "Toyuq - 8.7 Azn":
                        total -= 8.7;
                        break;
                    case "HotDog - 2.5 Azn":
                        total -= 2.5;
                        break;
                    case "Bud səbəti - 12.9 Azn":
                        total -= 12.9;
                        break;
                    case "Pizza - 16 Azn":
                        total -= 16;
                        break;
                    case "Xaş - 6 Azn":
                        total -= 6;
                        break;
                    case "Dolma - 4.1 Azn":
                        total -= 4.1;
                        break;
                    case "Kola - 2.3 Azn":
                        total -= 2.3;
                        break;
                    case "Limonad - 1.8 Azn":
                        total -= 1.8;
                        break;
                    case "Tort - 5 Azn":
                        total -= 5;
                        break;
                    case "Qəhvə - 3.2 Azn":
                        total -= 3.2;
                        break;
                    case "Çay - 1.4 Azn":
                        total -= 1.4;
                        break;
                }
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            label4.Text=Convert.ToString(i);
            if (i == 60)
            {
                Close();
            }
        }
    }
}
