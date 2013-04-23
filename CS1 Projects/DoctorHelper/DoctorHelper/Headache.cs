using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoctorHelper
{
    static class Headache
    {
        public static void AskQuestion()
        {
            if (Question.Ask("Does your head hurt?", "Head question"))
            {
                Eyes.AskQuestion();
            }
            else
            {
                Stomach.AskQuestion();
            }
        }
    }
}
