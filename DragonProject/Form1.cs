using System;
using System.Windows.Forms;


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
        // variables
        int currentPlayer;
        string player1Name;
        string player2Name;
        string player1DragName;
        string player2DragName;
        string player1DragonType;
        string player2DragonType;
        int player1Hp;
        int player2Hp;
        int player1Ad;
        int player2Ad;
        int player1Sad;
        int player2Sad;
        int player1Bd;
        int player2Bd;
        bool player1Ready = false;
        bool player2Ready = false;

        // arrays
        string[] P1data = new string[3];
        string[] P2data = new string[3];
        int[] P1values = new int[4];
        int[] P2values = new int[4]; 

        // roll a dice 
        public int randomRoll()
        {
            int[] diceValues = { 1, 2, 3, 4, 5, 6 };

            Random random = new Random();
            int diceValueIndex = random.Next(diceValues.Length);
            int RandomValue = diceValues[diceValueIndex];
            return RandomValue;
        }

        public Form1()
        {
            InitializeComponent();

            button3.Enabled = false; // disables "Start Button"
        }


        // method used to check if both player 2 & 2 have pressed "Save"
        public void checkIfReady()
        {
            if (player1Ready && player2Ready)
            {
                button3.Enabled = true; // if player 1 & 2 have pressed "Save", the "Start Game" button is enabled
            }

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        public static class dragonStats
        {
            // Fire dragon constants (HP, attack damage, special attack damage and block damage
            public const string FIRE_DRAG_NAME = "Fire Dragon"; 
            public const int FIRE_DRAG_HP = 20;
            public const int FIRE_DRAG_AD = 5;
            public const int FIRE_DRAG_SAD = 12;
            public const int FIRE_DRAG_BD = 4;

            // Ice dragon constants(HP, attack damage, special attack damage and block damage
            public const string ICE_DRAG_NAME = "Ice Dragon";
            public const int ICE_DRAG_HP = 30;
            public const int ICE_DRAG_AD = 4;
            public const int ICE_DRAG_SAD = 9;
            public const int ICE_DRAG_BD = 5;

            // Wind dragon constants(HP, attack damage, special attack damage and block damage
            public const string WIND_DRAG_NAME = "Wind Dragon";
            public const int WIND_DRAG_HP = 40;
            public const int WIND_DRAG_AD = 3;
            public const int WIND_DRAG_SAD = 7;
            public const int WIND_DRAG_BD = 5;

            // Earth dragon constants(HP, attack damage, special attack damage and block damage
            public const string EARTH_DRAG_NAME = "Earth Dragon";
            public const int EARTH_DRAG_HP = 50;
            public const int EARTH_DRAG_AD = 2;
            public const int EARTH_DRAG_SAD = 5;
            public const int EARTH_DRAG_BD = 6; 

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // statistics for fire dragon (player 1)
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            player1DragonType = dragonStats.FIRE_DRAG_NAME;
            player1Hp = dragonStats.FIRE_DRAG_HP;
            player1Ad = dragonStats.FIRE_DRAG_AD;
            player1Sad = dragonStats.FIRE_DRAG_BD;
            player1Bd = dragonStats.FIRE_DRAG_BD;

            pictureBox1.Show();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();

        }

        // statistics for ice dragon (player 1)
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            player1DragonType = dragonStats.ICE_DRAG_NAME;
            player1Hp = dragonStats.ICE_DRAG_HP;
            player1Ad = dragonStats.ICE_DRAG_AD;
            player1Sad = dragonStats.ICE_DRAG_SAD;
            player1Bd = dragonStats.ICE_DRAG_BD;

            pictureBox2.Show();
            pictureBox1.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
        }

        // statistics for wind dragon (player 1)
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            player1DragonType = dragonStats.WIND_DRAG_NAME;
            player1Hp = dragonStats.WIND_DRAG_HP;
            player1Ad = dragonStats.WIND_DRAG_AD;
            player1Sad = dragonStats.WIND_DRAG_BD;
            player1Bd = dragonStats.WIND_DRAG_SAD;

            pictureBox3.Show();
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox4.Hide();
        }

        // statistics for earth dragon (player 1)
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            player1DragonType = dragonStats.EARTH_DRAG_NAME;
            player1Hp = dragonStats.EARTH_DRAG_HP;
            player1Ad = dragonStats.EARTH_DRAG_AD;
            player1Sad = dragonStats.EARTH_DRAG_BD;
            player1Bd = dragonStats.EARTH_DRAG_SAD;

            pictureBox4.Show();
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
        }

        // statistics for fire dragon (player 2)
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            player2DragonType = dragonStats.FIRE_DRAG_NAME;
            player2Hp = dragonStats.FIRE_DRAG_HP;
            player2Ad = dragonStats.FIRE_DRAG_AD;
            player2Sad = dragonStats.FIRE_DRAG_BD;
            player2Bd = dragonStats.FIRE_DRAG_SAD;

            pictureBox5.Show();
            pictureBox6.Hide();
            pictureBox7.Hide();
            pictureBox8.Hide();
        }

        // statistics for ice dragon (player 2)
        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            player2DragonType = dragonStats.ICE_DRAG_NAME;
            player2Hp = dragonStats.ICE_DRAG_HP;
            player2Ad = dragonStats.ICE_DRAG_AD;
            player2Sad = dragonStats.ICE_DRAG_BD;
            player2Bd = dragonStats.ICE_DRAG_SAD;

            pictureBox6.Show();
            pictureBox5.Hide();
            pictureBox7.Hide();
            pictureBox8.Hide();
        }

        // statistics for wind dragon (player 2)
        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            player2DragonType = dragonStats.WIND_DRAG_NAME;
            player2Hp = dragonStats.WIND_DRAG_HP;
            player2Ad = dragonStats.WIND_DRAG_AD;
            player2Sad = dragonStats.WIND_DRAG_BD;
            player2Bd = dragonStats.WIND_DRAG_SAD;

            pictureBox7.Show();
            pictureBox5.Hide();
            pictureBox6.Hide();
            pictureBox8.Hide();
        }

        // statistics for earth dragon (player 2)
        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            player2DragonType = dragonStats.EARTH_DRAG_NAME;
            player2Hp = dragonStats.EARTH_DRAG_HP;
            player2Ad = dragonStats.EARTH_DRAG_AD;
            player2Sad = dragonStats.EARTH_DRAG_BD;
            player2Bd = dragonStats.EARTH_DRAG_SAD;

            pictureBox8.Show();
            pictureBox5.Hide();
            pictureBox6.Hide();
            pictureBox7.Hide();
        }

        // when "Start Game" button is pressed, form 1 hides and form 2 is shown
        private void button3_Click(object sender, EventArgs e)
        {
            Form2 gameForm = new Form2(P1data, P1values, P2data, P2values);
            gameForm.Show();



        }

        // this saves all player 1's data and values
        private void button1_Click(object sender, EventArgs e)
        {
            P1data[0] = textBox1.Text;
            P1data[1] = textBox2.Text;
            P1data[2] = player1DragonType;
            P1values[0] = player1Hp;
            P1values[1] = player1Ad;
            P1values[2] = player1Sad;
            P1values[3] = player1Bd;

            player1Ready = true;

            checkIfReady();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        // this saves all player 2's data and values
        private void button2_Click(object sender, EventArgs e)
        {
            P2data[0] = textBox3.Text;
            P2data[1] = textBox4.Text;
            P2data[2] = player2DragonType;
            P2values[0] = player2Hp;
            P2values[1] = player2Ad;
            P2values[2] = player2Sad;
            P2values[3] = player2Bd;

            player2Ready = true;

            checkIfReady();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
