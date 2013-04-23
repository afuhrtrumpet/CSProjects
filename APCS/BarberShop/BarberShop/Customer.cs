
namespace BarberShop
{
    /**
* Summary description for Customer.
*/
    public class Customer
    {
        private int myEntryTime;
        private int myServiceTime;

        public Customer(int entryTime, int serviceTime)
        {
            myEntryTime = entryTime;
            myServiceTime = serviceTime;
        }

        public int getEntryTime()
        {
            return myEntryTime;
        }

        public int getServiceTime()
        {
            return myServiceTime;
        }

        public override string ToString()
        {
            return "Timestamp = " + myEntryTime + "  Service time = " + myServiceTime;
        }
    }
    
}