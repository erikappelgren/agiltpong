
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
            this.Motståndare.ForeColor = System.Drawing.Color.Cyan;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(928, 574);
            this.Controls.Add(this.Motståndare);
            this.Controls.Add(this.Spelare);
            this.Controls.Add(this.boll);
            this.Controls.Add(this.platta2);
            this.Controls.Add(this.platta);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

