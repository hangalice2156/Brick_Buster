using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Brick_Buster
{
    public partial class Form1 : Form
    {
        public int Brick_numbers = 48;
        Label[] bricks = new Label[48];
        Board Player1 = new Board();
        Ball Ball_1 = new Ball();
        public int score;
        public int H_score;

        public Form1()
        {
            InitializeComponent();
            generateBricks();
            gameStart();
        }

        //Brick generator function and Game generator
        public void generateBricks()
        {
            Array.Clear(bricks, 0, 48);
            int index = 0;
            for(int i = 0; i < 8; ++i)
            {
                for(int j = 0; j < 6; ++j)
                {
                    bricks[index] =new Brick(i * 75 + 10, j * 25 + 10);
                    this.Controls.Add(bricks[index]);
                    ++index;
                }
            }
        }
        public void gameStart()
        {
            this.Controls.Add(Player1);
            this.Controls.Add(Ball_1);
        }

        //Bounce functions
        public void checkBounceBorder()
        {
            //left and right border
            if(Ball_1.Left < 20 || Ball_1.Right > 580)
            {
                Ball_1.setVelocity(Ball_1.getVelocityX(), -Ball_1.getVelocityY());
            }
            //top border
            if (Ball_1.Top < 30)
            {
                Ball_1.setVelocity(-Ball_1.getVelocityX(), Ball_1.getVelocityY());
            }
        }
        public void checkBounceBoard()
        {
            if(Ball_1.Bottom > Player1.Top && Ball_1.Left < Player1.Right && Ball_1.Right > Player1.Left)
            {
                int Delta;
                if (((Ball_1.Left + Ball_1.Right) / 2 - (Player1.Left + Player1.Right) / 2) < 0) Delta = -1;
                else Delta = 1;

                Ball_1.setVelocity(-Ball_1.getVelocityX() ,Ball_1.getVelocityY() * Delta);
            }
        }
        public void checkCollideBrick()
        {
            for(int i = 0; i < Brick_numbers; ++i)
            {
                //bottom collision
                if (Ball_1.Top < bricks[i].Bottom && Ball_1.Left < bricks[i].Right && Ball_1.Right > bricks[i].Left)
                {
                    Ball_1.setVelocity(-Ball_1.getVelocityX(), Ball_1.getVelocityY());
                    bricks[i].Location = new Point(-100, -100);
                    this.Controls.Remove(bricks[i]);
                    bricks[i].Dispose();
                    score += 20;
                    break;
                }
                //top collision
                if(Ball_1.Bottom < bricks[i].Top && Ball_1.Left < bricks[i].Right && Ball_1.Right > bricks[i].Left)
                {
                    Ball_1.setVelocity(-Ball_1.getVelocityX(), Ball_1.getVelocityY());
                    bricks[i].Location = new Point(-100, -100);
                    this.Controls.Remove(bricks[i]);
                    bricks[i].Dispose();
                    score += 20;
                    break;
                }
                //right
                if (Ball_1.Left < bricks[i].Right && Ball_1.Top > bricks[i].Bottom && Ball_1.Bottom < bricks[i].Top)
                {
                    Ball_1.setVelocity(Ball_1.getVelocityX(), -Ball_1.getVelocityY());
                    bricks[i].Location = new Point(-100, -100);
                    this.Controls.Remove(bricks[i]);
                    bricks[i].Dispose();
                    score += 20;
                    break;
                }
                //left
                if (Ball_1.Right > bricks[i].Left && Ball_1.Top > bricks[i].Bottom && Ball_1.Bottom < bricks[i].Top)
                {
                    Ball_1.setVelocity(Ball_1.getVelocityX(), -Ball_1.getVelocityY());
                    bricks[i].Location = new Point(-100, -100);
                    this.Controls.Remove(bricks[i]);
                    bricks[i].Dispose();
                    score += 20;
                    break;
                }
            }
        }

        //success or failure
        public void checkWinorLose()
        {
            if(Ball_1.Bottom > Player1.Bottom)
            {
                timer1.Enabled = false;
                MessageBox.Show("You Lost! try again", "GG");
            }
            if(score > 950)
            {
                timer1.Enabled = false;
                MessageBox.Show("You win! Congratulations", "GG");
            }
        }
        public void scoreUpdate()
        {
            ScoreLabel.Text = "Score: " + score;
            if(score > H_score)
            {
                H_score = score;
                HighScoreLabel.Text = "High Score: " + H_score;
            }

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            int X = e.X;
            if(X < 50) { X = 50; }
            if(X > 685) { X = 685; }

            Player1.Location = new Point(X - 50, 375);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Ball_1.Top += Ball_1.getVelocityX();
            Ball_1.Left += Ball_1.getVelocityY();
            checkBounceBorder();
            checkBounceBoard();
            checkCollideBrick();
            checkWinorLose();
            scoreUpdate();
        }

        //diffculity settings
        private void DiffE_CheckedChanged(object sender, EventArgs e)
        {
            Player1.Size = new Size(100, 25);
        }

        private void DiffN_CheckedChanged(object sender, EventArgs e)
        {
            Player1.Size = new Size(75, 25);
        }

        private void DiffH_CheckedChanged(object sender, EventArgs e)
        {
            Player1.Size = new Size(50, 25);
        }

        private void DiffHow_CheckedChanged(object sender, EventArgs e)
        {
            Player1.Size = new Size(600, 25);
        }

        private void DiffEX_CheckedChanged(object sender, EventArgs e)
        {
            Player1.Size = new Size(10, 5);
        }

        //speed setting
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Ball_1.setVelocity(4, -4);
        }
        private void SpeedH_CheckedChanged(object sender, EventArgs e)
        {
            Ball_1.setVelocity(8, -8);
        }
        private void SpeedEX_CheckedChanged(object sender, EventArgs e)
        {
            Ball_1.setVelocity(20, -20);
        }

        //button functions
        private void StartBtn_Click(object sender, EventArgs e)
        {
            gameContinue();
        }
        public void gameContinue()
        {
            timer1.Enabled = true;
        }
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            gameReset();
        }
        public void gameReset()
        {
            timer1.Enabled = false;
            for (int i = 0; i < Brick_numbers; ++i)
            {
                bricks[i].Location = new Point(-100, -100);
                this.Controls.Remove(bricks[i]);
                bricks[i].Dispose();
            }
            generateBricks();
            Ball_1.Location = new Point(300, 200);
            score = 0;
        }
        private void PauseBtn_Click(object sender, EventArgs e)
        {
            gamePause();
        }
        public void gamePause()
        {
            timer1.Enabled = false;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.P:
                    {
                        gamePause();
                        break;
                    }
                case Keys.R:
                    {
                        gameReset();
                        break;
                    }
                case Keys.G:
                    {
                        gameContinue();
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }
    }

    public class Brick : Label
    {
        public Brick(int X, int Y)
        {
            Location = new Point(X, Y);
            BackColor = Color.Blue;
            Size = new Size(75, 25);
            BorderStyle = BorderStyle.Fixed3D;
        }
    }

    public class Board : PictureBox
    {
        public Board()
        {
            Size = new Size(100, 25);
            BackColor = Color.Lime;
            Location = new Point(350, 450);
        }
    }

    public class Ball : PictureBox
    {
        public Ball()
        {
            Size = new Size(20, 20);
            Location = new Point(300, 200);
            BackColor = Color.Azure;
            Velocity_X = 4;
            Velocity_Y = -4;
        }
        public void setVelocity(int X, int Y)
        {
            Velocity_X = X;
            Velocity_Y = Y;
        }
        public int getVelocityX()
        {
            return Velocity_X;
        }
        public int getVelocityY()
        {
            return Velocity_Y;
        }

        private int Velocity_X;
        private int Velocity_Y;
    }
}
