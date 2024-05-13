namespace DragonProject
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            groupBox5 = new GroupBox();
            richTextBox1 = new RichTextBox();
            opponent2 = new GroupBox();
            oppDragHp2 = new Label();
            opponentDrag2 = new Label();
            opponent1 = new GroupBox();
            oppDragHp1 = new Label();
            opponentDrag1 = new Label();
            player2Info = new GroupBox();
            player2HpDisplay = new Label();
            blockP2 = new Button();
            specialAttP2 = new Button();
            attackP2 = new Button();
            player1Info = new GroupBox();
            player1HpDisplay = new Label();
            blockP1 = new Button();
            specialAttP1 = new Button();
            attackP1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox5.SuspendLayout();
            opponent2.SuspendLayout();
            opponent1.SuspendLayout();
            player2Info.SuspendLayout();
            player1Info.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(-10, -6);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(927, 457);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(458, 37);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(149, 239);
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(275, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(149, 239);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(richTextBox1);
            groupBox5.Location = new Point(262, 282);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(362, 133);
            groupBox5.TabIndex = 10;
            groupBox5.TabStop = false;
            groupBox5.Text = "Battle Log";
            groupBox5.Enter += groupBox5_Enter;
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Segoe UI", 8F);
            richTextBox1.Location = new Point(0, 22);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(377, 111);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "\n\n";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // opponent2
            // 
            opponent2.BackColor = Color.CornflowerBlue;
            opponent2.Controls.Add(oppDragHp2);
            opponent2.Controls.Add(opponentDrag2);
            opponent2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            opponent2.ForeColor = SystemColors.Control;
            opponent2.Location = new Point(672, 298);
            opponent2.Name = "opponent2";
            opponent2.Size = new Size(200, 117);
            opponent2.TabIndex = 6;
            opponent2.TabStop = false;
            opponent2.Text = "Opponent: Connor";
            // 
            // oppDragHp2
            // 
            oppDragHp2.AutoSize = true;
            oppDragHp2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            oppDragHp2.Location = new Point(61, 70);
            oppDragHp2.Name = "oppDragHp2";
            oppDragHp2.Size = new Size(61, 21);
            oppDragHp2.TabIndex = 1;
            oppDragHp2.Text = "HP : 20";
            // 
            // opponentDrag2
            // 
            opponentDrag2.AutoSize = true;
            opponentDrag2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            opponentDrag2.Location = new Point(14, 39);
            opponentDrag2.Name = "opponentDrag2";
            opponentDrag2.Size = new Size(160, 21);
            opponentDrag2.TabIndex = 0;
            opponentDrag2.Text = "Red, the Fire Dragon";
            // 
            // opponent1
            // 
            opponent1.BackColor = Color.Firebrick;
            opponent1.Controls.Add(oppDragHp1);
            opponent1.Controls.Add(opponentDrag1);
            opponent1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            opponent1.ForeColor = SystemColors.Control;
            opponent1.Location = new Point(31, 298);
            opponent1.Name = "opponent1";
            opponent1.Size = new Size(200, 117);
            opponent1.TabIndex = 9;
            opponent1.TabStop = false;
            opponent1.Text = "Opponent: Henro";
            opponent1.Enter += groupBox3_Enter;
            // 
            // oppDragHp1
            // 
            oppDragHp1.AutoSize = true;
            oppDragHp1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            oppDragHp1.Location = new Point(60, 70);
            oppDragHp1.Name = "oppDragHp1";
            oppDragHp1.Size = new Size(61, 21);
            oppDragHp1.TabIndex = 1;
            oppDragHp1.Text = "HP : 30";
            // 
            // opponentDrag1
            // 
            opponentDrag1.AutoSize = true;
            opponentDrag1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            opponentDrag1.Location = new Point(12, 39);
            opponentDrag1.Name = "opponentDrag1";
            opponentDrag1.Size = new Size(153, 21);
            opponentDrag1.TabIndex = 0;
            opponentDrag1.Text = "Ava, the Ice Dragon";
            // 
            // player2Info
            // 
            player2Info.BackColor = SystemColors.Control;
            player2Info.Controls.Add(player2HpDisplay);
            player2Info.Controls.Add(blockP2);
            player2Info.Controls.Add(specialAttP2);
            player2Info.Controls.Add(attackP2);
            player2Info.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            player2Info.ForeColor = Color.CornflowerBlue;
            player2Info.Location = new Point(644, 35);
            player2Info.Name = "player2Info";
            player2Info.Size = new Size(228, 239);
            player2Info.TabIndex = 7;
            player2Info.TabStop = false;
            player2Info.Text = "Ava, the Ice Dragon's Turn";
            // 
            // player2HpDisplay
            // 
            player2HpDisplay.AutoSize = true;
            player2HpDisplay.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            player2HpDisplay.ForeColor = Color.CornflowerBlue;
            player2HpDisplay.Location = new Point(82, 36);
            player2HpDisplay.Name = "player2HpDisplay";
            player2HpDisplay.Size = new Size(80, 28);
            player2HpDisplay.TabIndex = 4;
            player2HpDisplay.Text = "HP : 30";
            player2HpDisplay.Click += label4_Click;
            // 
            // blockP2
            // 
            blockP2.BackColor = SystemColors.Control;
            blockP2.FlatStyle = FlatStyle.Popup;
            blockP2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            blockP2.ForeColor = Color.CornflowerBlue;
            blockP2.Location = new Point(24, 189);
            blockP2.Name = "blockP2";
            blockP2.Size = new Size(186, 42);
            blockP2.TabIndex = 3;
            blockP2.Text = "Block";
            blockP2.UseVisualStyleBackColor = false;
            blockP2.Click += button6_Click_1;
            // 
            // specialAttP2
            // 
            specialAttP2.BackColor = SystemColors.Control;
            specialAttP2.FlatStyle = FlatStyle.Popup;
            specialAttP2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            specialAttP2.ForeColor = Color.CornflowerBlue;
            specialAttP2.Location = new Point(24, 135);
            specialAttP2.Name = "specialAttP2";
            specialAttP2.Size = new Size(186, 42);
            specialAttP2.TabIndex = 3;
            specialAttP2.Text = "Special Attack";
            specialAttP2.UseVisualStyleBackColor = false;
            specialAttP2.Click += button5_Click_1;
            // 
            // attackP2
            // 
            attackP2.BackColor = SystemColors.Control;
            attackP2.FlatStyle = FlatStyle.Popup;
            attackP2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            attackP2.ForeColor = Color.CornflowerBlue;
            attackP2.Location = new Point(24, 77);
            attackP2.Name = "attackP2";
            attackP2.Size = new Size(186, 42);
            attackP2.TabIndex = 3;
            attackP2.Text = "Attack";
            attackP2.UseVisualStyleBackColor = false;
           // attackP2.Click += button4_Click_1;
            // 
            // player1Info
            // 
            player1Info.Controls.Add(player1HpDisplay);
            player1Info.Controls.Add(blockP1);
            player1Info.Controls.Add(specialAttP1);
            player1Info.Controls.Add(attackP1);
            player1Info.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            player1Info.ForeColor = Color.Firebrick;
            player1Info.Location = new Point(16, 35);
            player1Info.Name = "player1Info";
            player1Info.Size = new Size(226, 239);
            player1Info.TabIndex = 8;
            player1Info.TabStop = false;
            player1Info.Text = "Red, the Fire Dragon's Turn";
            // 
            // player1HpDisplay
            // 
            player1HpDisplay.AutoSize = true;
            player1HpDisplay.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            player1HpDisplay.ForeColor = Color.Firebrick;
            player1HpDisplay.Location = new Point(65, 36);
            player1HpDisplay.Name = "player1HpDisplay";
            player1HpDisplay.Size = new Size(80, 28);
            player1HpDisplay.TabIndex = 3;
            player1HpDisplay.Text = "HP : 20";
            player1HpDisplay.Click += label1_Click;
            // 
            // blockP1
            // 
            blockP1.BackColor = SystemColors.Control;
            blockP1.FlatStyle = FlatStyle.Popup;
            blockP1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            blockP1.ForeColor = Color.Firebrick;
            blockP1.Location = new Point(15, 188);
            blockP1.Name = "blockP1";
            blockP1.Size = new Size(186, 45);
            blockP1.TabIndex = 2;
            blockP1.Text = "Block";
            blockP1.UseVisualStyleBackColor = false;
            blockP1.Click += button3_Click_1;
            // 
            // specialAttP1
            // 
            specialAttP1.BackColor = SystemColors.Control;
            specialAttP1.FlatStyle = FlatStyle.Popup;
            specialAttP1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            specialAttP1.ForeColor = Color.Firebrick;
            specialAttP1.Location = new Point(15, 135);
            specialAttP1.Name = "specialAttP1";
            specialAttP1.Size = new Size(186, 42);
            specialAttP1.TabIndex = 1;
            specialAttP1.Text = "Special Attack";
            specialAttP1.UseVisualStyleBackColor = false;
            specialAttP1.Click += button2_Click_1;
            // 
            // attackP1
            // 
            attackP1.BackColor = SystemColors.Control;
            attackP1.FlatStyle = FlatStyle.Popup;
            attackP1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            attackP1.ForeColor = Color.Firebrick;
            attackP1.Location = new Point(15, 77);
            attackP1.Name = "attackP1";
            attackP1.Size = new Size(186, 42);
            attackP1.TabIndex = 0;
            attackP1.Text = "Attack";
            attackP1.UseVisualStyleBackColor = false;
            attackP1.Click += button1_Click_1;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 450);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox5);
            Controls.Add(opponent2);
            Controls.Add(opponent1);
            Controls.Add(player2Info);
            Controls.Add(player1Info);
            Controls.Add(pictureBox3);
            Name = "Form2";
            Text = "The Battle";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox5.ResumeLayout(false);
            opponent2.ResumeLayout(false);
            opponent2.PerformLayout();
            opponent1.ResumeLayout(false);
            opponent1.PerformLayout();
            player2Info.ResumeLayout(false);
            player2Info.PerformLayout();
            player1Info.ResumeLayout(false);
            player1Info.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private GroupBox groupBox5;
        private RichTextBox richTextBox1;
        private GroupBox opponent2;
        private Label oppDragHp2;
        private Label opponentDrag2;
        private GroupBox opponent1;
        private Label oppDragHp1;
        private Label opponentDrag1;
        private GroupBox player2Info;
        private Label player2HpDisplay;
        private Button blockP2;
        private Button specialAttP2;
        private Button attackP2;
        private GroupBox player1Info;
        private Label player1HpDisplay;
        private Button blockP1;
        private Button specialAttP1;
        private Button attackP1;
    }
}