using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DoctorHelper
{
    class Beans
    {
        public static void AskQuestion()
        {
            if (Question.Ask("Have you recently eaten beans?", "Beans question"))
            {
                MessageBox.Show("You have gas.\nThat will be $10.  Please pay at the window.\nWill someone please find the air freshener can?", "Diagnosis", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                MessageBox.Show("You have morning sickness.\nThat will be $10.  Please pay at the window.\nMay I suggest 'Pentium' as a name worth considering?", "Diagnosis", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
