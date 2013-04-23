using System;
using System.Windows.Forms;

namespace TreeTester
{
    public partial class Form1 : Form
    {
        TreeADT myTree;

        public Form1()
        {
            InitializeComponent();
            myTree = new TreeADT();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void refresh()
        {
            lblLevels.Text = myTree.numLevels().ToString();
            lblInOrder.Text = (myTree.toStringInOrder());
            lblPreOrder.Text = (myTree.toStringPreOrder());
            lblPostOrder.Text = (myTree.toStringPostOrder());
            lblCount.Text = (myTree.length().ToString());
            lblEmpty.Text = (myTree.isEmpty() ? "yes" : "no");
            txtInput.Clear();
            lblResult.Text = ("");
        }


        private void cmdInsert_Click(object sender, EventArgs e)
        {
            try
            {
                int data = Convert.ToInt32(txtInput.Text);
                
                myTree.insert(data);
                refresh();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Invalid data.  Try a number.");
            }

        }

        private void cmdFind_Click(object sender, EventArgs e)
        {
            try
            {
                int data = Convert.ToInt32(txtInput.Text);
                object result = myTree.find(data);
                if (result == null)
                    lblResult.Text = ("not there");
                else
                    lblResult.Text = (result.ToString());
                txtInput.Clear();
                txtInput.Focus();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Invalid data.  Try a number.");
            }

        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int data = Convert.ToInt32(txtInput.Text);
                lblResult.Text = myTree.delete(data).ToString();
                refresh();
                txtInput.Focus();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Invalid data.  Try a number.");
            }

        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            myTree = new TreeADT();
            refresh();
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            TreeDisplay disp = new TreeDisplay(myTree);
            disp.Show();
        }
    }
}
