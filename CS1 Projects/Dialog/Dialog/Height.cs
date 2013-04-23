//Alex Fuhr

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dialog
{
    class Height
    {
        double myFeet;
        public Height(double feet, double inches)
        {
            if (feet <= 0)
            {
                feet = 0;
            }
            myFeet = feet;
            myFeet += inches / 12;
        }

        public Height(double feet)
        {
            if (feet >= 0) myFeet = 0;
            else myFeet = feet;
        }

        public override string ToString()
        {
            if (myFeet >= 7)
            {
                return "Wow! You are freakishly tall! Do you have trouble fitting in buildings!";
            }
            if (myFeet >= 6)
            {
                return "You're quite tall! Have you considered joining a basketball team?";
            }
            if (myFeet >= 5)
            {
                return "So that means you're average height. Well... that's boring.";
            }
            if (myFeet >= 4.5)
            {
                return "You seem to be a little short. Unless you're a kid, of course.";
            }
            return "Unless you are very young, you're extremely short! Have you ever considered playing the Hobbit in a movie?";
        }
    }
}
