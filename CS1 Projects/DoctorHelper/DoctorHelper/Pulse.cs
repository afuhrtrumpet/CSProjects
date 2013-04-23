using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DoctorHelper
{
    static class Pulse
    {
        public static void AskQuestion()
        {
            if (Question.Ask("Do you have a pulse?", "Pulse question"))
            {
                Headache.AskQuestion();
            }
            else
            {
                MessageBox.Show("You're dead.\nThat will be $10.  Please pay at the window.\nThis is when I would normally say \"Come again\", but then,\ngiven your current condition, that would be silly of me.", "Diagnosis", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
