namespace aim_gelistirme
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
            this.btnStop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnAim = new System.Windows.Forms.Button();
            this.btnHızlandır = new System.Windows.Forms.Button();
            this.btnYavaslat = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblSaniye = new System.Windows.Forms.Label();
            this.lblPoint = new System.Windows.Forms.Label();
            this.lblShowScore = new System.Windows.Forms.Label();
            this.lblSecond = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStop.Location = new System.Drawing.Point(1320, 763);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(77, 47);
            this.btnStop.TabIndex = 0;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnAim
            // 
            this.btnAim.BackColor = System.Drawing.Color.Red;
            this.btnAim.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAim.ForeColor = System.Drawing.Color.Red;
            this.btnAim.Location = new System.Drawing.Point(304, 130);
            this.btnAim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAim.Name = "btnAim";
            this.btnAim.Size = new System.Drawing.Size(33, 31);
            this.btnAim.TabIndex = 1;
            this.btnAim.UseVisualStyleBackColor = false;
            this.btnAim.Click += new System.EventHandler(this.btnAim_Click);
            // 
            // btnHızlandır
            // 
            this.btnHızlandır.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHızlandır.Location = new System.Drawing.Point(1405, 763);
            this.btnHızlandır.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHızlandır.Name = "btnHızlandır";
            this.btnHızlandır.Size = new System.Drawing.Size(85, 47);
            this.btnHızlandır.TabIndex = 2;
            this.btnHızlandır.Text = "Hız++";
            this.btnHızlandır.UseVisualStyleBackColor = true;
            this.btnHızlandır.Click += new System.EventHandler(this.btnHızlandır_Click);
            // 
            // btnYavaslat
            // 
            this.btnYavaslat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYavaslat.Location = new System.Drawing.Point(1499, 763);
            this.btnYavaslat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnYavaslat.Name = "btnYavaslat";
            this.btnYavaslat.Size = new System.Drawing.Size(76, 47);
            this.btnYavaslat.TabIndex = 3;
            this.btnYavaslat.Text = "Hız--";
            this.btnYavaslat.UseVisualStyleBackColor = true;
            this.btnYavaslat.Click += new System.EventHandler(this.btnYavaslat_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStart.Location = new System.Drawing.Point(1235, 763);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(77, 47);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lblSaniye
            // 
            this.lblSaniye.AutoSize = true;
            this.lblSaniye.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSaniye.Location = new System.Drawing.Point(1315, 11);
            this.lblSaniye.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaniye.Name = "lblSaniye";
            this.lblSaniye.Size = new System.Drawing.Size(20, 25);
            this.lblSaniye.TabIndex = 5;
            this.lblSaniye.Text = "-";
            // 
            // lblPoint
            // 
            this.lblPoint.AutoSize = true;
            this.lblPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPoint.Location = new System.Drawing.Point(1315, 50);
            this.lblPoint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPoint.Name = "lblPoint";
            this.lblPoint.Size = new System.Drawing.Size(20, 25);
            this.lblPoint.TabIndex = 6;
            this.lblPoint.Text = "-";
            // 
            // lblShowScore
            // 
            this.lblShowScore.AutoSize = true;
            this.lblShowScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblShowScore.Location = new System.Drawing.Point(1203, 50);
            this.lblShowScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShowScore.Name = "lblShowScore";
            this.lblShowScore.Size = new System.Drawing.Size(69, 25);
            this.lblShowScore.TabIndex = 7;
            this.lblShowScore.Text = "Score";
            // 
            // lblSecond
            // 
            this.lblSecond.AutoSize = true;
            this.lblSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSecond.Location = new System.Drawing.Point(1203, 11);
            this.lblSecond.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(86, 25);
            this.lblSecond.TabIndex = 8;
            this.lblSecond.Text = "Second";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1579, 814);
            this.Controls.Add(this.lblSecond);
            this.Controls.Add(this.lblShowScore);
            this.Controls.Add(this.lblPoint);
            this.Controls.Add(this.lblSaniye);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnYavaslat);
            this.Controls.Add(this.btnHızlandır);
            this.Controls.Add(this.btnAim);
            this.Controls.Add(this.btnStop);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aim";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnAim;
        private System.Windows.Forms.Button btnHızlandır;
        private System.Windows.Forms.Button btnYavaslat;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblSaniye;
        private System.Windows.Forms.Label lblPoint;
        private System.Windows.Forms.Label lblShowScore;
        private System.Windows.Forms.Label lblSecond;
    }
}

