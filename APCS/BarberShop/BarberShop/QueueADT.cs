namespace BarberShop
{
    /**
* Summary description for QueueADT.
*/
    public class QueueADT
    {
        //TODO: Implement a queue using a linked list (ListADT).
        private ListADT listMonkey;
        /// <summary>
        /// Initializes the list portion of the queue.
        /// </summary>
        public QueueADT()
        {
            listMonkey = new ListADT();
        }
        /// <summary>
        /// Adds an object to the beginning of the queue.
        /// </summary>
        /// <param name="newItem">The new object to be placed in the queue.</param>
        public void add(object newItem)
        {
            listMonkey.add(newItem);
        }
        /// <summary>
        /// Removes the object at the end of the queue.
        /// </summary>
        /// <returns>The object removed.</returns>
        public object remove()
        {
            return listMonkey.delete(0);
        }
        /// <summary>
        /// Determines the length of the queue.
        /// </summary>
        /// <returns>The length of the queue.</returns>
        public int size()
        {
            return listMonkey.getLength();
        }
        /// <summary>
        /// Determines if the queue is empty.
        /// </summary>
        /// <returns>True if queue is empty.</returns>
        public bool isEmpty()
        {
            return listMonkey.getLength() == 0;
        }
        /// <summary>
        /// Generates a string based on the items in the queue.
        /// </summary>
        /// <returns>The generated string.</returns>
        public override string ToString()
        {
            return listMonkey.ToString();
        }
    }

}