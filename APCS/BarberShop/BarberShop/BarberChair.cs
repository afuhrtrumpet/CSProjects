namespace BarberShop
{
    /**
* Summary description for BarberChair.
*/
    //You know, it would help if you commented this.
    public class BarberChair
    {
        private bool active;
        private bool newCustomer;
        private int remainingJobTime;

        public BarberChair()
        {
            active = false;
            newCustomer = false;
        }

        public void setActive(bool value)
        {
            active = value;
        }

        public bool isActive()
        {
            return active;
        }

        public bool isNewCustomer()
        {
            return newCustomer;
        }

        public bool isEmpty()
        {
            return remainingJobTime == 0;
        }

        public void setJobTime(int value)
        {
            remainingJobTime = value;
            newCustomer = true;
        }

        public int getJobTime()
        {
            return remainingJobTime;
        }

        public void cutHair(int timeInterval)
        {
            if (remainingJobTime > 0)
            {
                remainingJobTime -= timeInterval;
                newCustomer = false;
            }
        }
    }

}