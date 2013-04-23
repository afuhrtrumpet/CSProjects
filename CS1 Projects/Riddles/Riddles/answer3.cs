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
    public partial class answer3 : Form
    {
        public answer3()
        {
            InitializeComponent();
        }

        private void no_Click(object sender, EventArgs e)
        {
            clicked.answerThreeClicked = true;
            riddles originalForm = new riddles();
            originalForm.check();
            Close();
        }

        private void yes_Click(object sender, EventArgs e)
        {
            clicked.answerThreeClicked = true;
            riddles originalForm = new riddles();
            originalForm.increment();
            originalForm.check();
            Close();
        }
    }
}
