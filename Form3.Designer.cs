namespace WindowsFormsApp1
{
    partial class Form3
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
            this.gamePanel3 = new System.Windows.Forms.Panel();
            this.pictureBoxStar = new System.Windows.Forms.PictureBox();
            this.pictureBoxBoss = new System.Windows.Forms.PictureBox();
            this.brownBrickPlatform3 = new System.Windows.Forms.PictureBox();
            this.brownBrickPlatform2 = new System.Windows.Forms.PictureBox();
            this.brownBrickPlatform1 = new System.Windows.Forms.PictureBox();
            this.bananaPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBoxHeart2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxHeart3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxHeart1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxBullet = new System.Windows.Forms.PictureBox();
            this.Character = new System.Windows.Forms.PictureBox();
            this.bossTimer = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.collisonTimer = new System.Windows.Forms.Timer(this.components);
            this.gamePanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBoss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brownBrickPlatform3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brownBrickPlatform2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brownBrickPlatform1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bananaPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBullet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Character)).BeginInit();
            this.SuspendLayout();
            // 
            // gamePanel3
            // 
            this.gamePanel3.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Level3Background;
            this.gamePanel3.Controls.Add(this.pictureBoxStar);
            this.gamePanel3.Controls.Add(this.pictureBoxBoss);
            this.gamePanel3.Controls.Add(this.brownBrickPlatform3);
            this.gamePanel3.Controls.Add(this.brownBrickPlatform2);
            this.gamePanel3.Controls.Add(this.brownBrickPlatform1);
            this.gamePanel3.Controls.Add(this.bananaPictureBox);
            this.gamePanel3.Controls.Add(this.pictureBoxHeart2);
            this.gamePanel3.Controls.Add(this.pictureBoxHeart3);
            this.gamePanel3.Controls.Add(this.pictureBoxHeart1);
            this.gamePanel3.Controls.Add(this.pictureBoxBullet);
            this.gamePanel3.Controls.Add(this.Character);
            this.gamePanel3.Location = new System.Drawing.Point(0, 0);
            this.gamePanel3.Name = "gamePanel3";
            this.gamePanel3.Size = new System.Drawing.Size(1081, 517);
            this.gamePanel3.TabIndex = 0;
            // 
            // pictureBoxStar
            // 
            this.pictureBoxStar.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxStar.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.star;
            this.pictureBoxStar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxStar.Location = new System.Drawing.Point(950, 57);
            this.pictureBoxStar.Name = "pictureBoxStar";
            this.pictureBoxStar.Size = new System.Drawing.Size(40, 36);
            this.pictureBoxStar.TabIndex = 27;
            this.pictureBoxStar.TabStop = false;
            // 
            // pictureBoxBoss
            // 
            this.pictureBoxBoss.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBoss.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.lastBoss;
            this.pictureBoxBoss.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxBoss.Location = new System.Drawing.Point(741, 138);
            this.pictureBoxBoss.Name = "pictureBoxBoss";
            this.pictureBoxBoss.Size = new System.Drawing.Size(124, 148);
            this.pictureBoxBoss.TabIndex = 26;
            this.pictureBoxBoss.TabStop = false;
            // 
            // brownBrickPlatform3
            // 
            this.brownBrickPlatform3.BackColor = System.Drawing.Color.Transparent;
            this.brownBrickPlatform3.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.brownBrickPlatform;
            this.brownBrickPlatform3.Location = new System.Drawing.Point(924, 94);
            this.brownBrickPlatform3.Name = "brownBrickPlatform3";
            this.brownBrickPlatform3.Size = new System.Drawing.Size(98, 50);
            this.brownBrickPlatform3.TabIndex = 25;
            this.brownBrickPlatform3.TabStop = false;
            // 
            // brownBrickPlatform2
            // 
            this.brownBrickPlatform2.BackColor = System.Drawing.Color.Transparent;
            this.brownBrickPlatform2.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.brownBrickPlatform;
            this.brownBrickPlatform2.Location = new System.Drawing.Point(545, 256);
            this.brownBrickPlatform2.Name = "brownBrickPlatform2";
            this.brownBrickPlatform2.Size = new System.Drawing.Size(98, 50);
            this.brownBrickPlatform2.TabIndex = 24;
            this.brownBrickPlatform2.TabStop = false;
            // 
            // brownBrickPlatform1
            // 
            this.brownBrickPlatform1.BackColor = System.Drawing.Color.Transparent;
            this.brownBrickPlatform1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.brownBrickPlatform;
            this.brownBrickPlatform1.Location = new System.Drawing.Point(182, 358);
            this.brownBrickPlatform1.Name = "brownBrickPlatform1";
            this.brownBrickPlatform1.Size = new System.Drawing.Size(242, 50);
            this.brownBrickPlatform1.TabIndex = 23;
            this.brownBrickPlatform1.TabStop = false;
            // 
            // bananaPictureBox
            // 
            this.bananaPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.bananaPictureBox.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.banana;
            this.bananaPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bananaPictureBox.Location = new System.Drawing.Point(435, 94);
            this.bananaPictureBox.Name = "bananaPictureBox";
            this.bananaPictureBox.Size = new System.Drawing.Size(50, 50);
            this.bananaPictureBox.TabIndex = 22;
            this.bananaPictureBox.TabStop = false;
            // 
            // pictureBoxHeart2
            // 
            this.pictureBoxHeart2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxHeart2.Image = global::WindowsFormsApp1.Properties.Resources.heart;
            this.pictureBoxHeart2.Location = new System.Drawing.Point(35, 12);
            this.pictureBoxHeart2.Name = "pictureBoxHeart2";
            this.pictureBoxHeart2.Size = new System.Drawing.Size(23, 22);
            this.pictureBoxHeart2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHeart2.TabIndex = 21;
            this.pictureBoxHeart2.TabStop = false;
            // 
            // pictureBoxHeart3
            // 
            this.pictureBoxHeart3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxHeart3.Image = global::WindowsFormsApp1.Properties.Resources.heart;
            this.pictureBoxHeart3.Location = new System.Drawing.Point(64, 12);
            this.pictureBoxHeart3.Name = "pictureBoxHeart3";
            this.pictureBoxHeart3.Size = new System.Drawing.Size(23, 22);
            this.pictureBoxHeart3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHeart3.TabIndex = 20;
            this.pictureBoxHeart3.TabStop = false;
            // 
            // pictureBoxHeart1
            // 
            this.pictureBoxHeart1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxHeart1.Image = global::WindowsFormsApp1.Properties.Resources.heart;
            this.pictureBoxHeart1.Location = new System.Drawing.Point(6, 12);
            this.pictureBoxHeart1.Name = "pictureBoxHeart1";
            this.pictureBoxHeart1.Size = new System.Drawing.Size(23, 22);
            this.pictureBoxHeart1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHeart1.TabIndex = 19;
            this.pictureBoxHeart1.TabStop = false;
            // 
            // pictureBoxBullet
            // 
            this.pictureBoxBullet.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBullet.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.clipart_explosion_pixel_11;
            this.pictureBoxBullet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxBullet.Location = new System.Drawing.Point(90, 465);
            this.pictureBoxBullet.Name = "pictureBoxBullet";
            this.pictureBoxBullet.Size = new System.Drawing.Size(38, 29);
            this.pictureBoxBullet.TabIndex = 18;
            this.pictureBoxBullet.TabStop = false;
            this.pictureBoxBullet.Visible = false;
            // 
            // Character
            // 
            this.Character.BackColor = System.Drawing.Color.Transparent;
            this.Character.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Character.Image = global::WindowsFormsApp1.Properties.Resources.megaManStaionaryRight;
            this.Character.Location = new System.Drawing.Point(0, 429);
            this.Character.Name = "Character";
            this.Character.Size = new System.Drawing.Size(84, 88);
            this.Character.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Character.TabIndex = 17;
            this.Character.TabStop = false;
            // 
            // bossTimer
            // 
            this.bossTimer.Enabled = true;
            this.bossTimer.Tick += new System.EventHandler(this.BossTimer_Tick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // collisonTimer
            // 
            this.collisonTimer.Enabled = true;
            this.collisonTimer.Interval = 1000;
            this.collisonTimer.Tick += new System.EventHandler(this.CollisonTimer_Tick);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 517);
            this.Controls.Add(this.gamePanel3);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form3_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form3_KeyUp_1);
            this.gamePanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBoss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brownBrickPlatform3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brownBrickPlatform2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brownBrickPlatform1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bananaPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBullet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Character)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel gamePanel3;
        private System.Windows.Forms.PictureBox pictureBoxBullet;
        private System.Windows.Forms.PictureBox Character;
        private System.Windows.Forms.PictureBox pictureBoxHeart2;
        private System.Windows.Forms.PictureBox pictureBoxHeart3;
        private System.Windows.Forms.PictureBox pictureBoxHeart1;
        private System.Windows.Forms.PictureBox bananaPictureBox;
        private System.Windows.Forms.PictureBox brownBrickPlatform1;
        private System.Windows.Forms.PictureBox brownBrickPlatform3;
        private System.Windows.Forms.PictureBox brownBrickPlatform2;
        private System.Windows.Forms.PictureBox pictureBoxStar;
        private System.Windows.Forms.PictureBox pictureBoxBoss;
        private System.Windows.Forms.Timer bossTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer collisonTimer;
    }
}