using System;
using System.Windows.Forms;

namespace ListTester
{
    public partial class Form1 : Form
    {
        private ListADT myList;

        public Form1()
        {
            InitializeComponent();

            myList = new ListADT();
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            //TODO: Insert new data at user-specified index.  If the index is -1, then add item to the end.
            try
            {
                myList.add(txtData.Text, Convert.ToInt32(txtIndex.Text));
                refreshScreen();
                txtData.SelectAll();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid input for index.");
                txtIndex.SelectAll();
            }
            catch (OverflowException)
            {
                MessageBox.Show("Index exceeds maximum value! Try again.");
                txtIndex.SelectAll();
            }
        }

        private void cmdRemove_Click(object sender, EventArgs e)
        {
            try
            {
                txtData.Text = myList.delete(int.Parse(txtIndex.Text)).ToString();
                refreshScreen();
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Index out of range! Try again.");
                txtIndex.SelectAll();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid input for index.");
                txtIndex.SelectAll();
            }
            catch (OverflowException)
            {
                MessageBox.Show("Index exceeds maximum value! Try again.");
                txtIndex.SelectAll();
            }
        }

        private void cmdGet_Click(object sender, EventArgs e)
        {
            try
            {
                txtData.Text = myList.get(Convert.ToInt32(txtIndex.Text)).ToString();
                refreshScreen();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid input for index.");
                txtIndex.SelectAll();
            }
            catch (OverflowException)
            {
                MessageBox.Show("Index exceeds maximum value! Try again.");
                txtIndex.SelectAll();
            }
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            myList.clear();
            refreshScreen();
        }

        private void refreshScreen()
        {
            //TODO: Refresh the list, count and empty labels.
            txtList.Text = myList.ToString();
            lblEmpty.Text = (myList.getLength() == 0).ToString();
            lblCount.Text = (myList.getLength()).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refreshScreen();
        }

        private void cmdSet_Click(object sender, EventArgs e)
        {
            try
            {
                txtData.Text = myList.set(Convert.ToInt32(txtIndex.Text), txtData.Text).ToString();
                refreshScreen();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid input for index.");
                txtIndex.SelectAll();
            }
            catch (OverflowException)
            {
                MessageBox.Show("Index exceeds maximum value! Try again.");
                txtIndex.SelectAll();
            }
        }
    }
}
