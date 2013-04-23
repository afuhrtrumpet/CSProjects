//Alex Fuhr

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dialog
{
    class TwoPlusTwo
    {
        string myAnswer;
        public TwoPlusTwo(string answer)
        {
            myAnswer = answer;
        }
        public override string ToString()
        {
            int intAnswer;
            double doubleAnswer;
            bool intResult = int.TryParse(myAnswer, out intAnswer);
            if (intAnswer == 4) return "That's correct! But you're not very creative.";
            if (intAnswer == 5) return "I see. Big Brother is watching you.";
            if (intAnswer == 42) return "Indeed it is the answer to everything. ☺";
            if (intAnswer == 100) return "You're finally speaking my language! Good job.";
            if (intResult) return "We'll you're special.";
            bool doubleResult = double.TryParse(myAnswer, out doubleAnswer);
            if (doubleResult) return "Last time I checked, adding integers does not get a decimal!";
            return "I see. That's very...creative...of you. *sigh*";
        }
    }
}
