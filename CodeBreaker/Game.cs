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
        public Game()
        {
            InitializeComponent();
        }

        public void gameSetup()
        {
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

        public void gameTimerEvent(object sender, EventArgs e)
        {
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
        }
    }
}