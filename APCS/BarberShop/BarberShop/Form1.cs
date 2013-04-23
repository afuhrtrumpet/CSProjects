using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BarberShop
{
    public partial class Form1 : Form
    {
        public const int MAX_CHAIRS = 3;
        public const int TIME_INTERVAL = 5;
        private QueueADT queue;
        private BarberChair[] chairs;
        private CheckBox[] chkChairs;
        private Label[] lblChairs;
        private System.Random gen;
        private int simulationClock;
        private int customerCount;
        private int totalWaitTime;
        private int barberDownTime;
        private bool simulationOver;
        private int simulationEnd;

        public Form1()
        {
            InitializeComponent();

            queue = new QueueADT();

            chkChairs = new CheckBox[MAX_CHAIRS];
            chkChairs[0] = chkChair1;
            chkChairs[1] = chkChair2;
            chkChairs[2] = chkChair3;

            lblChairs = new Label[MAX_CHAIRS];
            lblChairs[0] = lblChair1;
            lblChairs[1] = lblChair2;
            lblChairs[2] = lblChair3;

            chairs = new BarberChair[MAX_CHAIRS];
            for (int x = 0; x < chairs.Length; x++)
                chairs[x] = new BarberChair();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string seed = seedText.Text;
            if (seed == "")
                gen = new System.Random();
            else
                try
                {
                    gen = new System.Random(Convert.ToInt32(seed));
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Invalid integer value.");
                    return;
                }
            try
            {
                simulationEnd = int.Parse(simEndtext.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid integer value.");
            }
            btnStart.Enabled = false;
            simulationOver = false;
            timer1.Start();

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (!simulationOver)
            {
                btnStart.Enabled = true;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            simulationClock = 0;
            customerCount = 0;
            totalWaitTime = 0;
            barberDownTime = 0;
            queue = new QueueADT();
            txtQueue.Text = ("");
            lblStats.Text = ("");
            for (int lcv = 0; lcv < chairs.Length; lcv++)
            {
                chairs[lcv] = new BarberChair();
                lblChairs[lcv].Text = ("");
            }
            btnStart.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Try block is to catch errors in changing of max customer box.
            try
            {
                int maxCust = int.Parse(txtMaxCust.Text);
                if (maxCust > 10) maxCust = 10;  //No more than 10 customers at a time.
                int customers = gen.Next(maxCust + 1); //Generate number of new arrivals.
                for (int i = 0; i < customers; i++)
                {
                    queue.add(new Customer(simulationClock, gen.Next(1, 4) * 5)); //Add new arrivals to the queue.
                }
                for (int i = 0; i < chairs.Length; i++)
                {
                    chairs[i].setActive(chkChairs[i].Checked); //Sets chair status to agree with corresponding checkbox.
                    if (chairs[i].isEmpty() && chairs[i].isActive() && !queue.isEmpty()) //Determines if conditions are right to put a customer in the chair.
                    {
                        Customer currentCust = (Customer)queue.remove();
                        totalWaitTime += simulationClock - currentCust.getEntryTime(); //Updates total wait time.
                        chairs[i].setJobTime(currentCust.getServiceTime()); //Fills chair.
                        customerCount++;
                    }
                    else if (queue.isEmpty() && chairs[i].isActive() && chairs[i].isEmpty()) //Checks to see whether chair is active but not doing anything.
                    {
                        barberDownTime += TIME_INTERVAL;
                    }
                    if (chairs[i].isNewCustomer()) lblChairs[i].Text = "*" + chairs[i].getJobTime().ToString(); //Determines whether asterisk should be added.
                    else lblChairs[i].Text = chairs[i].getJobTime().ToString(); //Sets label text.
                    chairs[i].cutHair(TIME_INTERVAL); //Cuts hair.
                }
                double avg = 0;
                if (totalWaitTime > 0)
                    avg = (double)totalWaitTime / customerCount;

                simulationClock += TIME_INTERVAL;
                lblStats.Text = (
                    "Minutes Elapsed = " + simulationClock + "\n" +
                    "New Arrivals = " + customers + "\n" +
                    "Customers in Queue = " + queue.size() + "\n" +
                    "Customer Count = " + customerCount + "\n" +
                    "Total Wait Time = " + totalWaitTime + "\n" +
                    "Avg wait = " + string.Format("{0:#####.0}", avg) + "\n" +
                    "Down Time = " + barberDownTime + "\n"
                    );

                txtQueue.Text = queue.ToString();

                if (queue.size() > 1000)
                {
                    simulationOver = true;
                    timer1.Stop();
                    MessageBox.Show("There are more than 1000 customers waiting in the queue!  You might as well give up and quit.", "You're a lousy manager.");
                }
                else if (simulationClock >= simulationEnd)
                {
                    simulationOver = true;
                    timer1.Stop();
                    MessageBox.Show("The simulation is over because time has expired.");
                }
            }
            catch (FormatException) //Catches error in max customer box.
            {
                timer1.Stop();
                MessageBox.Show("Invalid numeric input!");
                if (!simulationOver)
                {
                    btnStart.Enabled = true;
                }
            }

        }
    }
}
