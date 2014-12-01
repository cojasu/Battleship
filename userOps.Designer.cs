namespace BattleshipTest
{
    partial class userOps
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
            this.p1Comp = new System.Windows.Forms.RadioButton();
            this.p1Player = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.diffEasy = new System.Windows.Forms.RadioButton();
            this.diffNormal = new System.Windows.Forms.RadioButton();
            this.diffHard = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.debug = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.playButton = new System.Windows.Forms.Button();
            this.checkBoxDemoMode = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // p1Comp
            // 
            this.p1Comp.AutoSize = true;
            this.p1Comp.Location = new System.Drawing.Point(88, 23);
            this.p1Comp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.p1Comp.Name = "p1Comp";
            this.p1Comp.Size = new System.Drawing.Size(90, 21);
            this.p1Comp.TabIndex = 0;
            this.p1Comp.Text = "Computer";
            this.p1Comp.UseVisualStyleBackColor = true;
            this.p1Comp.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // p1Player
            // 
            this.p1Player.AutoSize = true;
            this.p1Player.Checked = true;
            this.p1Player.Location = new System.Drawing.Point(8, 23);
            this.p1Player.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.p1Player.Name = "p1Player";
            this.p1Player.Size = new System.Drawing.Size(69, 21);
            this.p1Player.TabIndex = 1;
            this.p1Player.TabStop = true;
            this.p1Player.Text = "Player";
            this.p1Player.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.p1Player);
            this.groupBox1.Controls.Add(this.p1Comp);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(197, 58);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "First Move";
            // 
            // diffEasy
            // 
            this.diffEasy.AutoSize = true;
            this.diffEasy.Location = new System.Drawing.Point(29, 25);
            this.diffEasy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.diffEasy.Name = "diffEasy";
            this.diffEasy.Size = new System.Drawing.Size(60, 21);
            this.diffEasy.TabIndex = 0;
            this.diffEasy.Text = "Easy";
            this.diffEasy.UseVisualStyleBackColor = true;
            this.diffEasy.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // diffNormal
            // 
            this.diffNormal.AutoSize = true;
            this.diffNormal.Location = new System.Drawing.Point(135, 25);
            this.diffNormal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.diffNormal.Name = "diffNormal";
            this.diffNormal.Size = new System.Drawing.Size(74, 21);
            this.diffNormal.TabIndex = 1;
            this.diffNormal.Text = "Normal";
            this.diffNormal.UseVisualStyleBackColor = true;
            // 
            // diffHard
            // 
            this.diffHard.AutoSize = true;
            this.diffHard.Checked = true;
            this.diffHard.Location = new System.Drawing.Point(249, 25);
            this.diffHard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.diffHard.Name = "diffHard";
            this.diffHard.Size = new System.Drawing.Size(60, 21);
            this.diffHard.TabIndex = 2;
            this.diffHard.TabStop = true;
            this.diffHard.Text = "Hard";
            this.diffHard.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.diffHard);
            this.groupBox2.Controls.Add(this.diffNormal);
            this.groupBox2.Controls.Add(this.diffEasy);
            this.groupBox2.Location = new System.Drawing.Point(16, 95);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(351, 63);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Difficulty";
            // 
            // debug
            // 
            this.debug.AutoSize = true;
            this.debug.Location = new System.Drawing.Point(59, 27);
            this.debug.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.debug.Name = "debug";
            this.debug.Size = new System.Drawing.Size(18, 17);
            this.debug.TabIndex = 0;
            this.debug.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.debug);
            this.groupBox3.Location = new System.Drawing.Point(235, 15);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(132, 58);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Debug Mode";
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(149, 181);
            this.playButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(100, 28);
            this.playButton.TabIndex = 4;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.button_clicked);
            // 
            // checkBoxDemoMode
            // 
            this.checkBoxDemoMode.AutoSize = true;
            this.checkBoxDemoMode.Location = new System.Drawing.Point(16, 181);
            this.checkBoxDemoMode.Name = "checkBoxDemoMode";
            this.checkBoxDemoMode.Size = new System.Drawing.Size(106, 21);
            this.checkBoxDemoMode.TabIndex = 5;
            this.checkBoxDemoMode.Text = "Demo Mode";
            this.checkBoxDemoMode.UseVisualStyleBackColor = true;
            // 
            // userOps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(383, 228);
            this.Controls.Add(this.checkBoxDemoMode);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "userOps";
            this.Text = "Battleship Options";
            this.Load += new System.EventHandler(this.userOps_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton p1Comp;
        private System.Windows.Forms.RadioButton p1Player;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton diffEasy;
        private System.Windows.Forms.RadioButton diffNormal;
        private System.Windows.Forms.RadioButton diffHard;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox debug;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.CheckBox checkBoxDemoMode;

    }
}