﻿namespace N.H.T_Game
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
            this.lb_random_number = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_time = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_newgame = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_savescore = new System.Windows.Forms.ToolStripMenuItem();
            this.trởVềMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tạmDừngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hướngDẫnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hướngDẫnChơiGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinNhómToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_value = new System.Windows.Forms.TextBox();
            this.lb_sussgest = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_score = new System.Windows.Forms.Label();
            this.timerRandom = new System.Windows.Forms.Timer(this.components);
            this.timerTick = new System.Windows.Forms.Timer(this.components);
            this.bt_backmenu = new System.Windows.Forms.Button();
            this.bt_pause = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_random_number
            // 
            this.lb_random_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_random_number.Location = new System.Drawing.Point(174, 94);
            this.lb_random_number.Name = "lb_random_number";
            this.lb_random_number.Size = new System.Drawing.Size(384, 63);
            this.lb_random_number.TabIndex = 0;
            this.lb_random_number.Text = "Đoán đi ";
            this.lb_random_number.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(252, 58);
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
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.chứcNăngToolStripMenuItem,
            this.hướngDẫnToolStripMenuItem,
            this.thôngTinToolStripMenuItem});
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
            this.trởVềMenuToolStripMenuItem,
            this.thoátGameToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // mi_newgame
            // 
            this.mi_newgame.Name = "mi_newgame";
            this.mi_newgame.Size = new System.Drawing.Size(152, 22);
            this.mi_newgame.Text = "Chơi mới";
            this.mi_newgame.Click += new System.EventHandler(this.mi_newgame_Click);
            // 
            // mi_savescore
            // 
            this.mi_savescore.Name = "mi_savescore";
            this.mi_savescore.Size = new System.Drawing.Size(152, 22);
            this.mi_savescore.Text = "Lưu điểm";
            this.mi_savescore.Click += new System.EventHandler(this.mi_savescore_Click);
            // 
            // trởVềMenuToolStripMenuItem
            // 
            this.trởVềMenuToolStripMenuItem.Name = "trởVềMenuToolStripMenuItem";
            this.trởVềMenuToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.trởVềMenuToolStripMenuItem.Text = "Trở về Menu";
            // 
            // thoátGameToolStripMenuItem
            // 
            this.thoátGameToolStripMenuItem.Name = "thoátGameToolStripMenuItem";
            this.thoátGameToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.thoátGameToolStripMenuItem.Text = "Thoát Game";
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tạmDừngToolStripMenuItem});
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.chứcNăngToolStripMenuItem.Text = "Chức Năng";
            // 
            // tạmDừngToolStripMenuItem
            // 
            this.tạmDừngToolStripMenuItem.Name = "tạmDừngToolStripMenuItem";
            this.tạmDừngToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.tạmDừngToolStripMenuItem.Text = "Tạm dừng";
            // 
            // hướngDẫnToolStripMenuItem
            // 
            this.hướngDẫnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hướngDẫnChơiGameToolStripMenuItem});
            this.hướngDẫnToolStripMenuItem.Name = "hướngDẫnToolStripMenuItem";
            this.hướngDẫnToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.hướngDẫnToolStripMenuItem.Text = "Hướng dẫn";
            // 
            // hướngDẫnChơiGameToolStripMenuItem
            // 
            this.hướngDẫnChơiGameToolStripMenuItem.Name = "hướngDẫnChơiGameToolStripMenuItem";
            this.hướngDẫnChơiGameToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.hướngDẫnChơiGameToolStripMenuItem.Text = "Hướng dẫn chơi";
            // 
            // thôngTinToolStripMenuItem
            // 
            this.thôngTinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinNhómToolStripMenuItem,
            this.thôngTinSảnPhẩmToolStripMenuItem});
            this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.thôngTinToolStripMenuItem.Text = "Thông tin";
            // 
            // thôngTinNhómToolStripMenuItem
            // 
            this.thôngTinNhómToolStripMenuItem.Name = "thôngTinNhómToolStripMenuItem";
            this.thôngTinNhómToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.thôngTinNhómToolStripMenuItem.Text = "Thông tin nhóm";
            // 
            // thôngTinSảnPhẩmToolStripMenuItem
            // 
            this.thôngTinSảnPhẩmToolStripMenuItem.Name = "thôngTinSảnPhẩmToolStripMenuItem";
            this.thôngTinSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.thôngTinSảnPhẩmToolStripMenuItem.Text = "Thông tin sản phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(255, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nhập đáp án";
            // 
            // tb_value
            // 
            this.tb_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_value.Location = new System.Drawing.Point(257, 288);
            this.tb_value.Name = "tb_value";
            this.tb_value.Size = new System.Drawing.Size(219, 44);
            this.tb_value.TabIndex = 6;
            this.tb_value.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // lb_sussgest
            // 
            this.lb_sussgest.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sussgest.Location = new System.Drawing.Point(109, 356);
            this.lb_sussgest.Name = "lb_sussgest";
            this.lb_sussgest.Size = new System.Drawing.Size(502, 37);
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
            this.bt_backmenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_backmenu.Location = new System.Drawing.Point(161, 406);
            this.bt_backmenu.Name = "bt_backmenu";
            this.bt_backmenu.Size = new System.Drawing.Size(150, 40);
            this.bt_backmenu.TabIndex = 11;
            this.bt_backmenu.Text = "Trở về Menu";
            this.bt_backmenu.UseVisualStyleBackColor = true;
            this.bt_backmenu.Click += new System.EventHandler(this.bt_backmenu_Click);
            // 
            // bt_pause
            // 
            this.bt_pause.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_pause.Location = new System.Drawing.Point(408, 406);
            this.bt_pause.Name = "bt_pause";
            this.bt_pause.Size = new System.Drawing.Size(150, 40);
            this.bt_pause.TabIndex = 12;
            this.bt_pause.Text = "Tạm dừng";
            this.bt_pause.UseVisualStyleBackColor = true;
            this.bt_pause.Click += new System.EventHandler(this.bt_pause_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 561);
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
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem trởVềMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tạmDừngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hướngDẫnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hướngDẫnChơiGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinNhómToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinSảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.Button bt_backmenu;
        private System.Windows.Forms.Button bt_pause;

    }
}