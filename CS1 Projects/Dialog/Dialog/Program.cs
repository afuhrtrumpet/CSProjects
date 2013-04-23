//Alex Fuhr

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Dialog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Before I can say hello to you, are you male or female? Type 0 for male, 1 for   female.  ");
            string gender = Console.ReadLine();
            while (!(gender.Equals("1") || gender.Equals("0")))
            {
                Console.Write("\nThat's not a valid answer choice! Try again.  ");
                gender = Console.ReadLine();
            }
            bool isMale = gender.Equals("0");
            if (isMale) Console.Write("\nSo you're a male then! ");
            else Console.Write("\nThat means you are female! ");
            Console.Write("Now that we have that out of the way, what's your name?  ");
            string name = Console.ReadLine();
            Console.Write("\nWell, " + name + ", I should probably start learning some real facts about you. What is your height? How many feet?  ");
            double feet;
            bool feetResult = double.TryParse(Console.ReadLine(), out feet);
            while (!feetResult)
            {
                Console.Write("\nThat's not a number! Try again.  ");
                feetResult = double.TryParse(Console.ReadLine(), out feet);
            }
            double inches;
            Console.Write("\nNow, I need how many inches tall you are (this should be in addition to feet).  ");
            bool inchResult = double.TryParse(Console.ReadLine(), out inches);
            while (!inchResult)
            {
                Console.Write("\nThat's not a number! Try again.  ");
                inchResult = double.TryParse(Console.ReadLine(), out inches);
            }
            Height userHeight = new Height(feet, inches);
            Console.Write("\n" + userHeight + " I can tell much about you by your favorite color. What is this color (only use colors of the rainbow, with purple instead of indigo and violet)?  ");
            string color;
            FavoriteColor userColor = new FavoriteColor(FavoriteColor.UsedColors.RED);
            bool colorSet = false;
            do
            {                
                color = Console.ReadLine();
                switch (color.ToUpper())
                {
                    case "RED": userColor = new FavoriteColor(FavoriteColor.UsedColors.RED); colorSet = true; break;
                    case "ORANGE": userColor = new FavoriteColor(FavoriteColor.UsedColors.ORANGE); colorSet = true; break;
                    case "YELLOW": userColor = new FavoriteColor(FavoriteColor.UsedColors.YELLOW); colorSet = true; break;
                    case "GREEN": userColor = new FavoriteColor(FavoriteColor.UsedColors.GREEN); colorSet = true; break;
                    case "BLUE": userColor = new FavoriteColor(FavoriteColor.UsedColors.BLUE); colorSet = true; break;
                    case "PURPLE": userColor = new FavoriteColor(FavoriteColor.UsedColors.PURPLE); colorSet = true; break;
                    default: Console.Write("\nThis is not a valid color. Please choose one of the basic colors.  "); break;
                }
            } while (!colorSet);
            Console.Write("\n" + userColor + " Your answer to this next question should be interesting. What's 2+2?  ");
            TwoPlusTwo userAnswer = new TwoPlusTwo(Console.ReadLine());
            Console.Write("\n" + userAnswer + " One final question before our conversation is over. What is your favorite school subject? (options are english, math, science, social studies, art, band, choir, and computer science, but omit spaces)  ");
            string subject;
            FavoriteSubject userSubject = new FavoriteSubject(FavoriteSubject.Subjects.ENGLISH);
            bool subjectSet = false;
            do
            {
                subject = Console.ReadLine();
                switch (subject.ToUpper())
                {
                    case "ENGLISH": userSubject = new FavoriteSubject(FavoriteSubject.Subjects.ENGLISH); subjectSet = true; break;
                    case "MATH": userSubject = new FavoriteSubject(FavoriteSubject.Subjects.MATH); subjectSet = true; break;
                    case "SCIENCE": userSubject = new FavoriteSubject(FavoriteSubject.Subjects.SCIENCE); subjectSet = true; break;
                    case "SOCIALSTUDIES": userSubject = new FavoriteSubject(FavoriteSubject.Subjects.SOCIALSTUDIES); subjectSet = true; break;
                    case "ART": userSubject = new FavoriteSubject(FavoriteSubject.Subjects.ART); subjectSet = true; break;
                    case "BAND": userSubject = new FavoriteSubject(FavoriteSubject.Subjects.BAND); subjectSet = true; break;
                    case "CHOIR": userSubject = new FavoriteSubject(FavoriteSubject.Subjects.CHOIR); subjectSet = true; break;
                    case "COMPUTERSCIENCE": userSubject = new FavoriteSubject(FavoriteSubject.Subjects.COMPUTERSCIENCE); subjectSet = true; break;
                    default: Console.Write("\nThis is not a valid subject. Remember to omit spaces for subjects that are two words.  "); break;
                }
            } while (!subjectSet);
            Console.WriteLine("\n" + userSubject + " Well, it was nice to get to know you! I hope to see you again soon!");
        }
    }
}
