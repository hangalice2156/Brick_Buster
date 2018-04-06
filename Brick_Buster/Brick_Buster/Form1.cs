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

        public Form1()
        {
            InitializeComponent();
            generateBricks();
            gameStart();
        }

        //Brick generator function and Game generator
        public void generateBricks()
        {
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
                Ball_1.setVelocity(-Ball_1.getVelocityX(), Ball_1.getVelocityY());
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
                    this.Controls.Remove(bricks[i]);
                    bricks[i].Dispose();
                    break;
                }
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            int X = e.X;
            if(X < 50) { X = 50; }
            if(X > 560) { X = 560; }

            Player1.Location = new Point(X - 50, 375);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Ball_1.Top += Ball_1.getVelocityX();
            Ball_1.Left += Ball_1.getVelocityY();
            checkBounceBorder();
            checkBounceBoard();
            checkCollideBrick();
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
            Size = new Size(30, 30);
            Location = new Point(300, 200);
            BackColor = Color.Azure;
            Velocity_X = -10;
            Velocity_Y = -10;
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
