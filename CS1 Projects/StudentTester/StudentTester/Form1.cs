using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StudentTester
{
    public partial class Form1 : Form
    {
        private Student newPerson;
        public Form1()
        {
            InitializeComponent();
        }

        private void instantiateButton_Click(object sender, EventArgs e)
        {
            newPerson = new Student(nameBox.Text);
            studentNameLabel.Text = "New Student: " + newPerson.getName();
            totalScoreLabel.Text = Convert.ToString(newPerson.getTotalScore());
            AcceptButton = addButton;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            newPerson.addQuiz(Convert.ToDouble(newScoreBox.Text));
            totalScoreLabel.Text = Convert.ToString(newPerson.getTotalScore());
            averageScoreLabel.Text = Convert.ToString(newPerson.getAverageScore());
            newScoreBox.Clear();
        }

    }
}
