namespace WindowsFormsApp1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timerBeholder = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.platformTimer = new System.Windows.Forms.Timer(this.components);
            this.timerCollision = new System.Windows.Forms.Timer(this.components);
            this.ghostTimer = new System.Windows.Forms.Timer(this.components);
            this.gamePanel2 = new System.Windows.Forms.Panel();
            this.pictureBoxBullet = new System.Windows.Forms.PictureBox();
            this.pictureBoxWatermelon = new System.Windows.Forms.PictureBox();
            this.pictureBoxGhost2 = new System.Windows.Forms.PictureBox();
            this.Character = new System.Windows.Forms.PictureBox();
            this.pictureBoxGhost1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxArrowRight = new System.Windows.Forms.PictureBox();
            this.pictureBoxKey1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxKey2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxHeart2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxHeart3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxHeart1 = new System.Windows.Forms.PictureBox();
            this.mudPlatform3 = new System.Windows.Forms.PictureBox();
            this.dragonEnemy = new System.Windows.Forms.PictureBox();
            this.mudPlatform2 = new System.Windows.Forms.PictureBox();
            this.mudPlatform1 = new System.Windows.Forms.PictureBox();
            this.gamePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBullet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWatermelon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGhost2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Character)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGhost1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArrowRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKey1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKey2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mudPlatform3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dragonEnemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mudPlatform2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mudPlatform1)).BeginInit();
            this.SuspendLayout();
            // 
            // timerBeholder
            // 
            this.timerBeholder.Enabled = true;
            this.timerBeholder.Tick += new System.EventHandler(this.TimerBeholder_Tick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // platformTimer
            // 
            this.platformTimer.Enabled = true;
            this.platformTimer.Interval = 2000;
            this.platformTimer.Tick += new System.EventHandler(this.PlatformTimer_Tick);
            // 
            // timerCollision
            // 
            this.timerCollision.Enabled = true;
            this.timerCollision.Interval = 1000;
            this.timerCollision.Tick += new System.EventHandler(this.TimerCollision_Tick);
            // 
            // ghostTimer
            // 
            this.ghostTimer.Enabled = true;
            this.ghostTimer.Tick += new System.EventHandler(this.GhostTimer_Tick);
            // 
            // gamePanel2
            // 
            this.gamePanel2.BackColor = System.Drawing.Color.White;
            this.gamePanel2.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.bckgrnd2;
            this.gamePanel2.Controls.Add(this.pictureBoxBullet);
            this.gamePanel2.Controls.Add(this.pictureBoxWatermelon);
            this.gamePanel2.Controls.Add(this.pictureBoxGhost2);
            this.gamePanel2.Controls.Add(this.Character);
            this.gamePanel2.Controls.Add(this.pictureBoxGhost1);
            this.gamePanel2.Controls.Add(this.pictureBoxArrowRight);
            this.gamePanel2.Controls.Add(this.pictureBoxKey1);
            this.gamePanel2.Controls.Add(this.pictureBoxKey2);
            this.gamePanel2.Controls.Add(this.pictureBoxHeart2);
            this.gamePanel2.Controls.Add(this.pictureBoxHeart3);
            this.gamePanel2.Controls.Add(this.pictureBoxHeart1);
            this.gamePanel2.Controls.Add(this.mudPlatform3);
            this.gamePanel2.Controls.Add(this.dragonEnemy);
            this.gamePanel2.Controls.Add(this.mudPlatform2);
            this.gamePanel2.Controls.Add(this.mudPlatform1);
            this.gamePanel2.Location = new System.Drawing.Point(1, -1);
            this.gamePanel2.Name = "gamePanel2";
            this.gamePanel2.Size = new System.Drawing.Size(1099, 564);
            this.gamePanel2.TabIndex = 0;
            // 
            // pictureBoxBullet
            // 
            this.pictureBoxBullet.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBullet.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.clipart_explosion_pixel_11;
            this.pictureBoxBullet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxBullet.Location = new System.Drawing.Point(90, 466);
            this.pictureBoxBullet.Name = "pictureBoxBullet";
            this.pictureBoxBullet.Size = new System.Drawing.Size(38, 29);
            this.pictureBoxBullet.TabIndex = 16;
            this.pictureBoxBullet.TabStop = false;
            this.pictureBoxBullet.Visible = false;
            // 
            // pictureBoxWatermelon
            // 
            this.pictureBoxWatermelon.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxWatermelon.Image = global::WindowsFormsApp1.Properties.Resources.game_clipart_8_bit_7;
            this.pictureBoxWatermelon.Location = new System.Drawing.Point(413, 34);
            this.pictureBoxWatermelon.Name = "pictureBoxWatermelon";
            this.pictureBoxWatermelon.Size = new System.Drawing.Size(57, 46);
            this.pictureBoxWatermelon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxWatermelon.TabIndex = 15;
            this.pictureBoxWatermelon.TabStop = false;
            // 
            // pictureBoxGhost2
            // 
            this.pictureBoxGhost2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxGhost2.Image = global::WindowsFormsApp1.Properties.Resources.ghostRight;
            this.pictureBoxGhost2.Location = new System.Drawing.Point(752, 92);
            this.pictureBoxGhost2.Name = "pictureBoxGhost2";
            this.pictureBoxGhost2.Size = new System.Drawing.Size(75, 78);
            this.pictureBoxGhost2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGhost2.TabIndex = 14;
            this.pictureBoxGhost2.TabStop = false;
            // 
            // Character
            // 
            this.Character.BackColor = System.Drawing.Color.Transparent;
            this.Character.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Character.Image = global::WindowsFormsApp1.Properties.Resources.megaManStaionaryRight;
            this.Character.Location = new System.Drawing.Point(0, 430);
            this.Character.Name = "Character";
            this.Character.Size = new System.Drawing.Size(84, 88);
            this.Character.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Character.TabIndex = 4;
            this.Character.TabStop = false;
            // 
            // pictureBoxGhost1
            // 
            this.pictureBoxGhost1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxGhost1.Image = global::WindowsFormsApp1.Properties.Resources.ghostRight;
            this.pictureBoxGhost1.Location = new System.Drawing.Point(247, 81);
            this.pictureBoxGhost1.Name = "pictureBoxGhost1";
            this.pictureBoxGhost1.Size = new System.Drawing.Size(75, 78);
            this.pictureBoxGhost1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGhost1.TabIndex = 13;
            this.pictureBoxGhost1.TabStop = false;
            // 
            // pictureBoxArrowRight
            // 
            this.pictureBoxArrowRight.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxArrowRight.Image = global::WindowsFormsApp1.Properties.Resources.arrowRight1;
            this.pictureBoxArrowRight.Location = new System.Drawing.Point(998, 13);
            this.pictureBoxArrowRight.Name = "pictureBoxArrowRight";
            this.pictureBoxArrowRight.Size = new System.Drawing.Size(70, 67);
            this.pictureBoxArrowRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxArrowRight.TabIndex = 12;
            this.pictureBoxArrowRight.TabStop = false;
            this.pictureBoxArrowRight.Visible = false;
            // 
            // pictureBoxKey1
            // 
            this.pictureBoxKey1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxKey1.Image = global::WindowsFormsApp1.Properties.Resources.key;
            this.pictureBoxKey1.Location = new System.Drawing.Point(165, 109);
            this.pictureBoxKey1.Name = "pictureBoxKey1";
            this.pictureBoxKey1.Size = new System.Drawing.Size(33, 50);
            this.pictureBoxKey1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxKey1.TabIndex = 1;
            this.pictureBoxKey1.TabStop = false;
            // 
            // pictureBoxKey2
            // 
            this.pictureBoxKey2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxKey2.Image = global::WindowsFormsApp1.Properties.Resources.key;
            this.pictureBoxKey2.Location = new System.Drawing.Point(863, 120);
            this.pictureBoxKey2.Name = "pictureBoxKey2";
            this.pictureBoxKey2.Size = new System.Drawing.Size(33, 50);
            this.pictureBoxKey2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxKey2.TabIndex = 8;
            this.pictureBoxKey2.TabStop = false;
            // 
            // pictureBoxHeart2
            // 
            this.pictureBoxHeart2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxHeart2.Image = global::WindowsFormsApp1.Properties.Resources.heart;
            this.pictureBoxHeart2.Location = new System.Drawing.Point(40, 13);
            this.pictureBoxHeart2.Name = "pictureBoxHeart2";
            this.pictureBoxHeart2.Size = new System.Drawing.Size(23, 22);
            this.pictureBoxHeart2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHeart2.TabIndex = 7;
            this.pictureBoxHeart2.TabStop = false;
            // 
            // pictureBoxHeart3
            // 
            this.pictureBoxHeart3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxHeart3.Image = global::WindowsFormsApp1.Properties.Resources.heart;
            this.pictureBoxHeart3.Location = new System.Drawing.Point(69, 13);
            this.pictureBoxHeart3.Name = "pictureBoxHeart3";
            this.pictureBoxHeart3.Size = new System.Drawing.Size(23, 22);
            this.pictureBoxHeart3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHeart3.TabIndex = 6;
            this.pictureBoxHeart3.TabStop = false;
            // 
            // pictureBoxHeart1
            // 
            this.pictureBoxHeart1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxHeart1.Image = global::WindowsFormsApp1.Properties.Resources.heart;
            this.pictureBoxHeart1.Location = new System.Drawing.Point(11, 13);
            this.pictureBoxHeart1.Name = "pictureBoxHeart1";
            this.pictureBoxHeart1.Size = new System.Drawing.Size(23, 22);
            this.pictureBoxHeart1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHeart1.TabIndex = 5;
            this.pictureBoxHeart1.TabStop = false;
            // 
            // mudPlatform3
            // 
            this.mudPlatform3.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.mudPlatform;
            this.mudPlatform3.Location = new System.Drawing.Point(480, 315);
            this.mudPlatform3.Name = "mudPlatform3";
            this.mudPlatform3.Size = new System.Drawing.Size(145, 50);
            this.mudPlatform3.TabIndex = 3;
            this.mudPlatform3.TabStop = false;
            // 
            // dragonEnemy
            // 
            this.dragonEnemy.BackColor = System.Drawing.Color.Transparent;
            this.dragonEnemy.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._8bit_DragonRight;
            this.dragonEnemy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dragonEnemy.Location = new System.Drawing.Point(225, 430);
            this.dragonEnemy.Name = "dragonEnemy";
            this.dragonEnemy.Size = new System.Drawing.Size(97, 88);
            this.dragonEnemy.TabIndex = 2;
            this.dragonEnemy.TabStop = false;
            // 
            // mudPlatform2
            // 
            this.mudPlatform2.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.mudPlatform;
            this.mudPlatform2.Location = new System.Drawing.Point(740, 171);
            this.mudPlatform2.Name = "mudPlatform2";
            this.mudPlatform2.Size = new System.Drawing.Size(252, 50);
            this.mudPlatform2.TabIndex = 1;
            this.mudPlatform2.TabStop = false;
            // 
            // mudPlatform1
            // 
            this.mudPlatform1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.mudPlatform;
            this.mudPlatform1.Location = new System.Drawing.Point(104, 161);
            this.mudPlatform1.Name = "mudPlatform1";
            this.mudPlatform1.Size = new System.Drawing.Size(247, 50);
            this.mudPlatform1.TabIndex = 0;
            this.mudPlatform1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1081, 517);
            this.Controls.Add(this.gamePanel2);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyUp);
            this.gamePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBullet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWatermelon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGhost2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Character)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGhost1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArrowRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKey1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKey2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mudPlatform3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dragonEnemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mudPlatform2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mudPlatform1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel gamePanel2;
        private System.Windows.Forms.PictureBox mudPlatform1;
        private System.Windows.Forms.PictureBox mudPlatform2;
        private System.Windows.Forms.Timer timerBeholder;
        private System.Windows.Forms.PictureBox dragonEnemy;
        private System.Windows.Forms.PictureBox mudPlatform3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox Character;
        private System.Windows.Forms.Timer platformTimer;
        private System.Windows.Forms.PictureBox pictureBoxHeart2;
        private System.Windows.Forms.PictureBox pictureBoxHeart3;
        private System.Windows.Forms.PictureBox pictureBoxHeart1;
        private System.Windows.Forms.Timer timerCollision;
        private System.Windows.Forms.PictureBox pictureBoxKey1;
        private System.Windows.Forms.PictureBox pictureBoxKey2;
        private System.Windows.Forms.PictureBox pictureBoxArrowRight;
        private System.Windows.Forms.PictureBox pictureBoxGhost2;
        private System.Windows.Forms.PictureBox pictureBoxGhost1;
        private System.Windows.Forms.Timer ghostTimer;
        private System.Windows.Forms.PictureBox pictureBoxWatermelon;
        private System.Windows.Forms.PictureBox pictureBoxBullet;
    }
}