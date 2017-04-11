namespace N.H.T_Game
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.lb_random_number = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_time = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_newgame = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_savescore = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_backMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_quitGame = new System.Windows.Forms.ToolStripMenuItem();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_pause = new System.Windows.Forms.ToolStripMenuItem();
            this.hướngDẫnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_guilde = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_teamInformation = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_projectInfromation = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_trogiup = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_value = new System.Windows.Forms.TextBox();
            this.lb_sussgest = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_score = new System.Windows.Forms.Label();
            this.timerRandom = new System.Windows.Forms.Timer(this.components);
            this.timerTick = new System.Windows.Forms.Timer(this.components);
            this.bt_backmenu = new System.Windows.Forms.Button();
            this.bt_pause = new System.Windows.Forms.Button();
            this.pb_imageRight = new System.Windows.Forms.PictureBox();
            this.pb_imageLeft = new System.Windows.Forms.PictureBox();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_imageRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_imageLeft)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_random_number
            // 
            this.lb_random_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_random_number.Location = new System.Drawing.Point(176, 95);
            this.lb_random_number.Name = "lb_random_number";
            this.lb_random_number.Size = new System.Drawing.Size(384, 63);
            this.lb_random_number.TabIndex = 0;
            this.lb_random_number.Text = "..........";
            this.lb_random_number.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số ngẫu nhiên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(581, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Thời gian";
            // 
            // lb_time
            // 
            this.lb_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_time.Location = new System.Drawing.Point(588, 95);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(143, 63);
            this.lb_time.TabIndex = 3;
            this.lb_time.Text = "0";
            this.lb_time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(217)))), ((int)(((byte)(214)))));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.chứcNăngToolStripMenuItem,
            this.hướngDẫnToolStripMenuItem,
            this.thôngTinToolStripMenuItem,
            this.mi_trogiup});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(784, 24);
            this.menuStrip.TabIndex = 4;
            this.menuStrip.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_newgame,
            this.mi_savescore,
            this.mi_backMenu,
            this.mi_quitGame});
            this.gameToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // mi_newgame
            // 
            this.mi_newgame.BackColor = System.Drawing.Color.White;
            this.mi_newgame.Image = global::N.H.T_Game.Properties.Resources.New;
            this.mi_newgame.Name = "mi_newgame";
            this.mi_newgame.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mi_newgame.Size = new System.Drawing.Size(208, 22);
            this.mi_newgame.Text = "Chơi mới";
            this.mi_newgame.Click += new System.EventHandler(this.mi_newgame_Click);
            // 
            // mi_savescore
            // 
            this.mi_savescore.Image = global::N.H.T_Game.Properties.Resources.Save;
            this.mi_savescore.Name = "mi_savescore";
            this.mi_savescore.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mi_savescore.Size = new System.Drawing.Size(208, 22);
            this.mi_savescore.Text = "Lưu điểm";
            this.mi_savescore.Click += new System.EventHandler(this.mi_savescore_Click);
            // 
            // mi_backMenu
            // 
            this.mi_backMenu.Image = global::N.H.T_Game.Properties.Resources.undo;
            this.mi_backMenu.Name = "mi_backMenu";
            this.mi_backMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.mi_backMenu.Size = new System.Drawing.Size(208, 22);
            this.mi_backMenu.Text = "Trở về Menu";
            this.mi_backMenu.Click += new System.EventHandler(this.mi_backMenu_Click);
            // 
            // mi_quitGame
            // 
            this.mi_quitGame.Image = global::N.H.T_Game.Properties.Resources.exit;
            this.mi_quitGame.Name = "mi_quitGame";
            this.mi_quitGame.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.F4)));
            this.mi_quitGame.Size = new System.Drawing.Size(208, 22);
            this.mi_quitGame.Text = "Thoát Game";
            this.mi_quitGame.Click += new System.EventHandler(this.mi_quitGame_Click);
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_pause});
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.chứcNăngToolStripMenuItem.Text = "Chức Năng";
            // 
            // mi_pause
            // 
            this.mi_pause.Image = global::N.H.T_Game.Properties.Resources.pause;
            this.mi_pause.Name = "mi_pause";
            this.mi_pause.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.mi_pause.Size = new System.Drawing.Size(170, 22);
            this.mi_pause.Text = "Tạm dừng";
            this.mi_pause.Click += new System.EventHandler(this.mi_pause_Click);
            // 
            // hướngDẫnToolStripMenuItem
            // 
            this.hướngDẫnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_guilde});
            this.hướngDẫnToolStripMenuItem.Name = "hướngDẫnToolStripMenuItem";
            this.hướngDẫnToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.hướngDẫnToolStripMenuItem.Text = "Hướng dẫn";
            // 
            // mi_guilde
            // 
            this.mi_guilde.Image = global::N.H.T_Game.Properties.Resources.help_online;
            this.mi_guilde.Name = "mi_guilde";
            this.mi_guilde.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.mi_guilde.Size = new System.Drawing.Size(206, 22);
            this.mi_guilde.Text = "Hướng dẫn chơi";
            this.mi_guilde.Click += new System.EventHandler(this.mi_guilde_Click);
            // 
            // thôngTinToolStripMenuItem
            // 
            this.thôngTinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_teamInformation,
            this.mi_projectInfromation});
            this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.thôngTinToolStripMenuItem.Text = "Thông tin";
            // 
            // mi_teamInformation
            // 
            this.mi_teamInformation.Image = global::N.H.T_Game.Properties.Resources.Info;
            this.mi_teamInformation.Name = "mi_teamInformation";
            this.mi_teamInformation.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F2)));
            this.mi_teamInformation.Size = new System.Drawing.Size(227, 22);
            this.mi_teamInformation.Text = "Thông tin nhóm";
            this.mi_teamInformation.Click += new System.EventHandler(this.mi_teamInformation_Click);
            // 
            // mi_projectInfromation
            // 
            this.mi_projectInfromation.Image = global::N.H.T_Game.Properties.Resources.Info;
            this.mi_projectInfromation.Name = "mi_projectInfromation";
            this.mi_projectInfromation.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F3)));
            this.mi_projectInfromation.Size = new System.Drawing.Size(227, 22);
            this.mi_projectInfromation.Text = "Thông tin sản phẩm";
            this.mi_projectInfromation.Click += new System.EventHandler(this.mi_projectInfromation_Click);
            // 
            // mi_trogiup
            // 
            this.mi_trogiup.Name = "mi_trogiup";
            this.mi_trogiup.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F4)));
            this.mi_trogiup.Size = new System.Drawing.Size(63, 20);
            this.mi_trogiup.Text = "Trợ giúp";
            this.mi_trogiup.Click += new System.EventHandler(this.mi_trogiup_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(274, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nhập đáp án";
            // 
            // tb_value
            // 
            this.tb_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_value.Location = new System.Drawing.Point(270, 286);
            this.tb_value.Name = "tb_value";
            this.tb_value.Size = new System.Drawing.Size(219, 44);
            this.tb_value.TabIndex = 6;
            this.tb_value.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // lb_sussgest
            // 
            this.lb_sussgest.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sussgest.Location = new System.Drawing.Point(164, 176);
            this.lb_sussgest.Name = "lb_sussgest";
            this.lb_sussgest.Size = new System.Drawing.Size(466, 37);
            this.lb_sussgest.TabIndex = 7;
            this.lb_sussgest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 37);
            this.label4.TabIndex = 8;
            this.label4.Text = "Điểm";
            // 
            // lb_score
            // 
            this.lb_score.AutoSize = true;
            this.lb_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_score.Location = new System.Drawing.Point(33, 95);
            this.lb_score.Name = "lb_score";
            this.lb_score.Size = new System.Drawing.Size(87, 63);
            this.lb_score.TabIndex = 9;
            this.lb_score.Text = "00";
            // 
            // timerRandom
            // 
            this.timerRandom.Interval = 10;
            // 
            // timerTick
            // 
            this.timerTick.Enabled = true;
            this.timerTick.Tick += new System.EventHandler(this.timerTick_Tick);
            // 
            // bt_backmenu
            // 
            this.bt_backmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(75)))), ((int)(((byte)(28)))));
            this.bt_backmenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_backmenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_backmenu.Location = new System.Drawing.Point(300, 393);
            this.bt_backmenu.Name = "bt_backmenu";
            this.bt_backmenu.Size = new System.Drawing.Size(150, 40);
            this.bt_backmenu.TabIndex = 11;
            this.bt_backmenu.Text = "Trở về Menu";
            this.bt_backmenu.UseVisualStyleBackColor = false;
            this.bt_backmenu.Click += new System.EventHandler(this.bt_backmenu_Click);
            // 
            // bt_pause
            // 
            this.bt_pause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(75)))), ((int)(((byte)(28)))));
            this.bt_pause.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_pause.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_pause.Location = new System.Drawing.Point(300, 347);
            this.bt_pause.Name = "bt_pause";
            this.bt_pause.Size = new System.Drawing.Size(150, 40);
            this.bt_pause.TabIndex = 12;
            this.bt_pause.Text = "Tạm dừng";
            this.bt_pause.UseVisualStyleBackColor = false;
            this.bt_pause.Click += new System.EventHandler(this.bt_pause_Click);
            // 
            // pb_imageRight
            // 
            this.pb_imageRight.Image = global::N.H.T_Game.Properties.Resources.images__3_;
            this.pb_imageRight.Location = new System.Drawing.Point(576, 229);
            this.pb_imageRight.Name = "pb_imageRight";
            this.pb_imageRight.Size = new System.Drawing.Size(196, 198);
            this.pb_imageRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_imageRight.TabIndex = 14;
            this.pb_imageRight.TabStop = false;
            // 
            // pb_imageLeft
            // 
            this.pb_imageLeft.Image = global::N.H.T_Game.Properties.Resources.images;
            this.pb_imageLeft.Location = new System.Drawing.Point(12, 229);
            this.pb_imageLeft.Name = "pb_imageLeft";
            this.pb_imageLeft.Size = new System.Drawing.Size(193, 198);
            this.pb_imageLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_imageLeft.TabIndex = 13;
            this.pb_imageLeft.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(784, 444);
            this.Controls.Add(this.pb_imageRight);
            this.Controls.Add(this.pb_imageLeft);
            this.Controls.Add(this.bt_pause);
            this.Controls.Add(this.bt_backmenu);
            this.Controls.Add(this.lb_score);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_sussgest);
            this.Controls.Add(this.tb_value);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_time);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_random_number);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Đoán Số";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_imageRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_imageLeft)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_random_number;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_time;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mi_newgame;
        private System.Windows.Forms.ToolStripMenuItem mi_savescore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_value;
        private System.Windows.Forms.Label lb_sussgest;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_score;
        private System.Windows.Forms.Timer timerRandom;
        private System.Windows.Forms.Timer timerTick;
        private System.Windows.Forms.ToolStripMenuItem mi_backMenu;
        private System.Windows.Forms.ToolStripMenuItem mi_quitGame;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mi_pause;
        private System.Windows.Forms.ToolStripMenuItem hướngDẫnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mi_guilde;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mi_teamInformation;
        private System.Windows.Forms.ToolStripMenuItem mi_projectInfromation;
        private System.Windows.Forms.Button bt_backmenu;
        private System.Windows.Forms.Button bt_pause;
        private System.Windows.Forms.ToolStripMenuItem mi_trogiup;
        private System.Windows.Forms.PictureBox pb_imageLeft;
        private System.Windows.Forms.PictureBox pb_imageRight;

    }
}