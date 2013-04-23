//Alex Fuhr

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dialog
{
    class FavoriteSubject
    {
        public enum Subjects {ENGLISH, MATH, SCIENCE, SOCIALSTUDIES, ART, BAND, CHOIR, COMPUTERSCIENCE}
        public Subjects mySubject;
        public FavoriteSubject(Subjects subject)
        {
            mySubject = subject;
        }
        public override string ToString()
        {
            if (mySubject == Subjects.ENGLISH) return "I see, a bookworm! \"To be or not to be, that is the question\"";
            if (mySubject == Subjects.MATH) return "Hmm... so how many digits of pi do you know? I bet I can beat you. After all, I'm a computer.";
            if (mySubject == Subjects.SCIENCE) return "Science... a very broad field. You seem to be quite the inquisitive person for choosing this.";
            if (mySubject == Subjects.SOCIALSTUDIES) return "So you're into history and government systems. But have you memorized the Constitution?";
            if (mySubject == Subjects.ART) return "You have some artistic talent then. How about painting me a picture?";
            if (mySubject == Subjects.BAND) return "Nice! One of my personal favorites. Offers many opportunities for creativity and expression.";
            if (mySubject == Subjects.CHOIR)
            {
                Console.Beep(500, 500);
                Console.Beep(750, 500);
                return "I can sing too, see?";
            }
            if (mySubject == Subjects.COMPUTERSCIENCE) return "Awesome. You are just plain awesome.";
            return "";
        }
    }
}
