using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppPong
{
    public partial class FormMain : Form
    {
        Rectangle ball;
        Rectangle paddleLeft, paddleRight;

        Bitmap bitmap;
        Graphics graphics;

        int ballDx;
        int ballDy;
        int paddleDy;

        bool wPressed;
        bool sPressed;
        bool upPressed;
        bool downPressed;

        private void FormMain_Load(object sender, EventArgs e)
        {
            bitmap = new Bitmap(pictureBoxField.Width, pictureBoxField.Height);
            graphics = Graphics.FromImage(bitmap);

            ball = new Rectangle(pictureBoxField.Width / 2 - 10, pictureBoxField.Height / 2 - 10, 20, 20);

            paddleLeft = new Rectangle(10, pictureBoxField.Height / 2 - 50, 10, 100);
            paddleRight = new Rectangle(pictureBoxField.Width - 20, pictureBoxField.Height / 2 - 50, 10, 100);

            ballDx = ballDy = 5;
            paddleDy = 10;

            wPressed = sPressed = upPressed = downPressed = false;

        }

        private void timerGame_Tick(object sender, EventArgs e)
        {
            if (wPressed == true)
            {
                paddleLeft.Y -= paddleDy;

                if (paddleLeft.Y < 0)
                {
                    paddleLeft.Y = 0;
                }
            }

            if (sPressed == true)
            {
                paddleLeft.Y += paddleDy;

                if (paddleLeft.Y + paddleLeft.Height > bitmap.Height)
                {
                    paddleLeft.Y = bitmap.Height - paddleLeft.Height;
                }
            }

            if (upPressed == true)
            {
                paddleRight.Y -= paddleDy;

                if (paddleRight.Y < 0)
                {
                    paddleRight.Y = 0;
                }
            }

            if (downPressed == true)
            {
                paddleRight.Y += paddleDy;

                if (paddleRight.Y + paddleRight.Height > bitmap.Height)
                {
                    paddleRight.Y = bitmap.Height - paddleRight.Height;
                }
            }


            ball.X += ballDx;
            ball.Y += ballDy;

            if (ball.Y + ball.Height >= bitmap.Height)
            {
                ballDy = -ballDy;
                ball.Y -= 5;
            }

            if (ball.Y <= 0)
            {
                ballDy = -ballDy;
                ball.Y += 5;
            }

            if (ball.X + ball.Width >= bitmap.Width)
            {
                ballDx = -ballDx;
                ball.X -= 5;
            }

            if (ball.X <= 0)
            {
                ballDx = -ballDx;
                ball.X += 5;
            }



            graphics.Clear(Color.White);

            graphics.FillRectangle(Brushes.Orange, ball);
            graphics.FillRectangle(Brushes.Black, paddleLeft);
            graphics.FillRectangle(Brushes.Black, paddleRight);

            pictureBoxField.Image = bitmap;
        }

        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                wPressed = true;
            }

            if (e.KeyCode == Keys.S)
            {
                sPressed = true;
            }

            if (e.KeyCode == Keys.Up)
            {
                upPressed = true;
            }

            if (e.KeyCode == Keys.Down)
            {
                downPressed = true;
            }
        }

        private void FormMain_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                wPressed = false;
            }

            if (e.KeyCode == Keys.S)
            {
                sPressed = false;
            }

            if (e.KeyCode == Keys.Up)
            {
                upPressed = false;
            }

            if (e.KeyCode == Keys.Down)
            {
                downPressed = false;
            }
        }

        public FormMain()
        {
            InitializeComponent();
        }
    }
}
