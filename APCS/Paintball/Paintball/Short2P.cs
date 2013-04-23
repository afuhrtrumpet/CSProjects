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
    public partial class Short2P : Form
    {
        private int shots = 0;
        private List<Ball> paintBalls = new List<Ball>();
        private Target secondPlayer;
        private Random locationGenerator = new Random();
        private Ball winningPaintBall;
        private SoundPlayer shotPlayer = new SoundPlayer();
        private SoundPlayer splatPlayer = new SoundPlayer();
        public Short2P()
        {
            InitializeComponent();
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
                tkbSpeed.Value, 1);
            shots = 0;
            winningPaintBall = null;
            paintBalls.Clear();
            Refresh();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            foreach (Ball ball in paintBalls)
                ball.Paint(g);
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
            Refresh();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            shots++;
            paintBalls.Add(new Ball(e.Location, new Size(5, 5), Color.Red));
            if (secondPlayer != null)
            {
                if (secondPlayer.ImHit(e.Location))
                {
                    splatPlayer.Play();
                    winningPaintBall = paintBalls[paintBalls.Count - 1];
                    MessageBox.Show("Man down! It took " + secondPlayer.lifespan() + " and " + shots + " shots to shoot down the runner.");
                }
                else
                {
                    shotPlayer.Play();
                }
            }
            Refresh();
        }

        private void Short2P_Load(object sender, EventArgs e)
        {
            shotPlayer.Stream = Paintball.Properties.Resources.pistol_01;
            shotPlayer.Load();

            splatPlayer.Stream = Paintball.Properties.Resources._327378_SOUNDDOGS__ca;
            splatPlayer.Load();
        }
    }
}