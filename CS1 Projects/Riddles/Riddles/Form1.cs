using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Riddles
{


    public partial class riddles : Form
    {
        public riddles()
        {
            InitializeComponent();
        }
        private void retreat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (clicked.answerOneClicked == false)
            {
                answer1 firstAns = new answer1();
                firstAns.Show();
                button1.BackColor = Color.Silver;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (clicked.answerTwoClicked == false)
            {
                answer2 secondAns = new answer2();
                secondAns.Show();
                button2.BackColor = Color.Silver;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (clicked.answerThreeClicked == false)
            {
                answer3 thirdAns = new answer3();
                thirdAns.Show();
                clicked.answerThreeClicked = true;
                button3.BackColor = Color.Silver;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (clicked.answerFourClicked == false)
            {
                answer4 fourthAns = new answer4();
                fourthAns.Show();
                clicked.answerFourClicked = true;
                button4.BackColor = Color.Silver;
            }
        }
        public void increment()
        {
            clicked.score += 1;
        }
        public void check()
        {
            if (clicked.answerOneClicked && clicked.answerTwoClicked && clicked.answerThreeClicked && clicked.answerFourClicked == true)
            {                
                MessageBox.Show("Your score is " + clicked.score + "/4.", "Results", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);                       
            }
        }

        private void restart_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            clicked.answerOneClicked = false;
            clicked.answerTwoClicked = false;
            clicked.answerThreeClicked = false;
            clicked.answerFourClicked = false;
            clicked.score = 0;
        }
    }
}
