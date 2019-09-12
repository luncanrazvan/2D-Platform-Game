namespace WindowsFormsApp1
{
    partial class gameZone
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerPinkMonster = new System.Windows.Forms.Timer(this.components);
            this.noCollisionTimer = new System.Windows.Forms.Timer(this.components);
            this.gamePanel1 = new System.Windows.Forms.Panel();
            this.pictureBoxBullet = new System.Windows.Forms.PictureBox();
            this.pictureBoxArrowRight = new System.Windows.Forms.PictureBox();
            this.Character = new System.Windows.Forms.PictureBox();
            this.pictureBoxPotion = new System.Windows.Forms.PictureBox();
            this.pictureBoxPinkMonster = new System.Windows.Forms.PictureBox();
            this.brickPlatform1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxHeart2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxHeart3 = new System.Windows.Forms.PictureBox();
            this.brickPlatform2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxHeart1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxKey = new System.Windows.Forms.PictureBox();
            this.gamePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBullet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArrowRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Character)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPinkMonster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brickPlatform1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brickPlatform2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKey)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // timerPinkMonster
            // 
            this.timerPinkMonster.Enabled = true;
            this.timerPinkMonster.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // noCollisionTimer
            // 
            this.noCollisionTimer.Enabled = true;
            this.noCollisionTimer.Interval = 1000;
            this.noCollisionTimer.Tick += new System.EventHandler(this.NoCollisionTimer_Tick);
            // 
            // gamePanel1
            // 
            this.gamePanel1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.copy1;
            this.gamePanel1.Controls.Add(this.pictureBoxBullet);
            this.gamePanel1.Controls.Add(this.pictureBoxArrowRight);
            this.gamePanel1.Controls.Add(this.Character);
            this.gamePanel1.Controls.Add(this.pictureBoxPotion);
            this.gamePanel1.Controls.Add(this.pictureBoxPinkMonster);
            this.gamePanel1.Controls.Add(this.brickPlatform1);
            this.gamePanel1.Controls.Add(this.pictureBoxHeart2);
            this.gamePanel1.Controls.Add(this.pictureBoxHeart3);
            this.gamePanel1.Controls.Add(this.brickPlatform2);
            this.gamePanel1.Controls.Add(this.pictureBoxHeart1);
            this.gamePanel1.Controls.Add(this.pictureBoxKey);
            this.gamePanel1.Location = new System.Drawing.Point(-2, -3);
            this.gamePanel1.Name = "gamePanel1";
            this.gamePanel1.Size = new System.Drawing.Size(1083, 521);
            this.gamePanel1.TabIndex = 1;
            this.gamePanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.GamePanel1_Paint);
            // 
            // pictureBoxBullet
            // 
            this.pictureBoxBullet.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBullet.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.clipart_explosion_pixel_11;
            this.pictureBoxBullet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxBullet.Location = new System.Drawing.Point(227, 460);
            this.pictureBoxBullet.Name = "pictureBoxBullet";
            this.pictureBoxBullet.Size = new System.Drawing.Size(38, 29);
            this.pictureBoxBullet.TabIndex = 12;
            this.pictureBoxBullet.TabStop = false;
            this.pictureBoxBullet.Visible = false;
            // 
            // pictureBoxArrowRight
            // 
            this.pictureBoxArrowRight.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxArrowRight.Image = global::WindowsFormsApp1.Properties.Resources.arrowRight1;
            this.pictureBoxArrowRight.Location = new System.Drawing.Point(1001, 30);
            this.pictureBoxArrowRight.Name = "pictureBoxArrowRight";
            this.pictureBoxArrowRight.Size = new System.Drawing.Size(70, 67);
            this.pictureBoxArrowRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxArrowRight.TabIndex = 11;
            this.pictureBoxArrowRight.TabStop = false;
            this.pictureBoxArrowRight.Visible = false;
            // 
            // Character
            // 
            this.Character.BackColor = System.Drawing.Color.Transparent;
            this.Character.Image = global::WindowsFormsApp1.Properties.Resources.megaManStaionaryRight;
            this.Character.Location = new System.Drawing.Point(137, 433);
            this.Character.Name = "Character";
            this.Character.Size = new System.Drawing.Size(84, 88);
            this.Character.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Character.TabIndex = 0;
            this.Character.TabStop = false;
            this.Character.Click += new System.EventHandler(this.Character_Click);
            // 
            // pictureBoxPotion
            // 
            this.pictureBoxPotion.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPotion.Image = global::WindowsFormsApp1.Properties.Resources.potion;
            this.pictureBoxPotion.Location = new System.Drawing.Point(785, 286);
            this.pictureBoxPotion.Name = "pictureBoxPotion";
            this.pictureBoxPotion.Size = new System.Drawing.Size(44, 47);
            this.pictureBoxPotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPotion.TabIndex = 9;
            this.pictureBoxPotion.TabStop = false;
            // 
            // pictureBoxPinkMonster
            // 
            this.pictureBoxPinkMonster.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPinkMonster.Image = global::WindowsFormsApp1.Properties.Resources.pinkMonsterRight;
            this.pictureBoxPinkMonster.Location = new System.Drawing.Point(207, 165);
            this.pictureBoxPinkMonster.Name = "pictureBoxPinkMonster";
            this.pictureBoxPinkMonster.Size = new System.Drawing.Size(47, 50);
            this.pictureBoxPinkMonster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPinkMonster.TabIndex = 5;
            this.pictureBoxPinkMonster.TabStop = false;
            this.pictureBoxPinkMonster.Click += new System.EventHandler(this.PictureBoxPinkMonster_Click);
            // 
            // brickPlatform1
            // 
            this.brickPlatform1.BackColor = System.Drawing.Color.Yellow;
            this.brickPlatform1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.brickPlatform;
            this.brickPlatform1.Location = new System.Drawing.Point(646, 338);
            this.brickPlatform1.Name = "brickPlatform1";
            this.brickPlatform1.Size = new System.Drawing.Size(310, 50);
            this.brickPlatform1.TabIndex = 1;
            this.brickPlatform1.TabStop = false;
            // 
            // pictureBoxHeart2
            // 
            this.pictureBoxHeart2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxHeart2.Image = global::WindowsFormsApp1.Properties.Resources.heart;
            this.pictureBoxHeart2.Location = new System.Drawing.Point(43, 15);
            this.pictureBoxHeart2.Name = "pictureBoxHeart2";
            this.pictureBoxHeart2.Size = new System.Drawing.Size(25, 23);
            this.pictureBoxHeart2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHeart2.TabIndex = 8;
            this.pictureBoxHeart2.TabStop = false;
            // 
            // pictureBoxHeart3
            // 
            this.pictureBoxHeart3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxHeart3.Image = global::WindowsFormsApp1.Properties.Resources.heart;
            this.pictureBoxHeart3.Location = new System.Drawing.Point(74, 15);
            this.pictureBoxHeart3.Name = "pictureBoxHeart3";
            this.pictureBoxHeart3.Size = new System.Drawing.Size(25, 23);
            this.pictureBoxHeart3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHeart3.TabIndex = 7;
            this.pictureBoxHeart3.TabStop = false;
            // 
            // brickPlatform2
            // 
            this.brickPlatform2.BackColor = System.Drawing.Color.Yellow;
            this.brickPlatform2.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.brickPlatform;
            this.brickPlatform2.Location = new System.Drawing.Point(157, 217);
            this.brickPlatform2.Name = "brickPlatform2";
            this.brickPlatform2.Size = new System.Drawing.Size(310, 50);
            this.brickPlatform2.TabIndex = 2;
            this.brickPlatform2.TabStop = false;
            this.brickPlatform2.Click += new System.EventHandler(this.BrickPlatform2_Click);
            // 
            // pictureBoxHeart1
            // 
            this.pictureBoxHeart1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxHeart1.Image = global::WindowsFormsApp1.Properties.Resources.heart;
            this.pictureBoxHeart1.Location = new System.Drawing.Point(12, 15);
            this.pictureBoxHeart1.Name = "pictureBoxHeart1";
            this.pictureBoxHeart1.Size = new System.Drawing.Size(25, 23);
            this.pictureBoxHeart1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHeart1.TabIndex = 6;
            this.pictureBoxHeart1.TabStop = false;
            // 
            // pictureBoxKey
            // 
            this.pictureBoxKey.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxKey.Image = global::WindowsFormsApp1.Properties.Resources.key;
            this.pictureBoxKey.Location = new System.Drawing.Point(349, 161);
            this.pictureBoxKey.Name = "pictureBoxKey";
            this.pictureBoxKey.Size = new System.Drawing.Size(28, 50);
            this.pictureBoxKey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxKey.TabIndex = 4;
            this.pictureBoxKey.TabStop = false;
            // 
            // gameZone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1081, 517);
            this.Controls.Add(this.gamePanel1);
            this.Name = "gameZone";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.gamePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBullet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArrowRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Character)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPinkMonster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brickPlatform1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brickPlatform2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKey)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timerPinkMonster;
        private System.Windows.Forms.Timer noCollisionTimer;
        private System.Windows.Forms.PictureBox brickPlatform1;
        private System.Windows.Forms.PictureBox pictureBoxHeart1;
        private System.Windows.Forms.PictureBox pictureBoxHeart3;
        private System.Windows.Forms.PictureBox pictureBoxHeart2;
        private System.Windows.Forms.PictureBox pictureBoxKey;
        private System.Windows.Forms.PictureBox pictureBoxPotion;
        private System.Windows.Forms.PictureBox brickPlatform2;
        private System.Windows.Forms.PictureBox pictureBoxPinkMonster;
        private System.Windows.Forms.PictureBox Character;
        private System.Windows.Forms.Panel gamePanel1;
        private System.Windows.Forms.PictureBox pictureBoxArrowRight;
        private System.Windows.Forms.PictureBox pictureBoxBullet;
    }
}

