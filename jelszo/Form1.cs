using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace jelszo
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length >= 8 && textBox1.Text.Any(char.IsLetterOrDigit))
            {

               
                MessageBox.Show("A jelszó megfelelően erős!");
                
            }
            else
            {
                textBox1.BackColor = Color.Red;
                MessageBox.Show("A jelszó gyenge, kérem próbálja újra!");
                textBox1.BackColor = Color.White;

                
            }


            if (textBox2.Text==(textBox1.Text)) {

                MessageBox.Show("A jelszavak megegyzenek!");
            
            }
            else
            {
                MessageBox.Show("A jelszavak nem egyeznek, kérem próbálja újra!");
            }


        }
    }
}
