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
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // p1Comp
            // 
            this.p1Comp.AutoSize = true;
            this.p1Comp.Location = new System.Drawing.Point(66, 19);
            this.p1Comp.Name = "p1Comp";
            this.p1Comp.Size = new System.Drawing.Size(70, 17);
            this.p1Comp.TabIndex = 0;
            this.p1Comp.Text = "Computer";
            this.p1Comp.UseVisualStyleBackColor = true;
            this.p1Comp.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // p1Player
            // 
            this.p1Player.AutoSize = true;
            this.p1Player.Checked = true;
            this.p1Player.Location = new System.Drawing.Point(6, 19);
            this.p1Player.Name = "p1Player";
            this.p1Player.Size = new System.Drawing.Size(54, 17);
            this.p1Player.TabIndex = 1;
            this.p1Player.TabStop = true;
            this.p1Player.Text = "Player";
            this.p1Player.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.p1Player);
            this.groupBox1.Controls.Add(this.p1Comp);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(148, 47);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "First Move";
            // 
            // diffEasy
            // 
            this.diffEasy.AutoSize = true;
            this.diffEasy.Location = new System.Drawing.Point(22, 20);
            this.diffEasy.Name = "diffEasy";
            this.diffEasy.Size = new System.Drawing.Size(48, 17);
            this.diffEasy.TabIndex = 0;
            this.diffEasy.Text = "Easy";
            this.diffEasy.UseVisualStyleBackColor = true;
            this.diffEasy.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // diffNormal
            // 
            this.diffNormal.AutoSize = true;
            this.diffNormal.Location = new System.Drawing.Point(101, 20);
            this.diffNormal.Name = "diffNormal";
            this.diffNormal.Size = new System.Drawing.Size(58, 17);
            this.diffNormal.TabIndex = 1;
            this.diffNormal.Text = "Normal";
            this.diffNormal.UseVisualStyleBackColor = true;
            // 
            // diffHard
            // 
            this.diffHard.AutoSize = true;
            this.diffHard.Checked = true;
            this.diffHard.Location = new System.Drawing.Point(187, 20);
            this.diffHard.Name = "diffHard";
            this.diffHard.Size = new System.Drawing.Size(48, 17);
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
            this.groupBox2.Location = new System.Drawing.Point(12, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 51);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Difficulty";
            // 
            // debug
            // 
            this.debug.AutoSize = true;
            this.debug.Location = new System.Drawing.Point(44, 22);
            this.debug.Name = "debug";
            this.debug.Size = new System.Drawing.Size(15, 14);
            this.debug.TabIndex = 0;
            this.debug.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.debug);
            this.groupBox3.Location = new System.Drawing.Point(176, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(99, 47);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Debug Mode";
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(112, 147);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(75, 23);
            this.playButton.TabIndex = 4;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.button_clicked);
            // 
            // userOps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(287, 185);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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

    }
}