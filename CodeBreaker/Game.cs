using System;
using Breaker;
using System.Drawing;
//using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Breaker 
{
    public class Game
    {
        //private PictureBox ball;
        //private PictureBox player;
        //private Label txtScore;
        private Timer gameTimer;

        bool goLeft;
        bool goRight;
        bool isGameOver;

        int score;
        int ballx;
        int bally;
        int playerSpeed;

        Random random = new Random();

        //PictureBox[] blockArray;

        public Game()
        {
            //InitializeComponent();

            CreateBox();
        }

        //private void InitializeComponent()
        //{
        //    this.ball = new System.Windows.Forms.PictureBox();
        //    this.player = new System.Windows.Forms.PictureBox();
        //    this.txtScore = new System.Windows.Forms.Label();
        //    ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
        //    ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
        //    this.SuspendLayout();
        //    // 
        //    // ball
        //    // 
        //    this.ball.BackColor = System.Drawing.Color.Red;
        //    this.ball.Location = new System.Drawing.Point(376, 328);
        //    this.ball.Name = "ball";
        //    this.ball.Size = new System.Drawing.Size(20, 20);
        //    this.ball.TabIndex = 0;
        //    this.ball.TabStop = false;
        //    // 
        //    // player
        //    // 
        //    this.player.BackColor = System.Drawing.Color.Black;
        //    this.player.Location = new System.Drawing.Point(347, 454);
        //    this.player.Name = "player";
        //    this.player.Size = new System.Drawing.Size(100, 20);
        //    this.player.TabIndex = 1;
        //    this.player.TabStop = false;
        //    // 
        //    // txtScore
        //    // 
        //    this.txtScore.AutoSize = true;
        //    this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //    this.txtScore.Location = new System.Drawing.Point(12, 9);
        //    this.txtScore.Name = "txtScore";
        //    this.txtScore.Size = new System.Drawing.Size(64, 20);
        //    this.txtScore.TabIndex = 2;
        //    this.txtScore.Text = "Score: 0";
        //    // 
        //    // Game
        //    // 
        //    this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        //    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        //    this.ClientSize = new System.Drawing.Size(784, 561);
        //    this.Controls.Add(this.txtScore);
        //    this.Controls.Add(this.player);
        //    this.Controls.Add(this.ball);
        //    this.Name = "Game";
        //    this.Text = "Code Breaker";
        //    this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyIsDown);
        //    this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
        //    ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
        //    ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
        //    this.ResumeLayout(false);
        //    this.PerformLayout();
        //}

        public void gameSetup()
        {
            isGameOver = false;
            score = 0;
            ballx = 5;
            bally = 5;
            playerSpeed = 12;
            //txtScore.Text = "Score: " + score;

            //ball.Left = 376;
            //ball.Top = 328;

            //player.Left = 347;

            //gameTimer.Start();

            //foreach (Control x in this.Controls)
            //{
            //    if (x is PictureBox && (string)x.Tag == "blocks")
            //    {
            //        x.BackColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            //    }
            //}
        }

        private void gameOver(string message)
        {
            isGameOver = true;
            //gameTimer.Stop();

            //txtScore.Text = "Score: " + score + " " + message;
        }

        private void CreateBox()
        {
            //blockArray = new PictureBox[15]

            int a = 0;

            int top = 50;
            int left = 100;

            //for (int i = 0; i < blockArray.Length; i++)
            //{
            //    blockArray[i] = new PictureBox();
            //    blockArray[i].Height = 32;
            //    blockArray[i].Width = 100;
            //    blockArray[i].Tag = "blocks";
            //    blockArray[i].BackColor = Color.White;

            //    if (a == 5)
            //    {
            //        top = top + 50;
            //        left = 100;
            //        a = 0;
            //    }

            //    if (a < 5)
            //    {
            //        a++;
            //        blockArray[i].Left = left;
            //        blockArray[i].Top = top;
            //        this.Controls.Add(blockArray[i]);
            //        left = left + 130;
            //    }
            //}

            gameSetup();
        }

        private void restartGame()
        {
            //foreach (PictureBox x in blockArray)
            //{
            //    this.Controls.Remove(x);
            //}
        }
        

        public void gameTimerEvent(object sender, EventArgs e)
        {
            //txtScore.Text = "Score: " + score;

            //if (goLeft == true && player.Left > 0)
            //{
            //    player.Left -= playerSpeed;
            //}
            //if (goRight == true && player.Left < 700) {
            //    player.Left += playerSpeed;
            //}

            //ball.Left += ballx;
            //ball.Top += bally;

            //if (ball.Left < 0 || ball.Left > 775)
            //{
            //    ballx = -ballx;
            //}
            //if  (ball.Top < 0)
            //{
            //    bally = -bally;
            //}
            //if (ball.Left + ball.Width > ClientSize.Width || ball.Left < 0)
            //{
            //    ballx = -ballx;
            //}

            //if (ball.Bounds.IntersectsWith(player.Bounds))
            //{
            //    ball.Top = 463;

            //    bally = random.Next(5, 12) * -1;

            //    if (ballx < 0) 
            //    {
            //        ballx = random.Next(5, 12) * -1;
            //    } else {
            //        ballx = random.Next(5, 12);
            //    }
            //}

            //foreach (Control x in this.Controls)
            //{
            //    if (x is PictureBox && (string)x.Tag == "blocks")
            //    {
            //        if ( ball.Bounds.IntersectsWith(x.Bounds))
            //        {
            //            score =+ 1;

            //            bally = -bally;

            //            this.Controls.Remove(x);
            //        }
            //    }
            //}

            if (score == 15)
            {
                gameOver("You Win!! Press Enter to Play Again!!");
            }

            //if (ball.Top > 500)
            //{
            //    gameOver("You Lose!! Press Enter to Play Again!!");
            //}
        }

        public void keyIsDown(object sender, EventArgs e)
        {
            //if (e.KeyCode == Keys.Left)
            //{
            //    goLeft = true;
            //}
            //if (e.KeyCode == Keys.Right)
            //{
            //    goRight = true;
            //}

        }

        public void KeyIsUp(object sender, EventArgs e)
        {
            //if (e.KeyCode == Keys.Left)
            //{
            //    goLeft = false;
            //}
            //if (e.KeyCode == Keys.Right)
            //{
            //    goRight = false;
            //}

            //if (e.KeyCode == Keys.Enter && isGameOver == true)
            //{
            //    restartGame();
            //    CreateBox();
            //}
        }
    }
}