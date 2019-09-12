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
    public partial class Form2 : Form
    {

        bool beholderGoingRight=true;
        bool beholderGoingLeft=false;
        bool goingRight;
        bool goingLeft;
        bool jumping;
        bool hasMovedRight = true;
        bool hasMovedLeft = false;
        bool hasMovedLeftJmp;
        bool hasMovedRightJmp;
        int gravity = 20;
        int ok = 0;
        int hearts;
        int force;
        int ticks=0;
        bool ableToCollideWithDragon=true;
        bool ableToCollideWithGhost1 = true;
        bool ableToCollideWithGhost2 = true;
        bool gotTheKey = false;
        int numberOfCaughtKeys = 0;
        bool ghost1GoingLeft=true;
        bool ghost1GoingRight = false;
        bool ghost2GoingLeft=false;
        bool ghost2GoingRight=true;
        bool ableToFire = true;
        bool createdBullet = false;
        bool hasFiredFromRight = true;
        bool hasFiredFromLeft = false;
        public Form2(int life)
        {
            this.hearts = life;
            
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            pictureBoxArrowRight.Visible = false;
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

        

        private void TimerBeholder_Tick(object sender, EventArgs e)
        {
            
            if (beholderGoingRight)
            {
                
                dragonEnemy.BackgroundImage = WindowsFormsApp1.Properties.Resources._8bit_DragonRight;
                dragonEnemy.Left += 5;
                if (dragonEnemy.Right >= gamePanel2.Width)
                {
                    beholderGoingRight = false;
                    beholderGoingLeft = true;
                }
            }

            if (beholderGoingLeft)
            {
                dragonEnemy.BackgroundImage = WindowsFormsApp1.Properties.Resources._8bit_Dragon;
                dragonEnemy.Left -= 5;
                if (dragonEnemy.Left <= 0)
                {
                    beholderGoingRight = true;
                    beholderGoingLeft = false;
                }
            }

            if(Character.Bounds.IntersectsWith(dragonEnemy.Bounds) && ableToCollideWithDragon && dragonEnemy.Visible==true)
            {
                System.IO.Stream str = WindowsFormsApp1.Properties.Resources.Distorted_Message2;
                System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                snd.Play();

                ableToCollideWithDragon = false;
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
            if (Character.Bounds.IntersectsWith(pictureBoxKey1.Bounds) && pictureBoxKey1.Visible==true)
            {
                System.IO.Stream str = WindowsFormsApp1.Properties.Resources.Beep1;
                System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                snd.Play();

                pictureBoxKey1.Visible = false;
                numberOfCaughtKeys++;
                if (numberOfCaughtKeys == 2)
                {
                    gotTheKey = true;
                }
            }
            if (Character.Bounds.IntersectsWith(pictureBoxKey2.Bounds) && pictureBoxKey2.Visible==true)
            {
                System.IO.Stream str = WindowsFormsApp1.Properties.Resources.Beep1;
                System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                snd.Play();

                pictureBoxKey2.Visible = false;
                numberOfCaughtKeys++;
                if (numberOfCaughtKeys == 2)
                {
                    gotTheKey = true;
                }
            }

            if(Character.Bounds.IntersectsWith(pictureBoxWatermelon.Bounds) && pictureBoxWatermelon.Visible == true)
            {
                System.IO.Stream str = WindowsFormsApp1.Properties.Resources.Beep3;
                System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                snd.Play();

                pictureBoxWatermelon.Visible = false;
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

            if (gotTheKey)
            {
                pictureBoxArrowRight.Visible = true;
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

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                hasMovedRight = true;
                hasMovedLeft = false;
                goingRight = true;
                goingLeft = false;
                if (Character.Right >= gamePanel2.Width && gotTheKey)
                {
                    Form3 form3 = new Form3(hearts);
                    form3.Show();
                    this.Close();
                    timer1.Enabled = false;
                    timerBeholder.Enabled = false;
                    timerCollision.Enabled = false;
                    platformTimer.Enabled = false;

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

        private void Form2_KeyUp(object sender, KeyEventArgs e)
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

        private void Timer1_Tick(object sender, EventArgs e)
        {

            if (goingRight && Character.Right < gamePanel2.Width)
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

            if (Character.Top + Character.Height >= gamePanel2.Height && ok == 1)
            {
                ok = 0;
                Character.Top = gamePanel2.Height - Character.Height-34;
                if (hasMovedLeftJmp)
                {
                    Character.Image = WindowsFormsApp1.Properties.Resources.megaManStaionaryLeft;

                }
                else if (hasMovedRightJmp)
                {
                    Character.Image = WindowsFormsApp1.Properties.Resources.megaManStaionaryRight;

                }
                jumping = false;


            }

            if (Character.Bottom >= mudPlatform1.Top && Character.Top < mudPlatform1.Top && Character.Right >= mudPlatform1.Left && Character.Left <= mudPlatform1.Right)
            {
                Character.Top = mudPlatform1.Height - Character.Height + mudPlatform1.Top - mudPlatform1.Height;
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

            if (Character.Top == mudPlatform1.Height - Character.Height + mudPlatform1.Top - mudPlatform1.Height && (Character.Right < mudPlatform1.Left || Character.Left > mudPlatform1.Right))
            {
                jumping = true;
            }
            if (Character.Top <= mudPlatform1.Bottom && Character.Right >= mudPlatform1.Left && Character.Left <= mudPlatform1.Right && Character.Bottom > mudPlatform1.Top)
            {
                force = 0;
                Character.Top -= force;
                force -= 1;
            }

            if (Character.Bottom >= mudPlatform2.Top && Character.Top < mudPlatform2.Top && Character.Right >= mudPlatform2.Left && Character.Left <= mudPlatform2.Right)
            {
                Character.Top = mudPlatform2.Height - Character.Height + mudPlatform2.Top - mudPlatform2.Height;
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
            if (Character.Top == mudPlatform2.Height - Character.Height + mudPlatform2.Top - mudPlatform2.Height && (Character.Right < mudPlatform2.Left || Character.Left > mudPlatform2.Right))
            {
                jumping = true;
            }
            if (Character.Top <= mudPlatform2.Bottom && Character.Right >= mudPlatform2.Left && Character.Left <= mudPlatform2.Right && Character.Bottom > mudPlatform2.Top)
            {
                force = 0;
                Character.Top -= force;
                force -= 1;

            }
            if(Character.Top == mudPlatform3.Height - Character.Height + mudPlatform3.Top - mudPlatform3.Height && mudPlatform3.Visible == false)
            {
                jumping = true;
            }
            if (Character.Bottom >= mudPlatform3.Top && Character.Top < mudPlatform3.Top && Character.Right >= mudPlatform3.Left && Character.Left <= mudPlatform3.Right && mudPlatform3.Visible == true)
            {
                Character.Top = mudPlatform3.Height - Character.Height + mudPlatform3.Top - mudPlatform3.Height;
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
                if (mudPlatform3.Visible == false)
                {
                    jumping = true;
                }
            }
            if (Character.Top == mudPlatform3.Height - Character.Height + mudPlatform3.Top - mudPlatform3.Height && (Character.Right < mudPlatform3.Left || Character.Left > mudPlatform3.Right))
            {
                jumping = true;
            }
            if (Character.Top <= mudPlatform3.Bottom && Character.Right >= mudPlatform3.Left && Character.Left <= mudPlatform3.Right && Character.Bottom > mudPlatform3.Top && mudPlatform3.Visible == true)
            {
                force = 0;
                Character.Top -= force;
                force -= 1;

            }
            if ((pictureBoxBullet.Bounds.IntersectsWith(mudPlatform1.Bounds) || pictureBoxBullet.Bounds.IntersectsWith(mudPlatform2.Bounds)
                || pictureBoxBullet.Left <= 0 || pictureBoxBullet.Right >= gamePanel2.Width) || (pictureBoxBullet.Bounds.IntersectsWith(mudPlatform3.Bounds) && mudPlatform3.Visible==true) && pictureBoxBullet.Visible == true)
            {
                createdBullet = false;
                pictureBoxBullet.Visible = false;
                ableToFire = true;
            }
        }

        private void PlatformTimer_Tick(object sender, EventArgs e)
        {
            if (mudPlatform3.Visible == true)
            {
                mudPlatform3.Visible = false;
            }
            else
            {
                mudPlatform3.Visible = true;
            }
        }

        private void TimerCollision_Tick(object sender, EventArgs e)
        {
            ticks++;
            if (ticks == 5)
            {
                ticks = 0;
                ableToCollideWithDragon = true;
                ableToCollideWithGhost1 = true;
                ableToCollideWithGhost2 = true;
            }
        }

        private void GhostTimer_Tick(object sender, EventArgs e)
        {
            if (hearts == -1)
            {
                this.Hide();
                Form5 form5 = new Form5();
                form5.Show();
                ghostTimer.Enabled = false;

            }
            if (pictureBoxBullet.Visible == true && hasFiredFromRight)
            {
                pictureBoxBullet.Left += 5;
            }
            else if (pictureBoxBullet.Visible == true && hasFiredFromLeft)
            {
                pictureBoxBullet.Left -= 5;
            }
            if (ghost1GoingRight)
            {
                if (pictureBoxGhost1.Right >= mudPlatform1.Right)
                {
                    ghost1GoingRight = false;
                    ghost1GoingLeft = true;
                    pictureBoxGhost1.Image = WindowsFormsApp1.Properties.Resources.ghostLeft;
                }
                else
                {
                    pictureBoxGhost1.Left += 5;
                }
            }
            if (ghost1GoingLeft)
            {
                if (pictureBoxGhost1.Left <= mudPlatform1.Left)
                {
                    ghost1GoingRight = true;
                    ghost1GoingLeft = false;
                    pictureBoxGhost1.Image = WindowsFormsApp1.Properties.Resources.ghostRight;
                }
                else
                {
                    pictureBoxGhost1.Left -= 5;
                }
            }
            if (ghost2GoingRight)
            {
                if (pictureBoxGhost2.Right >= mudPlatform2.Right)
                {
                    ghost2GoingRight = false;
                    ghost2GoingLeft = true;
                    pictureBoxGhost2.Image = WindowsFormsApp1.Properties.Resources.ghostLeft;
                }
                else
                {
                    pictureBoxGhost2.Left += 5;
                }
            }
            if (ghost2GoingLeft)
            {
                if (pictureBoxGhost2.Left <= mudPlatform2.Left)
                {
                    ghost2GoingRight = true;
                    ghost2GoingLeft = false;
                    pictureBoxGhost2.Image = WindowsFormsApp1.Properties.Resources.ghostRight;
                }
                else
                {
                    pictureBoxGhost2.Left -= 5;
                }
            }
            if (Character.Bounds.IntersectsWith(pictureBoxGhost1.Bounds) && ableToCollideWithGhost1 && pictureBoxGhost1.Visible == true)
            {

                System.IO.Stream str = WindowsFormsApp1.Properties.Resources.Distorted_Message2;
                System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                snd.Play();

                ableToCollideWithGhost1 = false;
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
            if (pictureBoxBullet.Bounds.IntersectsWith(pictureBoxGhost1.Bounds) && pictureBoxGhost1.Visible == true)
            {
                createdBullet = false;
                pictureBoxBullet.Visible = false;
                ableToFire = true;
                pictureBoxGhost1.Visible = false;
                System.IO.Stream str = WindowsFormsApp1.Properties.Resources.Explosion2;
                System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                snd.Play();
            }
            if (pictureBoxBullet.Bounds.IntersectsWith(pictureBoxGhost2.Bounds) && pictureBoxGhost2.Visible == true)
            {
                createdBullet = false;
                pictureBoxBullet.Visible = false;
                ableToFire = true;
                pictureBoxGhost2.Visible = false;
                System.IO.Stream str = WindowsFormsApp1.Properties.Resources.Explosion2;
                System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                snd.Play();
            }
            if (pictureBoxBullet.Bounds.IntersectsWith(dragonEnemy.Bounds) && dragonEnemy.Visible == true)
            {
                createdBullet = false;
                pictureBoxBullet.Visible = false;
                ableToFire = true;
                dragonEnemy.Visible = false;
                System.IO.Stream str = WindowsFormsApp1.Properties.Resources.Explosion2;
                System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                snd.Play();
            }
            if (Character.Bounds.IntersectsWith(pictureBoxGhost2.Bounds) && ableToCollideWithGhost2 && pictureBoxGhost2.Visible==true)
            {

                System.IO.Stream str = WindowsFormsApp1.Properties.Resources.Distorted_Message2;
                System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                snd.Play();

                ableToCollideWithGhost2 = false;
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

        }
    }
}
