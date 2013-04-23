//Alex Fuhr

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dialog
{
    class FavoriteColor
    {
        public enum UsedColors {RED, ORANGE, YELLOW, GREEN, BLUE, PURPLE}
        UsedColors myColor;
        public FavoriteColor(UsedColors color)
        {
            myColor = color;
        }
        public override string ToString()
        {
            if (myColor == UsedColors.RED) return "...Are you a communist? This may be a matter of national security...";
            if (myColor == UsedColors.ORANGE) return "You are a bright and vibrant person, just like the color you picked.";
            if (myColor == UsedColors.YELLOW) return "You're color seems to not be very visible. Are you that way too?";
            if (myColor == UsedColors.GREEN) return "Well Al Gore, I see your environmental choice there.";
            if (myColor == UsedColors.BLUE) return "...Come on. You know blue is everyone's favorite color, right?";
            if (myColor == UsedColors.PURPLE) return "Congratulations! You are very original and out-of-the box on your color choice.";
            return "";
        }
    }
}
