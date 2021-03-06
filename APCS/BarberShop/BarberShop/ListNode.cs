/**
 * Summary description for ListNode.
 */
namespace BarberShop
{
    public class ListNode
    {
        private object data;
        private ListNode next;

        public ListNode(object d, ListNode n)
        {
            data = d;
            next = n;
        }

        public override string ToString()
        {
            return data.ToString();
        } 

        public object getValue()
        { return data; }

        public ListNode getNext()
        { return next; }

        public void setValue(object d)
        { data = d; }

        public void setNext(ListNode n)
        { next = n; }
    }

}