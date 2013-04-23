using System;
/**
 * Stores a dynamic list and includes several commands to modify it or obtain information from it.
 */
namespace PostfixCalculator
{
    public class ListADT
    {
        //TODO: Implement the Linked List.
        private int length;
        private ListNode tail;
        private ListNode head;
        /// <summary>
        /// Initializes the head to a blank list node and sets the tail reference and length.
        /// </summary>
        public ListADT()
        {
            head = new ListNode(null, null);
            tail = head;
            length = 0;
        }
        /// <summary>
        /// Adds an object to the end of the list.
        /// </summary>
        /// <param name="newItem">The object to be added to the end of the list.</param>
        public void add(object newItem)
        {
            ListNode freshlyBakedPizza = new ListNode(newItem, null);
            tail.setNext(freshlyBakedPizza);
            tail = freshlyBakedPizza;
            length++;
        }
        /// <summary>
        /// Adds an object to the end at the specified index.
        /// </summary>
        /// <param name="newItem">The object to be added at the specified index.</param>
        /// <param name="index">The index that the object is to be added it.</param>
        public void add(object newItem, int index)
        {
            if (index < 0 && index != -1) index = 0;
            if (index >= length || index == -1) add(newItem);
            else
            {
                ListNode freshlyBakedPizza = new ListNode(newItem, null);
                ListNode pizza = head;
                for (int i = 0; i < index; i++)
                {
                    pizza = pizza.getNext();
                }
                ListNode standbyPizza = pizza.getNext();
                pizza.setNext(freshlyBakedPizza);
                freshlyBakedPizza.setNext(standbyPizza);
                length++;
            }
        }
        /// <summary>
        /// Deletes the last item of the list.
        /// </summary>
        /// <returns>The object that was deleted.</returns>
        public object delete()
        {
            if (getLength() != 0)
            {
                ListNode pizza = head;
                while (pizza.getNext().getNext() != null)
                {
                    pizza = pizza.getNext();
                }
                object temp = pizza.getNext().getValue();
                pizza.setNext(null);
                tail = pizza;
                length--;
                return temp;
            }
            else throw new IndexOutOfRangeException();
        }
        /// <summary>
        /// Deletes the item at the specified index.
        /// </summary>
        /// <param name="index">The index that the item is to be deleted at.</param>
        /// <returns>The object that was deleted.</returns>
        public object delete(int index)
        {
            if (index >= 0 && index < length)
            {
                object temp;
                ListNode pizza = head;
                for (int i = 0; i < index; i++)
                {
                    pizza = pizza.getNext();
                }
                temp = pizza.getNext().getValue();
                pizza.setNext(pizza.getNext().getNext());
                length--;
                return temp;
            }
            else throw new IndexOutOfRangeException();
        }
        /// <summary>
        /// Compiles a string representing each list node and its data.
        /// </summary>
        /// <returns>A long string containing indexes and data separated by line breaks.</returns>
        public override string ToString()
        {
            string massiveStringOfAwesome = "";
            ListNode pizza = head;
            int i = 0;
            while (pizza.getNext() != null)
            {
                pizza = pizza.getNext();
                massiveStringOfAwesome += "\r\n" + i + ") " + pizza;
                i++;
            }
            return massiveStringOfAwesome;
        }
        /// <summary>
        /// Gets the length of the list.
        /// </summary>
        /// <returns>The list's length.</returns>
        public int getLength()
        {
            return length;
        }
        /// <summary>
        /// Retrieves the object located at the specified index.
        /// </summary>
        /// <param name="index">The index of the desired object in the list</param>
        /// <returns>The object at the specified index.</returns>
        public object get(int index)
        {
            if (index >= 0 && index < length)
            {
                ListNode pizza = head.getNext();
                for (int i = 0; i < index; i++)
                {
                    pizza = pizza.getNext();
                }
                if (pizza != null)
                {
                    return pizza.getValue();
                }
                else return "";
            }
            else throw new IndexOutOfRangeException();
        }
        /// <summary>
        /// Sets the specified index to a different object.
        /// </summary>
        /// <param name="index">The index that the object will be set at.</param>
        /// <param name="newItem">The object that is set at the specified index.</param>
        /// <returns>The object previously in the specified index.</returns>
        public object set(int index, object newItem)
        {
            if (index >= 0 && index < length)
            {
                ListNode pizza = head.getNext();
                for (int i = 0; i < index; i++)
                {
                    pizza = pizza.getNext();
                }
                if (pizza != null)
                {
                    object temp = pizza.getValue();
                    pizza.setValue(newItem);
                    return temp;
                }
                else
                {
                    return "";
                }
            }
            else throw new IndexOutOfRangeException();
        }
        /// <summary>
        /// Resets the list to starting conditions.
        /// </summary>
        public void clear()
        {
            head = new ListNode(null, null);
            tail = head;
            length = 0;
        }
    }
}