
namespace Hafta9Ödev9
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

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Text = " ";
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox2.Text = " "; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double first_row = Convert.ToDouble(textBox1.Text);
                double second_row = Convert.ToDouble(textBox2.Text);
               
                double result = first_row + second_row;
                string result2 = result.ToString();
                sonuc.Text = result2;
                
            }
            catch (Exception)
            {
                MessageBox.Show("You entered the wrong character! Please enter a number.");
                

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double first_row = Convert.ToDouble(textBox1.Text);
                double second_row = Convert.ToDouble(textBox2.Text);

                double result = first_row - second_row;
                string result2 = result.ToString();
                sonuc.Text = result2;

            }
            catch (Exception)
            {
                MessageBox.Show("You entered the wrong character! Please enter a number.");


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double first_row = Convert.ToDouble(textBox1.Text);
                double second_row = Convert.ToDouble(textBox2.Text);

                double result = first_row * second_row;
                string result2 = result.ToString();
                sonuc.Text = result2;

            }
            catch (Exception)
            {
                MessageBox.Show("You entered the wrong character! Please enter a number.");


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                double first_row = Convert.ToDouble(textBox1.Text);
                double second_row = Convert.ToDouble(textBox2.Text);

                double result = first_row / second_row;
                string result2 = result.ToString();
                sonuc.Text = result2;

            }
            catch (Exception)
            {
                MessageBox.Show("You entered the wrong character! Please enter a number.");


            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.LightGreen;
            
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor= Color.LightGray;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.LightGreen;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.LightGray;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.BackColor = Color.LightGreen;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.LightGray;
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            button4.BackColor = Color.LightGreen;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.LightGray;
        }

        
    }
}