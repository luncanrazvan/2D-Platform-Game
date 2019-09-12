using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        bool goingRight;
        bool goingLeft;
        bool jumping;
        bool bossGoingUp=true;
        bool bossGoingDown=false;
        bool hasMovedRight = true;
        bool hasMovedLeft = false;
        bool hasMovedLeftJmp;
        bool hasMovedRightJmp;
        int gravity = 20;
        int ok = 0;
        int hearts;
        int force;
        int ticks = 0;
        bool ableToCollideWithBoss = true;
        bool gotTheStar = false;
        int numberOfBossLifes = 3;
        bool ableToFire = true;
        bool createdBullet = false;
        bool hasFiredFromRight = true;
        bool hasFiredFromLeft = false;

        public Form3(int life)
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.hearts = life;
            switch (hearts)
            {
                case 0:
                    pictureBoxHeart1.Visible = false;
                    pictureBoxHeart2.Visible = false;
                    pictureBoxHeart3.Visible = false;
                    break;
                case 1:
                    pictureBoxHeart3.Visible = false;
                    pictureBoxHeart2.Visible = false;
                    break;
                case 2:
                    pictureBoxHeart3.Visible = false;
                    break;
                default:
                    break;
            }
        }

        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                hasMovedRight = true;
                hasMovedLeft = false;
                goingRight = true;
                goingLeft = false;
                if (Character.Right >= gamePanel3.Width)
                {
                   

                }
            }

            if (e.KeyCode == Keys.Left)
            {
                goingLeft = true;
                goingRight = false;
                hasMovedRight = false;
                hasMovedLeft = true;
            }

            if (e.KeyCode == Keys.Space)
            {
                if (ableToFire)
                {
                    ableToFire = false;
                    System.IO.Stream str = WindowsFormsApp1.Properties.Resources.Laser_Shoot1;
                    System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                    snd.Play();
                    if ((goingRight || hasMovedRight) && !createdBullet)
                    {
                        createdBullet = true;
                        hasFiredFromRight = true;
                        hasFiredFromLeft = false;
                        pictureBoxBullet.Location = new Point(Character.Location.X + 90, Character.Location.Y + 34);
                    }
                    else if ((goingLeft || hasMovedLeft) && !createdBullet)
                    {
                        createdBullet = true;
                        hasFiredFromRight = false;
                        hasFiredFromLeft = true;
                        pictureBoxBullet.Location = new Point(Character.Location.X - 44, Character.Location.Y + 31);
                    }

                    pictureBoxBullet.Visible = true;
                }
            }

            if (!jumping)
            {
                if (e.KeyCode == Keys.Up)
                {
                    System.IO.Stream str = WindowsFormsApp1.Properties.Resources.Sweep5;
                    System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                    snd.Play();
                    jumping = true;
                    force = gravity;
                    ok = 1;
                }
            }
        }


        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }


        private void BossTimer_Tick(object sender, EventArgs e)
        {
            if (hearts == -1)
            {
                this.Close();
                Form5 form5 = new Form5();
                form5.Show();
                bossTimer.Enabled = false;

            }
            if (pictureBoxBullet.Visible == true && hasFiredFromRight)
            {
                pictureBoxBullet.Left += 5;
            }
            else if (pictureBoxBullet.Visible == true && hasFiredFromLeft)
            {
                pictureBoxBullet.Left -= 5;
            }
            if (bossGoingUp)
            {
                pictureBoxBoss.Top -= 5;
            }
            if (bossGoingDown)
            {
                pictureBoxBoss.Top += 5;
            }
            if (pictureBoxBoss.Top <= 0)
            {
                bossGoingUp = false;
                bossGoingDown = true;
            }
            if (pictureBoxBoss.Bottom >= gamePanel3.Height)
            {
                bossGoingUp = true;
                bossGoingDown = false;
            }
            if (Character.Bounds.IntersectsWith(pictureBoxBoss.Bounds) && ableToCollideWithBoss && pictureBoxBoss.Visible==true)
            {
                System.IO.Stream str = WindowsFormsApp1.Properties.Resources.Distorted_Message2;
                System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                snd.Play();

                ableToCollideWithBoss = false;
                hearts--;
                if (hearts == 2)
                {

                    pictureBoxHeart3.Visible = false;
                }
                else if (hearts == 1)
                {
                    pictureBoxHeart3.Visible = false;
                    pictureBoxHeart2.Visible = false;
                }
                else if (hearts == 0)
                {
                    pictureBoxHeart3.Visible = false;
                    pictureBoxHeart2.Visible = false;
                    pictureBoxHeart1.Visible = false;
                }
            }
            if (Character.Bounds.IntersectsWith(pictureBoxStar.Bounds) && pictureBoxStar.Visible == true)
            {
                System.IO.Stream str = WindowsFormsApp1.Properties.Resources.Beep1;
                System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                snd.Play();

                pictureBoxStar.Visible = false;
                gotTheStar = true;
            }
            if (Character.Bounds.IntersectsWith(bananaPictureBox.Bounds) && bananaPictureBox.Visible == true)
            {
                System.IO.Stream str = WindowsFormsApp1.Properties.Resources.Beep3;
                System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                snd.Play();

                bananaPictureBox.Visible = false;
                if (hearts < 3)
                {
                    if (pictureBoxHeart1.Visible == false)
                    {
                        pictureBoxHeart1.Visible = true;
                    }
                    else if (pictureBoxHeart2.Visible == false)
                    {
                        pictureBoxHeart2.Visible = true;
                        hearts++;
                    }
                    else if (pictureBoxHeart3.Visible == false)
                    {
                        pictureBoxHeart3.Visible = true;
                        hearts++;
                    }
                }
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

            if(gotTheStar && pictureBoxBoss.Visible == false)
            {
                this.Close();
                Form4 form4 = new Form4();
                form4.Show();
                timer1.Enabled = false;
                 
            }

            if (goingRight && Character.Right < gamePanel3.Width)
            {
                Character.Left += 5;
            }
            if (goingLeft && Character.Left >= 0)
            {
                Character.Left -= 5;
            }
            if (jumping)
            {

                if (hasMovedLeft)
                {
                    hasMovedLeftJmp = true;
                    hasMovedRightJmp = false;
                    Character.Image = WindowsFormsApp1.Properties.Resources.megaManJumpLeft;
                }

                if (hasMovedRight)
                {
                    hasMovedLeftJmp = false;
                    hasMovedRightJmp = true;
                    Character.Image = WindowsFormsApp1.Properties.Resources.megaManJumpRight;
                }

                Character.Top -= force;
                force -= 1;

                if (goingLeft)
                {
                    Character.Image = WindowsFormsApp1.Properties.Resources.megaManJumpLeft;
                }
                if (goingRight)
                {
                    Character.Image = WindowsFormsApp1.Properties.Resources.megaManJumpRight;
                }

            }
            else
            {
                if (goingLeft)
                {
                    Character.Image = WindowsFormsApp1.Properties.Resources.megaManMovingLeft;
                }
                if (goingRight)
                {
                    Character.Image = WindowsFormsApp1.Properties.Resources.megaManMovingRight;
                }

            }

            if (Character.Top + Character.Height >= gamePanel3.Height && ok == 1)
            {
                ok = 0;
                Character.Top = gamePanel3.Height - Character.Height;
                if (hasMovedLeft)
                {
                    Character.Image = WindowsFormsApp1.Properties.Resources.megaManStaionaryLeft;

                }
                else if (hasMovedRight)
                {
                    Character.Image = WindowsFormsApp1.Properties.Resources.megaManStaionaryRight;

                }
                jumping = false;


            }

            if (Character.Bottom >= brownBrickPlatform1.Top && Character.Top < brownBrickPlatform1.Top && Character.Right >= brownBrickPlatform1.Left && Character.Left <= brownBrickPlatform1.Right)
            {
                Character.Top = brownBrickPlatform1.Height - Character.Height + brownBrickPlatform1.Top - brownBrickPlatform1.Height;
                if (hasMovedLeft)
                {
                    Character.Image = WindowsFormsApp1.Properties.Resources.megaManStaionaryLeft;

                }
                else if (hasMovedRight)
                {
                    Character.Image = WindowsFormsApp1.Properties.Resources.megaManStaionaryRight;

                }
                if (goingLeft)
                {
                    Character.Image = WindowsFormsApp1.Properties.Resources.megaManMovingLeft;
                }
                if (goingRight)
                {
                    Character.Image = WindowsFormsApp1.Properties.Resources.megaManMovingRight;
                }
                jumping = false;
            }

            if (Character.Top == brownBrickPlatform1.Height - Character.Height + brownBrickPlatform1.Top - brownBrickPlatform1.Height && (Character.Right < brownBrickPlatform1.Left || Character.Left > brownBrickPlatform1.Right))
            {
                jumping = true;
            }
            if (Character.Top <= brownBrickPlatform1.Bottom && Character.Right >= brownBrickPlatform1.Left && Character.Left <= brownBrickPlatform1.Right && Character.Bottom > brownBrickPlatform1.Top)
            {
                force = 0;
                Character.Top -= force;
                force -= 1;
            }

            if (Character.Bottom >= brownBrickPlatform2.Top && Character.Top < brownBrickPlatform2.Top && Character.Right >= brownBrickPlatform2.Left && Character.Left <= brownBrickPlatform2.Right)
            {
                Character.Top = brownBrickPlatform2.Height - Character.Height + brownBrickPlatform2.Top - brownBrickPlatform2.Height;
                if (hasMovedLeft)
                {
                    Character.Image = WindowsFormsApp1.Properties.Resources.megaManStaionaryLeft;

                }
                else if (hasMovedRight)
                {
                    Character.Image = WindowsFormsApp1.Properties.Resources.megaManStaionaryRight;

                }
                if (goingLeft)
                {
                    Character.Image = WindowsFormsApp1.Properties.Resources.megaManMovingLeft;
                }
                if (goingRight)
                {
                    Character.Image = WindowsFormsApp1.Properties.Resources.megaManMovingRight;
                }
                jumping = false;
            }
            if (Character.Top == brownBrickPlatform2.Height - Character.Height + brownBrickPlatform2.Top - brownBrickPlatform2.Height && (Character.Right < brownBrickPlatform2.Left || Character.Left > brownBrickPlatform2.Right))
            {
                jumping = true;
            }
            if (Character.Top <= brownBrickPlatform2.Bottom && Character.Right >= brownBrickPlatform2.Left && Character.Left <= brownBrickPlatform2.Right && Character.Bottom > brownBrickPlatform2.Top)
            {
                force = 0;
                Character.Top -= force;
                force -= 1;

            }
            if (Character.Top == brownBrickPlatform3.Height - Character.Height + brownBrickPlatform3.Top - brownBrickPlatform3.Height && brownBrickPlatform3.Visible == false)
            {
                jumping = true;
            }
            if (Character.Bottom >= brownBrickPlatform3.Top && Character.Top < brownBrickPlatform3.Top && Character.Right >= brownBrickPlatform3.Left && Character.Left <= brownBrickPlatform3.Right && brownBrickPlatform3.Visible == true)
            {
                Character.Top = brownBrickPlatform3.Height - Character.Height + brownBrickPlatform3.Top - brownBrickPlatform3.Height;
                if (hasMovedLeft)
                {
                    Character.Image = WindowsFormsApp1.Properties.Resources.megaManStaionaryLeft;

                }
                else if (hasMovedRight)
                {
                    Character.Image = WindowsFormsApp1.Properties.Resources.megaManStaionaryRight;

                }
                if (goingLeft)
                {
                    Character.Image = WindowsFormsApp1.Properties.Resources.megaManMovingLeft;
                }
                if (goingRight)
                {
                    Character.Image = WindowsFormsApp1.Properties.Resources.megaManMovingRight;
                }
                jumping = false;
                if (brownBrickPlatform3.Visible == false)
                {
                    jumping = true;
                }
            }
            if (Character.Top == brownBrickPlatform3.Height - Character.Height + brownBrickPlatform3.Top - brownBrickPlatform3.Height && (Character.Right < brownBrickPlatform3.Left || Character.Left > brownBrickPlatform3.Right))
            {
                jumping = true;
            }
            if (Character.Top <= brownBrickPlatform3.Bottom && Character.Right >= brownBrickPlatform3.Left && Character.Left <= brownBrickPlatform3.Right && Character.Bottom > brownBrickPlatform3.Top && brownBrickPlatform3.Visible == true)
            {
                force = 0;
                Character.Top -= force;
                force -= 1;

            }
            if ((pictureBoxBullet.Bounds.IntersectsWith(brownBrickPlatform3.Bounds) || pictureBoxBullet.Bounds.IntersectsWith(brownBrickPlatform3.Bounds)
                || pictureBoxBullet.Left <= 0 || pictureBoxBullet.Right >= gamePanel3.Width) || (pictureBoxBullet.Bounds.IntersectsWith(brownBrickPlatform3.Bounds) && brownBrickPlatform3.Visible == true) && pictureBoxBullet.Visible == true)
            {
                createdBullet = false;
                pictureBoxBullet.Visible = false;
                ableToFire = true;
            }
        }

        private void Form3_KeyUp_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                goingRight = false;
                hasMovedRight = true;
                hasMovedLeft = false;
                if (!jumping)
                {
                    Character.Image = WindowsFormsApp1.Properties.Resources.megaManStaionaryRight;
                }

            }
            if (e.KeyCode == Keys.Left)
            {
                goingLeft = false;
                hasMovedRight = false;
                hasMovedLeft = true;
                if (!jumping)
                {
                    Character.Image = WindowsFormsApp1.Properties.Resources.megaManStaionaryLeft;
                }
            }
        }

        private void CollisonTimer_Tick(object sender, EventArgs e)
        {
            ticks++;
            if (ticks == 5)
            {
                ticks = 0;
                ableToCollideWithBoss = true;
            }
            if (pictureBoxBullet.Bounds.IntersectsWith(pictureBoxBoss.Bounds) && pictureBoxBoss.Visible == true && pictureBoxBullet.Visible==true)
            {
                createdBullet = false;
                pictureBoxBullet.Visible = false;
                ableToFire = true;
                numberOfBossLifes--;
                if (numberOfBossLifes == 0)
                {
                    pictureBoxBoss.Visible = false;
                }
                System.IO.Stream str = WindowsFormsApp1.Properties.Resources.Explosion2;
                System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                snd.Play();
            }

        }
    }
}