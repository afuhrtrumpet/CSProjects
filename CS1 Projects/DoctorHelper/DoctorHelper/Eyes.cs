using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DoctorHelper
{
    class Eyes
    {
        public static void AskQuestion()
        {
            if (Question.Ask("Do your eyes hurt?", "Eye question"))
            {
                MessageBox.Show("You have malaria and will probably die.\nThat will be $10.  Please pay at the window.", "Diagnosis", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                MessageBox.Show("You have a migraine, probably from listening to too many CS lectures.\nThat will be $10.  Please pay at the window.", "Diagnosis", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
