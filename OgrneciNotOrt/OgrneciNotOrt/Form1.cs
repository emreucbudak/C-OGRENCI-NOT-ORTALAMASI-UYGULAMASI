namespace OgrneciNotOrt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string l;
            int a, b, c, d, g, toplam, ortalama,kontrol;
            a = Convert.ToInt16(textBox2.Text);
            b = Convert.ToInt16(textBox3.Text);
            c = Convert.ToInt16(textBox4.Text);
            d = Convert.ToInt16(textBox5.Text);
            g = Convert.ToInt16(textBox6.Text);
            l = textBox1.Text;
            if (!int.TryParse(l, out kontrol))
            {
                if (a > 0 && b > 0 && c > 0 && d > 0 && g > 0)
                {
                    if (a < 101 && b < 101 && c < 101 && d < 101 && g < 101)
                    {
                        toplam = a + b + c + d + g;
                        ortalama = toplam / 5;
                        listBox1.Items.Add(textBox1.Text + "      Ortalamasý = " + ortalama);
                    }
                    else
                    {
                        MessageBox.Show("Lütfen Geçerli Sayýlar Girin ", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                }
                else
                {
                    MessageBox.Show("Lütfen Geçerli Sayýlar Girin ", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Lütfen Geçerli Bir Ýsim Girin ", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }




        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }
    }
}
