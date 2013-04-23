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
    public partial class Long2P : Form
    {
        private int shots;
        private List<Ball> paintBalls = new List<Ball>();
        private Target secondPlayer;
        private Random locationGenerator = new Random();
        private Powerup currentPower;
        private int originalSpeed;
        private Ball winningPaintBall;
        private SoundPlayer shotPlayer = new SoundPlayer();
        private SoundPlayer splatPlayer = new SoundPlayer();
        public Long2P()
        {
            InitializeComponent();
            lstLives.SelectedIndex = 0;
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
            secondPlayer = new Target(new Rectangle(locationGenerator.Next(pictureBox1.Size.Width - 21),
                locationGenerator.Next(pictureBox1.Size.Height - 41),
                21, 41), Paintball.Properties.Resources.runningmanleft, new Rectangle(0, 0, pictureBox1.Size.Width, pictureBox1.Size.Height),
                tkbSpeed.Value, int.Parse(lstLives.Text));
            shots = 0;
            originalSpeed = tkbSpeed.Value;
            winningPaintBall = null;
            paintBalls.Clear();
            powerUpTimer.Enabled = true;
            lblLives.Text = "Lives:\n " + secondPlayer.numberOfLives;
            Refresh();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            foreach (Ball ball in paintBalls)
                ball.Paint(g);
            if (currentPower != null)
            {
                currentPower.Paint(g); 
            }
            if (secondPlayer != null)
                secondPlayer.Paint(g);
            if (winningPaintBall != null)
                winningPaintBall.Paint(g);
        }

        private void Short2P_KeyDown(object sender, KeyEventArgs e)
        {
            if (secondPlayer == null) return;
            Target.Direction moveDirection;
            switch (e.KeyData)
            {
                case Keys.Left: moveDirection = Target.Direction.Left;
                    secondPlayer.targetImage = Paintball.Properties.Resources.runningmanleft; break;
                case Keys.Right: moveDirection = Target.Direction.Right;
                    secondPlayer.targetImage = Paintball.Properties.Resources.runningmanright; break;
                case Keys.Up: moveDirection = Target.Direction.Up; break;
                case Keys.Down: moveDirection = Target.Direction.Down; break;
                default: return;
            }
            secondPlayer.Move(moveDirection);
            if (currentPower != null)
            {
                if (secondPlayer.Rectangle.IntersectsWith(currentPower.Rectangle))
                {
                    switch (currentPower.PowerType)
                    {
                        case Powerup.Type.Shrink: secondPlayer.Size = new Size(10, 20); break;
                        case Powerup.Type.Confusion: secondPlayer.Location = new Point(locationGenerator.Next(pictureBox1.Size.Width - 21),
                    locationGenerator.Next(pictureBox1.Size.Height - 41)); break;
                        case Powerup.Type.SpeedUp: secondPlayer.Speed = originalSpeed * 2; break;
                    }
                    powerStartTimer.Enabled = false;
                    powerStartTimer.Enabled = true;
                    currentPower = null;
                }
            }
            Refresh();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            shots++;
            int currentLives = secondPlayer.numberOfLives;
            paintBalls.Add(new Ball(e.Location, new Size(5, 5), Color.Red));
            if (secondPlayer != null)
            {
                if (secondPlayer.ImHit(e.Location))
                {
                    splatPlayer.Play();
                    winningPaintBall = paintBalls[paintBalls.Count - 1];
                    MessageBox.Show("Man down! It took " + secondPlayer.lifespan() + " and " + shots + " shots to shoot down the runner.");
                    powerAppearTimer.Enabled = false;
                    powerStartTimer.Enabled = false;
                    powerUpTimer.Enabled = false;
                }
                else if (secondPlayer.numberOfLives != currentLives)
                    splatPlayer.Play();
                else shotPlayer.Play();
                lblLives.Text = "Lives:\n " + secondPlayer.numberOfLives;
            }    
            Refresh();
        }

        private void powerUpTimer_Tick(object sender, EventArgs e)
        {
            if (currentPower == null)
            {
                int number = locationGenerator.Next(12);
                if (number == 5)
                {
                    int typeNumber = locationGenerator.Next(3);
                    Powerup.Type type = Powerup.Type.Shrink;
                    switch (typeNumber)
                    {
                        case 0: type = Powerup.Type.Shrink; break;
                        case 1: type = Powerup.Type.Confusion; break;
                        case 2: type = Powerup.Type.SpeedUp; break;
                    }
                    currentPower = new Powerup(new Point(locationGenerator.Next(pictureBox1.Size.Width - 25),
                    locationGenerator.Next(pictureBox1.Size.Height - 25)), new Size(25, 25), type);
                    powerAppearTimer.Enabled = true;
                    Refresh();
                } 
            }
        }

        private void powerAppearTimer_Tick(object sender, EventArgs e)
        {
            currentPower = null;
            powerAppearTimer.Enabled = false;
            Refresh();
        }

        private void powerStartTimer_Tick(object sender, EventArgs e)
        {
            secondPlayer.Speed = originalSpeed;
            secondPlayer.Size = new Size(21, 41);
            powerStartTimer.Enabled = false;
            Refresh();
        }

        private void Long2P_Load(object sender, EventArgs e)
        {
            shotPlayer.Stream = Paintball.Properties.Resources.pistol_01;
            shotPlayer.Load();

            splatPlayer.Stream = Paintball.Properties.Resources._327378_SOUNDDOGS__ca;
            splatPlayer.Load();
        }
    }
}
