namespace PostfixCalculator
{
    /**
* Summary description for StackADT.
*/
    public class StackADT
    {
        //TODO: Implement the Stack using a java.util.LinkedList
        private ListADT myList;
        /// <summary>
        /// Sup dawg, we heard you like lists that are abstract in your stack so we put a ListADT in your stack so that
        /// abstract lists can help your stack.
        /// </summary>
        public StackADT()
        {
            myList = new ListADT();
        }
        /// <summary>
        /// Pushes an object on the top of the stack.
        /// </summary>
        /// <param name="newItem"></param>
        public void push(object newItem)
        {
            myList.add(newItem);
        }
        /// <summary>
        /// Pops the element on the top of the stack.
        /// </summary>
        /// <returns>The element popped.</returns>
        public object pop()
        {
            return myList.delete();
        }
        /// <summary>
        /// Looks at the element at the top of the stack without deleting or altering it.
        /// </summary>
        /// <returns>The top element of the stack.</returns>
        public object peek()
        {
            return myList.get(myList.getLength() - 1);
        }
        /// <summary>
        /// Determines whether stack is empty.
        /// </summary>
        /// <returns>True if stack is empty.</returns>
        public bool isEmpty()
        {
            return myList.getLength() == 0;
        }
        /// <summary>
        /// Gives the number of elements in the stack.
        /// </summary>
        /// <returns>The number of elements in the stack.</returns>
        public int size()
        {
            return myList.getLength();
        }
    }
    
}