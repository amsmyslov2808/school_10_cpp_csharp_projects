using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppRandomMath
{
    public partial class Form1 : Form
    {
        int rightAnswer = 0;
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonNewExample_Click(object sender, EventArgs e)
        {
            int x = random.Next(1, 11);
            int y = random.Next(1, 11);

            rightAnswer = x + y;

            labelExample.Text = $"{x} + {y} = ?";
        }

        private void buttonCheckUserAnswer_Click(object sender, EventArgs e)
        {
            int userAnswer = int.Parse(textBoxUserAnswer.Text);

            if (userAnswer == rightAnswer)
            {
                MessageBox.Show("Это правильный ответ!");
            }
            else
            {
                MessageBox.Show("Это НЕправильный ответ!");
            }

        }
    }
}
