namespace DragonProject
{
    // References for images used:

    // Deviant Art. 2023. The black dragon. [Online] Available at: https://www.deviantart.com/punkerlazar/art/The-black-dragon-952993936 [Accessed 02 April 2024] //
    // Playground AI. s.a. [Online] Available at: https://playground.com/search?q=close+up+of+large+ice+dragon [Accessed 02 April 2024]. //
    // Red Bubble, Boradway Art. s.a. Look into the dragons eyes. [Online]. Available at: https://www.redbubble.com/shop/ap/136232585 [Accessed 02 April 2024]. //
    // Virag Fekete. 2021. Hana Kuro. [Online]. Available at: https://www.artstation.com/artwork/rAkG1G [Accessed 02 April 2024]. //
    // We Heart it. 2013. Starry Background. [Online]. Available at: http://weheartit.com/entry/69663068 [Accessed 02 April 2024].//


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Show();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox2.Show();
            pictureBox1.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox3.Show();
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox4.Hide();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox4.Show();
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox5.Show();
            pictureBox6.Hide();
            pictureBox7.Hide();
            pictureBox8.Hide();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox6.Show();
            pictureBox5.Hide();
            pictureBox7.Hide();
            pictureBox8.Hide();
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox7.Show();
            pictureBox5.Hide();
            pictureBox6.Hide();
            pictureBox8.Hide();
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox8.Show();
            pictureBox5.Hide();
            pictureBox6.Hide();
            pictureBox7.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 gameForm = new Form2();
            gameForm.Show();
        }
    }
}
