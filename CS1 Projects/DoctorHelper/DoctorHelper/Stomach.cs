using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DoctorHelper
{
    class Stomach
    {
        public static void AskQuestion()
        {
            if (Question.Ask("Does your stomach hurt?", "Stomach question"))
            {
                Beans.AskQuestion();
            }
            else
            {
                MessageBox.Show("You're fine.\nThat will be $10.  Please pay at the window.\nDon't bother me again with your silly hypochondriac problems.", "Diagnosis", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
