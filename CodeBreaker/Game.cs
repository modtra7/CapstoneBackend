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

        }

        public void keyIsDown(object sender, EventArgs e)
        {

        }

        public void KeyIsUp(object sender, EventArgs e)
        {

        }
    }
}