namespace N.H.T_Game
{
    partial class FormSaveScore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSaveScore));
            this.lb_inputname = new System.Windows.Forms.Label();
            this.lb_save = new System.Windows.Forms.Label();
            this.tb_save = new System.Windows.Forms.TextBox();
            this.bt_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_inputname
            // 
            this.lb_inputname.AutoSize = true;
            this.lb_inputname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_inputname.Location = new System.Drawing.Point(46, 67);
            this.lb_inputname.Name = "lb_inputname";
            this.lb_inputname.Size = new System.Drawing.Size(183, 26);
            this.lb_inputname.TabIndex = 0;
            this.lb_inputname.Text = "Nhập tên của bạn";
            // 
            // lb_save
            // 
            this.lb_save.AutoSize = true;
            this.lb_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_save.Location = new System.Drawing.Point(81, 9);
            this.lb_save.Name = "lb_save";
            this.lb_save.Size = new System.Drawing.Size(114, 26);
            this.lb_save.TabIndex = 1;
            this.lb_save.Text = "Lưu Điểm";
            // 
            // tb_save
            // 
            this.tb_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_save.Location = new System.Drawing.Point(61, 113);
            this.tb_save.Name = "tb_save";
            this.tb_save.Size = new System.Drawing.Size(150, 32);
            this.tb_save.TabIndex = 2;
            this.tb_save.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_save_KeyDown);
            // 
            // bt_ok
            // 
            this.bt_ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(75)))), ((int)(((byte)(28)))));
            this.bt_ok.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_ok.Location = new System.Drawing.Point(86, 176);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(100, 32);
            this.bt_ok.TabIndex = 3;
            this.bt_ok.Text = "OK";
            this.bt_ok.UseVisualStyleBackColor = false;
            this.bt_ok.Click += new System.EventHandler(this.btOK_Click);
            // 
            // FormSaveScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(284, 221);
            this.Controls.Add(this.bt_ok);
            this.Controls.Add(this.tb_save);
            this.Controls.Add(this.lb_save);
            this.Controls.Add(this.lb_inputname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormSaveScore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lưu Điểm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_inputname;
        private System.Windows.Forms.Label lb_save;
        private System.Windows.Forms.TextBox tb_save;
        private System.Windows.Forms.Button bt_ok;
    }
}