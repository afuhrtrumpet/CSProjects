using System;
using System.Drawing;
namespace TreeTester
{
    public class TreeADT
    {
        //TODO: Binary Search Tree Implementation goes here.
        private TreeNode froot;
        private int count;
        /// <summary>
        /// Constructs a tree.
        /// </summary>
        public TreeADT()
        {
            froot = null;
        }
        /// <summary>
        /// Constructs a tree using an initial node.
        /// </summary>
        /// <param name="firstNode">The root node of the tree.</param>
        public TreeADT(TreeNode firstNode)
        {
            froot = firstNode;
        }
        /// <summary>
        /// Finds the number of nodes in the tree.
        /// </summary>
        /// <returns>The count of nodes in the tree.</returns>
        public int length()
        {
            return count;
        }
        /// <summary>
        /// Determines whether the tree is empty.
        /// </summary>
        /// <returns>True if the tree is empty.</returns>
        public bool isEmpty()
        {
            return count == 0;
        }
        /// <summary>
        /// Inserts a node into the tree.
        /// </summary>
        /// <param name="data">The data of the node to be inserted.</param>
        public void insert(IComparable data)
        {
            insert(data, froot);
        }
        /// <summary>
        /// Inserts a node into the tree.
        /// </summary>
        /// <param name="data">The data of the node to be inserted.</param>
        /// <param name="root">The root of the current subtree.</param>
        private void insert(IComparable data, TreeNode root)
        {
            if (froot == null) 
            {
                froot = new TreeNode(data, null, null);
                count++;
            }
            else
            {
                int comparison = data.CompareTo(root.getValue());
                if (comparison > 0)
                {
                    if (root.getRight() == null)
                    {
                        root.setRight(new TreeNode(data, null, null));
                        count++;
                    }
                    else insert(data, root.getRight());
                }
                else if (comparison <= 0)
                {
                    if (root.getLeft() == null)
                    {
                        root.setLeft(new TreeNode(data, null, null));
                        count++;
                    }
                    else insert(data, root.getLeft());
                }
            }
        }
        /// <summary>
        /// Determines whether the data requested is in the tree.
        /// </summary>
        /// <param name="data">The data that is to be found.</param>
        /// <returns>Data if it is found, otherwise null.</returns>
        public object find(IComparable data)
        {
            return find(data, froot);
        }
        /// <summary>
        /// Determines whether the data requested is in the tree.
        /// </summary>
        /// <param name="data">The data that is to be found.</param>
        /// <param name="root">The root of the current subtree.</param>
        /// <returns>Data if it is found, otherwise null.</returns>
        private object find(IComparable data, TreeNode root)
        {
            int result = 0;
            if (root == null)
                return null;
            else
            {
                result = data.CompareTo(root.getValue());
                if (result == 0)
                    return data;
                else if (result > 0)
                    return find(data, root.getRight());
                else
                    return find(data, root.getLeft());
            }
        }
        /// <summary>
        /// Deletes a node with the selected value from the tree.
        /// </summary>
        /// <param name="data">The data that is to be deleted.</param>
        /// <returns>Data, provided no errors occur.</returns>
        public object delete(IComparable data)
        {
            froot = delete(data, froot);
            return data;
        }
        /// <summary>
        /// Deletes a node with the selected value from the tree.
        /// </summary>
        /// <param name="data">The data that is to be deleted.</param>
        /// <param name="root">The root of the current subtree.</param>
        /// <returns>Data, provided no errors occur.</returns>
        private TreeNode delete(IComparable data, TreeNode root)
        {
            int comparison;
            if (root == null) return null;
            else
                comparison = data.CompareTo(root.getValue());
            if (comparison == 0)
            {
                if (isLeaf(root))
                {
                    count--;
                    return null;
                }
                else
                {
                    if (root.getLeft() != null)
                    {
                        IComparable leftMax = findMax(root.getLeft());
                        root.setValue(leftMax);
                        root.setLeft(delete(leftMax, root.getLeft()));
                        return root;
                    }
                    else
                    {
                        IComparable rightMin = findMin(root.getRight());
                        root.setValue(rightMin);
                        root.setRight(delete(rightMin, root.getRight()));
                        return root;
                    }
                } 
            }
            else if (comparison > 0)
            {
                root.setRight(delete(data, root.getRight()));
                return root;
            }
            else
            {
                root.setLeft(delete(data, root.getLeft()));
                return root;
            }
        }
        /// <summary>
        /// Determines whether a certain node is a leaf node.
        /// </summary>
        /// <param name="node">The node to be analyzed.</param>
        /// <returns>True is node is a leaf.</returns>
        private bool isLeaf(TreeNode node)
        {
            if (node == null) return false;
            else return node.getLeft() == null && node.getRight() == null;
        }
        /// <summary>
        /// Finds the maximum value of the subtree starting with the root.
        /// </summary>
        /// <param name="root">The root of the current subtree.</param>
        /// <returns>The object with the largest value.</returns>
        private IComparable findMax(TreeNode root)
        {
            if (root == null) return null;
            else if (root.getRight() == null) return (IComparable)root.getValue();
            else return findMax(root.getRight());
        }
        /// <summary>
        /// Finds the minimum value of the subtree starting with the root.
        /// </summary>
        /// <param name="root">The root of the current subtree.</param>
        /// <returns>The object with the smallest value.</returns>
        private IComparable findMin(TreeNode root)
        {
            if (root == null) return null;
            else if (root.getLeft() == null) return (IComparable)root.getValue();
            else return findMin(root.getLeft());
        }
        /// <summary>
        /// Creates a string in order of left, root, right for each node in the tree.
        /// </summary>
        /// <returns>The compiled string.</returns>
        public string toStringInOrder()
        {
            return toStringInOrder(froot);
        }
        /// <summary>
        /// Creates a string in order of left, root, right for each node in the tree.
        /// </summary>
        /// <param name="root">The root of the current subtree.</param>
        /// <returns>The compiled string.</returns>
        private string toStringInOrder(TreeNode root)
        {
            if (root != null)
            {
                return toStringInOrder(root.getLeft()) + root.getValue().ToString() + " " + toStringInOrder(root.getRight());
            }
            else return "";
        }
        /// <summary>
        /// Creates a string in order of root, left, right for each node in the tree.
        /// </summary>
        /// <returns>The compiled string.</returns>
        public string toStringPreOrder()
        {
            return toStringPreOrder(froot);
        }
        /// <summary>
        /// Creates a string in order of root, left, right for each node in the tree.
        /// </summary>
        /// <param name="root">The root of the current subtree.</param>
        /// <returns>The compiled string.</returns>
        private string toStringPreOrder(TreeNode root)
        {
            if (root != null)
            {
                return root.getValue().ToString() + " " + toStringPreOrder(root.getLeft()) + toStringPreOrder(root.getRight());
            }
            else return "";
        }
        /// <summary>
        /// Creates a string in order of left, right, root for each node in the tree.
        /// </summary>
        /// <returns>The compiled string.</returns>
        public string toStringPostOrder()
        {
            return toStringPostOrder(froot);
        }
        /// <summary>
        /// Creates a string in order of left, right, root for each node in the tree.
        /// </summary>
        /// <param name="root">The root of the current subtree.</param>
        /// <returns>The compiled string.</returns>
        private string toStringPostOrder(TreeNode root)
        {
            if (root != null)
            {
                return toStringPostOrder(root.getLeft())  + toStringPostOrder(root.getRight()) + " " + root.getValue().ToString();
            }
            else return "";
        }
        /// <summary>
        /// Finds the number of levels in the tree.
        /// </summary>
        /// <returns>The number of levels in the tree.</returns>
        public int numLevels()
        {
            return numLevels(froot);
        }
        /// <summary>
        /// Finds the number of levels in the tree.
        /// </summary>
        /// <param name="root">The root of the current subtree.</param>
        /// <returns>The number of levels in the tree.</returns>
        private int numLevels(TreeNode root)
        {
            if (root == null) return 0;
            else
            {
                int leftLevels = numLevels(root.getLeft());
                int rightLevels = numLevels(root.getRight());
                return leftLevels > rightLevels ? leftLevels + 1 : rightLevels + 1;
            }
        }
        /// <summary>
        /// Draws the binary tree.
        /// </summary>
        /// <param name="g">The surface which the tree is to be drawn on.</param>
        /// <param name="canvasWidth">The width of the surface.</param>
        public void drawTree(Graphics g, int canvasWidth)
        {
            if (froot != null)
            {
                g.DrawEllipse(new Pen(Brushes.Black), new Rectangle(canvasWidth / 2 - 5, 0,
                    froot.getValue().ToString().Length > 2 ? 10 * froot.getValue().ToString().Length : 20, 20));
                g.DrawString(froot.getValue().ToString(), new Font("Times New Roman", 12f), Brushes.Black, new Point(canvasWidth / 2, 0));
                drawTree(g, canvasWidth, froot.getLeft(), 1, new Point(canvasWidth / 2, 20), false);
                drawTree(g, canvasWidth, froot.getRight(), 1, new Point(canvasWidth / 2, 20), true); 
            }
        }
        /// <summary>
        /// Draws the binary tree.
        /// </summary>
        /// <param name="g">The surface which the tree is to be drawn on.</param>
        /// <param name="canvasWidth">The width of the surface.</param>
        /// <param name="root">The root of the current subtree.</param>
        /// <param name="level">The level of root (with the level of the overall root being 0)</param>
        /// <param name="previousLoc">The location which a line to the next node is to be drawn from.</param>
        /// <param name="right">True if the node is to be to the right of the previous node.</param>
        private void drawTree(Graphics g, int canvasWidth, TreeNode root, int level, Point previousLoc, bool right)
        {
            if (root != null)
            {
                int interval = canvasWidth / (int)Math.Pow(2, level + 1);
                Point newLoc = new Point(previousLoc.X + (right ? interval : -1 * interval), previousLoc.Y + 10);
                g.DrawLine(new Pen(Brushes.Black), previousLoc, newLoc);
                g.DrawEllipse(new Pen(Brushes.Black), new Rectangle(newLoc, 
                    new Size(root.getValue().ToString().Length > 2 ? 10 * root.getValue().ToString().Length : 20, 20)));
                g.DrawString(root.getValue().ToString(), new Font("Times New Roman", 12f), Brushes.Black, newLoc);
                drawTree(g, canvasWidth, root.getLeft(), level + 1, new Point(newLoc.X, newLoc.Y + 20), false);
                drawTree(g, canvasWidth, root.getRight(), level + 1, new Point(newLoc.X, newLoc.Y + 20), true);
            }
        }
    }

}