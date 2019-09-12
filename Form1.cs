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
   
    public partial class gameZone : Form
    {
        bool goingRight;
        bool goingLeft;
        bool jumping;
        bool hasMovedRight=true;
        bool hasMovedLeft = false;
        bool hasMovedLeftJmp;
        bool hasMovedRightJmp;
        int gravity = 20;
        int ok = 0;
        int force;
        bool pinkMonsterGoingRight = true;
        bool pinkMonsterGoingLeft = false;
        public static int hearts = 4;
        int ticks = 0;
        bool ableToCollide = true;
        bool gotTheKey = false;
        bool ableToFire = true;
        bool createdBullet = false;
        bool hasFiredFromRight = true;
        bool hasFiredFromLeft = false;
        
        public gameZone()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }


        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
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

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                hasMovedRight = true;
                hasMovedLeft = false;
                goingRight = true;
                goingLeft = false;
                if (Character.Right >= gamePanel1.Width && gotTheKey)
                {
                    Form2 form2 = new Form2(hearts);
                    form2.Show();
                    this.Hide();

                }
            }

            if (e.KeyCode == Keys.Left)
            {
                goingLeft = true;
                goingRight = false;
                hasMovedRight = false;
                hasMovedLeft = true;
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

            if (e.KeyCode == Keys.Space)
            {
                if (ableToFire)
                {
                    ableToFire = false;
                    System.IO.Stream str = WindowsFormsApp1.Properties.Resources.Laser_Shoot1;
                    System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                    snd.Play();
                    if((goingRight || hasMovedRight ) &&  !createdBullet)
                    {
                        createdBullet = true;
                        hasFiredFromRight = true;
                        hasFiredFromLeft = false;
                        pictureBoxBullet.Location = new Point(Character.Location.X + 90, Character.Location.Y + 34);
                    }else if((goingLeft || hasMovedLeft) && !createdBullet)
                    {
                        createdBullet = true;
                        hasFiredFromRight = false;
                        hasFiredFromLeft = true;
                        pictureBoxBullet.Location = new Point(Character.Location.X - 44, Character.Location.Y + 31);
                    }
                    
                    pictureBoxBullet.Visible = true;
                }
            }
            
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (hearts == -1)
            {
                this.Hide();
                Form5 form5 = new Form5();
                form5.Show();
                timer1.Enabled = false;

            }

            if (pictureBoxBullet.Visible == true && hasFiredFromRight)
            {
                pictureBoxBullet.Left += 5;
            }
            else if (pictureBoxBullet.Visible == true && (goingLeft || hasFiredFromLeft))
            {
                pictureBoxBullet.Left -= 5;
            }

            if (pictureBoxBullet.Bounds.IntersectsWith(pictureBoxPinkMonster.Bounds) && pictureBoxPinkMonster.Visible==true)
            {
                createdBullet = false;
                pictureBoxBullet.Visible = false;
                ableToFire = true;
                pictureBoxPinkMonster.Visible = false;
                System.IO.Stream str = WindowsFormsApp1.Properties.Resources.Explosion2;
                System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                snd.Play();
            }
           
            if (goingRight && Character.Right < gamePanel1.Width)
            {
                Character.Left += 5;
            }
            if (goingLeft && Character.Left>=0)
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

            if (Character.Top + Character.Height >= gamePanel1.Height && ok==1)
            {
                ok = 0;
                Character.Top = gamePanel1.Height - Character.Height;
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

            if (Character.Bottom >= brickPlatform1.Top && Character.Top<brickPlatform1.Top && Character.Right>=brickPlatform1.Left && Character.Left <= brickPlatform1.Right)
            {
                Character.Top = brickPlatform1.Height-Character.Height+brickPlatform1.Top-brickPlatform1.Height;
                jumping = false;
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
                
            }

            if(Character.Top== brickPlatform1.Height - Character.Height + brickPlatform1.Top - brickPlatform1.Height && (Character.Right<brickPlatform1.Left || Character.Left > brickPlatform1.Right)){
                jumping = true;
                
            }
            if(Character.Top<=brickPlatform1.Bottom && Character.Right >= brickPlatform1.Left && Character.Left <= brickPlatform1.Right && Character.Bottom > brickPlatform1.Top) {
                force = 0;
                Character.Top -= force;
                force -= 1;
            }

            if (Character.Bottom >= brickPlatform2.Top && Character.Top < brickPlatform2.Top && Character.Right >= brickPlatform2.Left && Character.Left <= brickPlatform2.Right)
            {
                Character.Top = brickPlatform2.Height - Character.Height + brickPlatform2.Top - brickPlatform2.Height;
                jumping = false;
                if (hasMovedLeft)
                {
                    Character.Image = WindowsFormsApp1.Properties.Resources.megaManStaionaryLeft;

                }
                else if(hasMovedRight)
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
                
                
            }
            if (Character.Top == brickPlatform2.Height - Character.Height + brickPlatform2.Top - brickPlatform2.Height && (Character.Right < brickPlatform2.Left || Character.Left > brickPlatform2.Right))
            {
                jumping = true;
               
            }
            if (Character.Top <= brickPlatform2.Bottom && Character.Right >= brickPlatform2.Left && Character.Left <= brickPlatform2.Right && Character.Bottom > brickPlatform2.Top)
            {
                force = 0;
                Character.Top -= force;
                force -= 1;
                
            }
            
            if((pictureBoxBullet.Bounds.IntersectsWith(brickPlatform1.Bounds) || pictureBoxBullet.Bounds.IntersectsWith(brickPlatform2.Bounds) 
                || pictureBoxBullet.Left<=0 || pictureBoxBullet.Right>=gamePanel1.Width) && pictureBoxBullet.Visible==true)
            {
                createdBullet = false;
                pictureBoxBullet.Visible = false;
                ableToFire = true;
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

        private void Character_Click(object sender, EventArgs e)
        {

        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            if (Character.Bounds.IntersectsWith(pictureBoxPotion.Bounds) && pictureBoxPotion.Visible ==true)
            {
                System.IO.Stream str = WindowsFormsApp1.Properties.Resources.Beep3;
                System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                snd.Play();

                pictureBoxPotion.Visible = false;
                if (pictureBoxHeart1.Visible == false)
                {
                    pictureBoxHeart1.Visible = true;
                }else if (pictureBoxHeart2.Visible == false)
                {
                    pictureBoxHeart2.Visible = true;
                    hearts++;
                }else if (pictureBoxHeart3.Visible == false)
                {
                    pictureBoxHeart3.Visible = true;
                    hearts++;
                }

            }
            if (Character.Bounds.IntersectsWith(pictureBoxPinkMonster.Bounds) && ableToCollide && pictureBoxPinkMonster.Visible==true)
            {
                System.IO.Stream str = WindowsFormsApp1.Properties.Resources.Distorted_Message2;
                System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                snd.Play();

                ableToCollide = false;
                hearts--;
                if (hearts == 2)
                {
                    
                    pictureBoxHeart3.Visible = false;
                }else if (hearts == 1)
                {
                    pictureBoxHeart3.Visible = false;
                    pictureBoxHeart2.Visible = false;
                }else if (hearts == 0)
                {
                    pictureBoxHeart3.Visible = false;
                    pictureBoxHeart2.Visible = false;
                    pictureBoxHeart1.Visible = false;
                }

            }

            if (Character.Bounds.IntersectsWith(pictureBoxKey.Bounds) && pictureBoxKey.Visible==true)
            {
                System.IO.Stream str = WindowsFormsApp1.Properties.Resources.Beep1;
                System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                snd.Play();

                gotTheKey = true;
                pictureBoxKey.Visible = false;
                pictureBoxArrowRight.Visible = true;
            }
            if (pinkMonsterGoingRight)
            {
                if (pictureBoxPinkMonster.Right >= brickPlatform2.Right)
                {
                    pinkMonsterGoingRight = false;
                    pinkMonsterGoingLeft = true;
                    pictureBoxPinkMonster.Image = WindowsFormsApp1.Properties.Resources.pinkMonsterLeft;
                }
                else
                {
                    pictureBoxPinkMonster.Left += 5;
                }
            }
            if (pinkMonsterGoingLeft)
            {
                if (pictureBoxPinkMonster.Left <= brickPlatform2.Left)
                {
                    pinkMonsterGoingRight = true;
                    pinkMonsterGoingLeft = false;
                    pictureBoxPinkMonster.Image = WindowsFormsApp1.Properties.Resources.pinkMonsterRight;
                }
                else
                {
                    pictureBoxPinkMonster.Left -= 5;
                }
            }
          
           
            
        }

        
        private void NoCollisionTimer_Tick(object sender, EventArgs e)
        {
            ticks++;
            if (ticks == 5)
            {
                ticks = 0;
                ableToCollide = true;
            }
            
            
        }

        private void GamePanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void BrickPlatform2_Click(object sender, EventArgs e)
        {

        }

        private void PictureBoxPinkMonster_Click(object sender, EventArgs e)
        {

        }
    }
}
