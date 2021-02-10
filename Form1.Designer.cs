
namespace agiltpong
{
    partial class Form1
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
            this.pongtimer = new System.Windows.Forms.Timer(this.components);
            this.Spelare = new System.Windows.Forms.Label();
            this.boll = new System.Windows.Forms.PictureBox();
            this.Motståndare = new System.Windows.Forms.Label();
            this.platta = new System.Windows.Forms.PictureBox();
            this.platta2 = new System.Windows.Forms.PictureBox();
            this.startText = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.youWin = new System.Windows.Forms.Label();
            this.youLose = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.boll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platta2)).BeginInit();
            this.SuspendLayout();
            // 
            // pongtimer
            // 
            this.pongtimer.Enabled = true;
            this.pongtimer.Interval = 20;
            this.pongtimer.Tick += new System.EventHandler(this.timerTick);
            // 
            // Spelare
            // 
            this.Spelare.AutoSize = true;
            this.Spelare.BackColor = System.Drawing.Color.Black;
            this.Spelare.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Spelare.ForeColor = System.Drawing.Color.Cyan;
            this.Spelare.Location = new System.Drawing.Point(105, 9);
            this.Spelare.Name = "Spelare";
            this.Spelare.Size = new System.Drawing.Size(36, 26);
            this.Spelare.TabIndex = 3;
            this.Spelare.Text = "00";
            // 
            // boll
            // 
            this.boll.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.boll.Location = new System.Drawing.Point(434, 239);
            this.boll.Name = "boll";
            this.boll.Size = new System.Drawing.Size(27, 26);
            this.boll.TabIndex = 2;
            this.boll.TabStop = false;
            // 
            // Motståndare
            // 
            this.Motståndare.AutoSize = true;
            this.Motståndare.BackColor = System.Drawing.Color.Black;
            this.Motståndare.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Motståndare.ForeColor = System.Drawing.Color.Red;
            this.Motståndare.Location = new System.Drawing.Point(735, 9);
            this.Motståndare.Name = "Motståndare";
            this.Motståndare.Size = new System.Drawing.Size(36, 26);
            this.Motståndare.TabIndex = 4;
            this.Motståndare.Text = "00";
            // 
            // platta
            // 
            this.platta.BackColor = System.Drawing.Color.Cyan;
            this.platta.Location = new System.Drawing.Point(12, 230);
            this.platta.Name = "platta";
            this.platta.Size = new System.Drawing.Size(26, 127);
            this.platta.TabIndex = 0;
            this.platta.TabStop = false;
            // 
            // platta2
            // 
            this.platta2.BackColor = System.Drawing.Color.Red;
            this.platta2.Location = new System.Drawing.Point(889, 230);
            this.platta2.Name = "platta2";
            this.platta2.Size = new System.Drawing.Size(27, 127);
            this.platta2.TabIndex = 1;
            this.platta2.TabStop = false;
            // 
            // startText
            // 
            this.startText.AutoSize = true;
            this.startText.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.startText.ForeColor = System.Drawing.Color.FloralWhite;
            this.startText.Location = new System.Drawing.Point(110, 252);
            this.startText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.startText.Name = "startText";
            this.startText.Size = new System.Drawing.Size(707, 63);
            this.startText.TabIndex = 5;
            this.startText.Text = "PRESS \'SPACE\' TO START";
            // 
            // txtResult
            // 
            this.txtResult.Enabled = false;
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(272, 10);
            this.txtResult.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(126, 26);
            this.txtResult.TabIndex = 7;
            this.txtResult.Text = "00:00:00";
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // youWin
            // 
            this.youWin.AutoSize = true;
            this.youWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.youWin.ForeColor = System.Drawing.Color.FloralWhite;
            this.youWin.Location = new System.Drawing.Point(314, 239);
            this.youWin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.youWin.Name = "youWin";
            this.youWin.Size = new System.Drawing.Size(326, 76);
            this.youWin.TabIndex = 8;
            this.youWin.Text = "YOU WIN";
            this.youWin.Visible = false;
            // 
            // youLose
            // 
            this.youLose.AutoSize = true;
            this.youLose.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.youLose.ForeColor = System.Drawing.Color.FloralWhite;
            this.youLose.Location = new System.Drawing.Point(289, 239);
            this.youLose.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.youLose.Name = "youLose";
            this.youLose.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.youLose.Size = new System.Drawing.Size(375, 76);
            this.youLose.TabIndex = 11;
            this.youLose.Text = "YOU LOSE";
            this.youLose.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(928, 574);
            this.Controls.Add(this.youLose);
            this.Controls.Add(this.youWin);
            this.Controls.Add(this.startText);
            this.Controls.Add(this.Motståndare);
            this.Controls.Add(this.Spelare);
            this.Controls.Add(this.boll);
            this.Controls.Add(this.platta2);
            this.Controls.Add(this.platta);
            this.Controls.Add(this.txtResult);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.boll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platta2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Timer pongtimer;
        private System.Windows.Forms.Label Spelare;
        private System.Windows.Forms.PictureBox boll;
        private System.Windows.Forms.Label Motståndare;
        private System.Windows.Forms.PictureBox platta;
        private System.Windows.Forms.PictureBox platta2;
        private System.Windows.Forms.Label startText;
        private System.Windows.Forms.Label youWin;
        private System.Windows.Forms.Label youLose;
    }
}

