﻿
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
            this.Spelare.Location = new System.Drawing.Point(140, 11);
            this.Spelare.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Spelare.Name = "Spelare";
            this.Spelare.Size = new System.Drawing.Size(44, 31);
            this.Spelare.TabIndex = 3;
            this.Spelare.Text = "00";
            // 
            // boll
            // 
            this.boll.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.boll.Location = new System.Drawing.Point(579, 294);
            this.boll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.boll.Name = "boll";
            this.boll.Size = new System.Drawing.Size(36, 32);
            this.boll.TabIndex = 2;
            this.boll.TabStop = false;
            // 
            // Motståndare
            // 
            this.Motståndare.AutoSize = true;
            this.Motståndare.BackColor = System.Drawing.Color.Black;
            this.Motståndare.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Motståndare.ForeColor = System.Drawing.Color.Cyan;
            this.Motståndare.Location = new System.Drawing.Point(980, 11);
            this.Motståndare.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Motståndare.Name = "Motståndare";
            this.Motståndare.Size = new System.Drawing.Size(44, 31);
            this.Motståndare.TabIndex = 4;
            this.Motståndare.Text = "00";
            // 
            // platta
            // 
            this.platta.BackColor = System.Drawing.Color.Cyan;
            this.platta.Location = new System.Drawing.Point(16, 283);
            this.platta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.platta.Name = "platta";
            this.platta.Size = new System.Drawing.Size(35, 156);
            this.platta.TabIndex = 0;
            this.platta.TabStop = false;
            // 
            // platta2
            // 
            this.platta2.BackColor = System.Drawing.Color.Red;
            this.platta2.Location = new System.Drawing.Point(1185, 283);
            this.platta2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.platta2.Name = "platta2";
            this.platta2.Size = new System.Drawing.Size(36, 156);
            this.platta2.TabIndex = 1;
            this.platta2.TabStop = false;
            // 
            // startText
            // 
            this.startText.AutoSize = true;
            this.startText.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startText.ForeColor = System.Drawing.Color.FloralWhite;
            this.startText.Location = new System.Drawing.Point(67, 294);
            this.startText.Name = "startText";
            this.startText.Size = new System.Drawing.Size(1099, 95);
            this.startText.TabIndex = 5;
            this.startText.Text = "PRESS \'SPACE\' TO START";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1237, 706);
            this.Controls.Add(this.startText);
            this.Controls.Add(this.Motståndare);
            this.Controls.Add(this.Spelare);
            this.Controls.Add(this.boll);
            this.Controls.Add(this.platta2);
            this.Controls.Add(this.platta);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.boll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platta2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer pongtimer;
        private System.Windows.Forms.Label Spelare;
        private System.Windows.Forms.PictureBox boll;
        private System.Windows.Forms.Label Motståndare;
        private System.Windows.Forms.PictureBox platta;
        private System.Windows.Forms.PictureBox platta2;
        private System.Windows.Forms.Label startText;
    }
}

