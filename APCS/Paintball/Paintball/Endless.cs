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
    public partial class Endless : Form
    {
        private int randomInterval = 6;
        private int spawnCount = 0;
        private int lives;
        private List<Ball> paintBalls = new List<Ball>();
        private List<BombTarget> bombs = new List<BombTarget>();
        private Random locationGenerator = new Random();
        private int speed;
        DateTime start;
        private SoundPlayer shotPlayer = new SoundPlayer();
        private SoundPlayer splatPlayer = new SoundPlayer();
        private SoundPlayer explosionPlayer = new SoundPlayer();
        public Endless()
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
            bombs.Clear();
            speed = tkbSpeed.Value;
            bombs.Add(new BombTarget(new Rectangle(locationGenerator.Next(pictureBox1.Size.Width - 52),
                locationGenerator.Next(pictureBox1.Size.Height - 68),
                52, 68), Paintball.Properties.Resources.bombfull, new Rectangle(0, 0, pictureBox1.Size.Width, pictureBox1.Size.Height),
                speed, 1));
            start = DateTime.Now;
            lives = int.Parse(lstLives.Text);
            lblLives.Text = "Lives:\n" + lives;
            paintBalls.Clear();
            bombTimer.Enabled = true;
            moveTimer.Enabled = true;
            Refresh();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            foreach (Ball ball in paintBalls)
                ball.Paint(g);
            if (bombs != null)
                foreach (BombTarget bomb in bombs)
                    bomb.Paint(g);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            shotPlayer.Play();
            paintBalls.Add(new Ball(e.Location, new Size(5, 5), Color.Red));
            if (bombs.Count != 0)
            {
                foreach (BombTarget bomb in bombs)
                {
                    if (bomb.ImHit(e.Location) && bomb.Countdown != 0)
                    {
                        splatPlayer.Play();
                        bombs.Remove(bomb);
                        break;
                    }
                } 
            }
            Refresh();
        }

        private void moveTimer_Tick(object sender, EventArgs e)
        {
            foreach (BombTarget bomb in bombs)
            {
                if (bomb.Countdown != 0)
                {
                    if (bomb.moveGoal == bomb.moveProgress)
                    {
                        do
                        {
                            bomb.moveProgress = 0;
                            int direction = locationGenerator.Next(4);
                            switch (direction)
                            {
                                case 0: if (bomb.Size.Height == bomb.Size.Width * 2)
                                        bomb.Size = new Size(bomb.Size.Height, bomb.Size.Width);
                                    bomb.moveGoal = locationGenerator.Next((pictureBox1.Location.X + pictureBox1.Size.Width -
                                    (bomb.Location.X + bomb.Size.Width)) / bomb.Speed);
                                    bomb.currentDirection = BombTarget.Direction.Right;
                                    break;
                                case 1: if (bomb.Size.Height == bomb.Size.Width * 2)
                                        bomb.Size = new Size(bomb.Size.Height, bomb.Size.Width);
                                    bomb.moveGoal = locationGenerator.Next(bomb.Location.X / bomb.Speed);
                                    bomb.currentDirection = BombTarget.Direction.Left;
                                    break;
                                case 2: if (bomb.Size.Width == bomb.Size.Height * 2)
                                        bomb.Size = new Size(bomb.Size.Height, bomb.Size.Width);
                                    bomb.moveGoal = locationGenerator.Next(1, (pictureBox1.Location.Y + pictureBox1.Size.Height -
                                    (bomb.Location.Y + bomb.Size.Height)) / bomb.Speed);
                                    bomb.currentDirection = BombTarget.Direction.Down;
                                    break;
                                case 3: if (bomb.Size.Width == bomb.Size.Height * 2)
                                        bomb.Size = new Size(bomb.Size.Height, bomb.Size.Width);
                                    bomb.moveGoal = locationGenerator.Next(bomb.Location.Y / bomb.Speed);
                                    bomb.currentDirection = BombTarget.Direction.Up;
                                    break;
                            }
                        } while (bomb.moveGoal == 0);
                    }
                    bomb.Move(bomb.currentDirection);
                    bomb.moveProgress++; 
                }
            }
            Refresh();
        }

        private void bombTimer_Tick(object sender, EventArgs e)
        {
            int count = bombs.Count;
            for (int i = 0; i < count; i++)
            {
                while (bombs[i].Tick())
                {
                    bombs.Remove(bombs[i]);
                    lives--;
                    lblLives.Text = "Lives:\n" + lives;
                    if (lives == 0)
                    {
                        TimeSpan interval = DateTime.Now - start;
                        bombTimer.Enabled = false;
                        moveTimer.Enabled = false;
                        MessageBox.Show("Game over! You lasted for " + interval + ".");
                    }
                    if (bombs.Count == 0) break;
                }
                if (bombs.Count == 0) break;
                switch (bombs[i].Countdown)
                {
                    case 7: bombs[i].targetImage = Paintball.Properties.Resources.bombone; break;
                    case 6: bombs[i].targetImage = Paintball.Properties.Resources.bombtwo; break;
                    case 5: bombs[i].targetImage = Paintball.Properties.Resources.bombthree; break;
                    case 4: bombs[i].targetImage = Paintball.Properties.Resources.bombfour; break;
                    case 3: bombs[i].targetImage = Paintball.Properties.Resources.bombfive; break;
                    case 2: bombs[i].targetImage = Paintball.Properties.Resources.bombsix; break;
                    case 1: bombs[i].targetImage = Paintball.Properties.Resources.bombseven; break;
                    case 0: bombs[i].targetImage = Paintball.Properties.Resources.bombexplode; explosionPlayer.Play(); break;
                }
                count = bombs.Count;
            }
            if (locationGenerator.Next(randomInterval) == 1)
            {
                bombs.Add(new BombTarget(new Rectangle(locationGenerator.Next(pictureBox1.Size.Width - 52),
                locationGenerator.Next(pictureBox1.Size.Height - 68),
                52, 68), Paintball.Properties.Resources.bombfull, new Rectangle(0, 0, pictureBox1.Size.Width, pictureBox1.Size.Height),
                speed, 1));
                spawnCount++;
                if (spawnCount % 3 == 0 && randomInterval <= 3)
                {
                    randomInterval--;
                }
                if (spawnCount % 4 == 0)
                {
                    foreach (BombTarget bomb in bombs)
                    {
                        bomb.Speed += 2;
                    }
                    speed += 2;
                }
            }
            Refresh();
        }

        private void Endless_Load(object sender, EventArgs e)
        {
            shotPlayer.Stream = Paintball.Properties.Resources.pistol_01;
            shotPlayer.Load();

            splatPlayer.Stream = Paintball.Properties.Resources._327378_SOUNDDOGS__ca;
            splatPlayer.Load();

            explosionPlayer.Stream = Paintball.Properties.Resources.bomb_02;
            explosionPlayer.Load();
        }
    }
}
