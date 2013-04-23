namespace TreeTester
{
    public class TreeNode
    {
        private object value;
        private TreeNode left;
        private TreeNode right;

        // Constructor:

        public TreeNode(object initValue, TreeNode initLeft, TreeNode initRight)
        {
            value = initValue;
            left = initLeft;
            right = initRight;
        }

        // Methods:

        public object getValue() { return value; }
        public TreeNode getLeft() { return left; }
        public TreeNode getRight() { return right; }
        public void setValue(object theNewValue) { value = theNewValue; }
        public void setLeft(TreeNode theNewLeft)
        {
            left = theNewLeft;
        }
        public void setRight(TreeNode theNewRight)
        {
            right = theNewRight;
        }
    }

}