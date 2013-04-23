using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Riddles
{
    public static class clicked
    {
        public static bool answerOneClicked = false;
        public static bool answerTwoClicked = false;
        public static bool answerThreeClicked = false;
        public static bool answerFourClicked = false;
        public static int score = 0;
    }

    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new riddles());
        }
    }
}
