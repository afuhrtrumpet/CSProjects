using System;

namespace AsciiAnimation
{
    class AsciiAnimator
    {
        private string[] frames;
        private int currentFrameNumber;
        public AsciiAnimator(string rawAnimation, string sep)
        {
            //String objects have a method named Split that will take a string and
            //split it into pieces.  The first parameter to the Split method is an
            //array of strings that are to be used as the split value.  I took the
            //separator parameter to the constructor and put it into an array.
            //Note that Split returns an array that contains the string pieces.
            //I saved the string pieces, which make up the frames of the animation,
            //in an array named frames, which you need to declare as an instance variable.
            string[] delim = { sep };
            frames = rawAnimation.Split( delim, StringSplitOptions.RemoveEmptyEntries);
            currentFrameNumber = frames.Length - 1;
        }

        public String getNextFrame()
        {
            if (currentFrameNumber < frames.Length - 1)
                currentFrameNumber++;
            else currentFrameNumber = 0;
            return frames[currentFrameNumber];
        }

        public int getCurrentFrameNumber()
        {
            return currentFrameNumber;
        }

        public String getPreviousFrame()
        {
            if (currentFrameNumber > 0)
                currentFrameNumber--;
            else currentFrameNumber = frames.Length - 1;
            return frames[currentFrameNumber];
        }
    }
}
