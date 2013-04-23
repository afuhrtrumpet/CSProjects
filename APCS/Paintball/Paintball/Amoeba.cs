using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace Paintball
{
    public partial class Amoeba : Form
    {
        private int shots = 0;
        private List<Ball> paintBalls = new List<Ball>();
        private List<Target> amoebas = new List<Target>();
        private Random locationGenerator = new Random();
        DateTime start;
        private SoundPlayer shotPlayer = new SoundPlayer();
        private SoundPlayer splatPlayer = new SoundPlayer();
        public Amoeba()
        {
            InitializeComponent();
            lstDuplication.SelectedIndex = 0;
        }

        private void tkbSpeed_ValueChanged(object sender, EventArgs e)
        {
            tkbSpeed.Value = (int)Math.Round((double)tkbSpeed.Value);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Form1 mainForm = new Form1();
            mainForm.Show();
            Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            amoebas.Clear();
            amoebas.Add(new Target(new Rectangle(locationGenerator.Next(pictureBox1.Size.Width - 200),
                locationGenerator.Next(pictureBox1.Size.Height - 100),
                200, 100), Paintball.Properties.Resources.amoeba, new Rectangle(0, 0, pictureBox1.Size.Width, pictureBox1.Size.Height),
                tkbSpeed.Value, 1));
            shots = 0;
            start = DateTime.Now;
            paintBalls.Clear();
            duplicationTimer.Interval = 1000 * int.Parse(lstDuplication.Text);
            moveTimer.Enabled = true;
            duplicationTimer.Enabled = true;
            Refresh();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            foreach (Ball ball in paintBalls)
                ball.Paint(g);
            if (amoebas != null)
                foreach (Target amoeba in amoebas)
                    amoeba.Paint(g);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            shots++;
            shotPlayer.Play();
            paintBalls.Add(new Ball(e.Location, new Size(5, 5), Color.Red));
            if (amoebas.Count != 0)
            {
                foreach (Target amoeba in amoebas)
                {
                    if (amoeba.ImHit(e.Location))
                    {
                        splatPlayer.Play();
                        if (amoeba.Size.Width >= 50 && amoeba.Size.Height >= 50)
                        {
                            int count = amoebas.Count > 30 ? 1 : 2;
                            for (int i = 0; i < count; i++)
                                amoebas.Add(new Target(new Rectangle(amoeba.Location, new Size(amoeba.Size.Width / 2,
                                amoeba.Size.Height / 2)), amoeba.targetImage, new Rectangle(0, 0, pictureBox1.Size.Width,
                                pictureBox1.Size.Height), amoeba.Speed, 1));
                        }
                        amoebas.Remove(amoeba);
                        if (amoebas.Count == 0)
                            MessageBox.Show("Congratulations! You beat the amoeba in " + (DateTime.Now - start) + " and " + shots + ".");
                        break;
                    }
                }
            }
            Refresh();
        }

        private void moveTimer_Tick(object sender, EventArgs e)
        {
            foreach (Target amoeba in amoebas)
            {
                if (amoeba.moveGoal == amoeba.moveProgress)
                {
                    do
                    {
                        amoeba.moveProgress = 0;
                        int direction = locationGenerator.Next(4);
                        switch (direction)
                        {
                            case 0: if (amoeba.Size.Height == amoeba.Size.Width * 2)
                                    amoeba.Size = new Size(amoeba.Size.Height, amoeba.Size.Width);
                                amoeba.targetImage = Paintball.Properties.Resources.amoeba;
                                amoeba.moveGoal = locationGenerator.Next((pictureBox1.Location.X + pictureBox1.Size.Width -
                                (amoeba.Location.X + amoeba.Size.Width)) / amoeba.Speed);
                                amoeba.currentDirection = Target.Direction.Right;
                                break;
                            case 1: if (amoeba.Size.Height == amoeba.Size.Width * 2)
                                    amoeba.Size = new Size(amoeba.Size.Height, amoeba.Size.Width);
                                amoeba.targetImage = Paintball.Properties.Resources.amoebaright;
                                amoeba.moveGoal = locationGenerator.Next(amoeba.Location.X / amoeba.Speed);
                                amoeba.currentDirection = Target.Direction.Left;
                                break;
                            case 2: if (amoeba.Size.Width == amoeba.Size.Height * 2)
                                    amoeba.Size = new Size(amoeba.Size.Height, amoeba.Size.Width);
                                amoeba.targetImage = Paintball.Properties.Resources.amoebadown;
                                amoeba.moveGoal = locationGenerator.Next(1, (pictureBox1.Location.Y + pictureBox1.Size.Height -
                                (amoeba.Location.Y + amoeba.Size.Height)) / amoeba.Speed);
                                amoeba.currentDirection = Target.Direction.Down;
                                break;
                            case 3: if (amoeba.Size.Width == amoeba.Size.Height * 2)
                                    amoeba.Size = new Size(amoeba.Size.Height, amoeba.Size.Width);
                                amoeba.targetImage = Paintball.Properties.Resources.amoebaup;
                                amoeba.moveGoal = locationGenerator.Next(amoeba.Location.Y / amoeba.Speed);
                                amoeba.currentDirection = Target.Direction.Up;
                                break;
                        }
                    } while (amoeba.moveGoal == 0);
                }
                amoeba.Move(amoeba.currentDirection);
                amoeba.moveProgress++;
                Refresh();
            }
        }

        private void duplicationTimer_Tick(object sender, EventArgs e)
        {
            int originalLength = amoebas.Count;
            for (int i = 0; i < originalLength; i++)
            {
                if (amoebas.Count <= 30)
                {
                    amoebas.Add(new Target(new Rectangle(amoebas[i].Location, amoebas[i].Size), amoebas[i].targetImage,
                                new Rectangle(0, 0, pictureBox1.Size.Width, pictureBox1.Size.Height), amoebas[i].Speed, 1));
                }
            }
            Refresh();
        }

        private void Amoeba_Load(object sender, EventArgs e)
        {
            shotPlayer.Stream = Paintball.Properties.Resources.pistol_01;
            shotPlayer.Load();

            splatPlayer.Stream = Paintball.Properties.Resources._327378_SOUNDDOGS__ca;
            splatPlayer.Load();
        }
    }
}