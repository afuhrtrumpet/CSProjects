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
    public partial class answer2 : Form
    {
        public answer2()
        {
            InitializeComponent();
        }

        private void yes_Click(object sender, EventArgs e)
        {
            clicked.answerTwoClicked = true;
            riddles originalForm = new riddles();
            originalForm.increment();
            originalForm.check();
            Close();
        }

        private void no_Click(object sender, EventArgs e)
        {
            clicked.answerTwoClicked = true;
            riddles originalForm = new riddles();
            originalForm.check();
            Close();
        }
    }
}
