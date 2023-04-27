using System;

namespace Breaker 
{
    public class Game
    {

        bool goLeft;
        bool goRight;
        bool isGameOver;

        int score;
        int ballx;
        int bally;
        int playerSpeed;

        Random random = new Random();

        Box[] blockArray;

        public Game()
        {
            InitializeComponent();

            CreateBox();
        }

        public void gameSetup()
        {
            isGameOver = false;
            score = 0;
            ballx = 5;
            bally = 5;
            playerSpeed = 12;
            txtScore.Text = "Score: " + score;

            gameTimer.Start();

            foreach (Control x in this.Controls)
            {
                if (x is Box && (string)x.Tag == "blocks")
                {
                    x.BackColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                }
            }
        }

        private void gameOver(string message)
        {
            isGameOver = true;
            gameTimer.Stop();

            txtScore.Text = "Score: " + score + " " + message;
        }

        private void CreateBox()
        {
            blockArray = new Box[15];

            int a = 0;

            int top = 50;
            int left = 100;

            for (int i = 0; i < blockArray.Length; i++)
            {
                blockArray[i] = new Box();
                blockArray[i].Height = 32;
                blockArray[i].Width = 100;
                blockArray[i].Tag = "blocks";
                blockArray[i].BackColor = Color.White;

                if (a == 5)
                {
                    top = top + 50;
                    left = 100;
                    a = 0;
                }

                if (a < 5)
                {
                    a++;
                    blockArray[i].Left = left;
                    blockArray[i].Top = top;
                    this.Controls.Add(blockArray[i]);
                    left = left + 130;
                }
            }

            gameSetup();
        }

        private void restartGame()
        {
            foreach (Box x in blockArray)
            {
                this.Controls.Remove(x);
            }
        }
        

        public void gameTimerEvent(object sender, EventArgs e)
        {
            txtScore.Text = "Score: " + score;

            if (goLeft == true && player.Left > 0)
            {
                player.Left -= playerSpeed;
            }
            if (goRight == true && player.Left < 700) {
                player.Left += playerSpeed;
            }

            ball.Left += ballx;
            ball.Top += bally;

            if (ball.Left < 0 || ball.Left > 775)
            {
                ballx = -ballx;
            }
            if  (ball.Top < 0)
            {
                bally = -bally;
            }

            if (ballx.Bounds.IntersectsWith(player.Bounds))
            {
                bally = random.Next(5, 12) * -1;

                if (ballx < 0) 
                {
                    ballx = random.Next(5, 12) * -1;
                } else {
                    ballx = random.Next(5, 12);
                }
            }

            foreach (Control x in this.Controls)
            {
                if (x is Box && (string)x.Tag == "blocks")
                {
                    if ( ball.Bounds.IntersectsWith(x.Bounds))
                    {
                        score =+ 1;

                        bally = -bally;

                        this.Controls.Remove(x);
                    }
                }
            }

            if (score == 15)
            {
                gameOver("Youd Win!! Press Enter to Play Again!!");
            }

            if (ball.Top > 500)
            {
                gameOver("You Lose!! Press Enter to Play Again!!");
            }
        }

        public void keyIsDown(object sender, EventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }

        }

        public void KeyIsUp(object sender, EventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }

            if (e.Keycode == Keys.Enter && isGameOver == true)
            {
                restartGame();
                CreateBox();
            }
        }
    }
}