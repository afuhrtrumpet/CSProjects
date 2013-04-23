using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentTester
{
    class Student
    {
        private string myName;
        private int myNumberOfQuizzes = 0;
        private double myTotalQuizScore = 0;
        private double myAverageQuizScore;

        public Student(string aName)
        {
            myName = aName;
        }

        public string getName()
        {
            return myName;
        }

        public void addQuiz(double aScore)
        {
            myTotalQuizScore += aScore;
            myNumberOfQuizzes += 1;
            myAverageQuizScore = myTotalQuizScore / myNumberOfQuizzes;
        }

        public double getTotalScore()
        {
            return myTotalQuizScore;
        }

        public double getAverageScore()
        {
            return myAverageQuizScore;
        }
    }
}
