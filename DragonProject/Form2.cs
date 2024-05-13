using System.Media;

namespace DragonProject
{


    public partial class Form2 : Form
    {
        // arrays for each player
        private string[] player1Names;
        private string[] player2Names;
        private int[] player1Stats;
        private int[] player2Stats;

        // string and integar variables
        int player1RanValue;
        int player2RanValue;
        string currentPlayer;
        int playerNumber;
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

        public Form2(string[] P1Names, int[] P1Values, string[] P2Names, int[] P2Values)
        {
            InitializeComponent();

            player1Names = P1Names;
            player2Names = P2Names;
            player1Stats = P1Values;
            player2Stats = P2Values;

            player1RanValue = randomRoll();
            player2RanValue = randomRoll();
        }

        // random number selection from dice
        public int randomRoll() 
        {
            int[] diceValues = { 1, 2, 3, 4, 5, 6 };

            Random random = new Random();
            int diceValueIndex = random.Next(diceValues.Length);
            int RandomValue = diceValues[diceValueIndex];
            return RandomValue;
        }


        // determination of whether player 1 or 2 goes first [using the RandomRoll() method]
        public string takeInitiative()      
        {
            int roll1 = randomRoll();
            int roll2 = randomRoll();

            while (roll1 == roll2)
            {
                roll1 = randomRoll();
                roll2 = randomRoll();
            }
            playerNumber = (roll1 > roll2) ? 1 : 2;

            if (playerNumber == 1)
            {
                currentPlayer = player1Names[0];
            }
            else
            {
                currentPlayer = player2Names[0];
            }
            groupBox5.Text = currentPlayer + "'s turn";
            this.Text = currentPlayer + "'s turn";
            return currentPlayer;

        }


        // what will be displayed on Form 2, according to the player information given
        private void DisplayPlayerInfo() 
        {
            player1Info.Text = player1Names[1] + ", the " + player1Names[2] + "'s turn ";
            player2Info.Text = player2Names[1] + ", the " + player2Names[2] + "'s turn ";
            player1HpDisplay.Text = "HP: " + Convert.ToString(player1Stats[0]);
            player2HpDisplay.Text = "HP: " + Convert.ToString(player2Stats[0]);
            opponent1.Text = "Opponent: " + player2Names[0];
            opponent2.Text = "Opponent: " + player1Names[0];
            opponentDrag1.Text = player2Names[1] + ", the " + player2Names[2];
            opponentDrag2.Text = player1Names[1] + ", the " + player1Names[2];
            oppDragHp1.Text = "HP: " + Convert.ToString(player2Stats[0]);
            oppDragHp2.Text = "HP: " + Convert.ToString(player1Stats[0]);
        }

        // method used when attack button is pressed 
        static void Attack(ref int opponentHp, int attackDamage, string oppDragName, int blockDamage, string dragName, RichTextBox BattleLog, ref bool checkingForBlock)
        {
            if (checkingForBlock)
            {
                int remainingDamages;
                remainingDamages = attackDamage - blockDamage;
                BattleLog.Text += "\n" + dragName + " is inflicting " + blockDamage + " on " + oppDragName + "!";
                checkingForBlock = false;
            } 
           else 
            
            {
                opponentHp -= attackDamage;
                BattleLog.Text += "\n" + dragName + " is attacking " + oppDragName + "! " + oppDragName + " takes " + attackDamage + " damage and is now at " + opponentHp + "HP!";

            }
            

        }

        // method used to differentiate between each player turn
        static void SwitchTurns(string p1Name, string p2Name, ref string currentPlayer, ref RichTextBox BattleLog)
        {
            if (currentPlayer == p1Name)
            {
                currentPlayer = p2Name;
            }

            else if (currentPlayer == p2Name)
            {
                currentPlayer = p1Name;

            }

            BattleLog.Text += "\n" + "Current player: " + currentPlayer;
        }

        // attck button for player 1
        private void button1_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            pictureBox2.Hide();


            Attack(ref player2Stats[0], player1Stats[1], player2Names[0], player2Stats[3], player1Names[0], richTextBox1, ref blockFlag2);
            oppDragHp1.Text = "HP: " + Convert.ToString(player2Stats[0]);
            player2HpDisplay.Text = "HP: " + Convert.ToString(player2Stats[0]);

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Show();
            pictureBox2.Hide();
        }


        bool blockFlag1 = false;
        bool blockFlag2 = false;
       
        // block button for player 1
        private void button3_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            pictureBox2.Hide();

            blockFlag1 = true;
            richTextBox1.Text += "\n" + player1Names[0] + "is blocking " + player2Names[0] + "'s next attack!";
        }

        // attack button for player 2
        private void button4_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            pictureBox2.Hide();

            Attack(ref player1Stats[0], player2Stats[1], player1Names[0], player1Stats[3], player2Names[0], richTextBox1, ref blockFlag1);
            oppDragHp1.Text = "HP: " + Convert.ToString(player1Stats[0]);
            player2HpDisplay.Text = "HP: " + Convert.ToString(player1Stats[0]);
        }


        private void button5_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            pictureBox2.Show();
        }


        // block button for player 2
        private void button6_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            pictureBox2.Hide();

            blockFlag2 = true;
            richTextBox1.Text += "\n" + player2Names[0] + "is blocking " + player1Names[0] + "'s next attack!";
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            randomRoll();
            takeInitiative();
            DisplayPlayerInfo();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {


        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
