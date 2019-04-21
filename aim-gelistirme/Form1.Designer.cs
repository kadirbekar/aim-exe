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
            this.SuspendLayout();
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStop.Location = new System.Drawing.Point(990, 620);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(58, 38);
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
            this.btnAim.Location = new System.Drawing.Point(228, 106);
            this.btnAim.Name = "btnAim";
            this.btnAim.Size = new System.Drawing.Size(25, 25);
            this.btnAim.TabIndex = 1;
            this.btnAim.UseVisualStyleBackColor = false;
            this.btnAim.Click += new System.EventHandler(this.btnAim_Click);
            // 
            // btnHızlandır
            // 
            this.btnHızlandır.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHızlandır.Location = new System.Drawing.Point(1054, 620);
            this.btnHızlandır.Name = "btnHızlandır";
            this.btnHızlandır.Size = new System.Drawing.Size(64, 38);
            this.btnHızlandır.TabIndex = 2;
            this.btnHızlandır.Text = "Hız++";
            this.btnHızlandır.UseVisualStyleBackColor = true;
            this.btnHızlandır.Click += new System.EventHandler(this.btnHızlandır_Click);
            // 
            // btnYavaslat
            // 
            this.btnYavaslat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYavaslat.Location = new System.Drawing.Point(1124, 620);
            this.btnYavaslat.Name = "btnYavaslat";
            this.btnYavaslat.Size = new System.Drawing.Size(57, 38);
            this.btnYavaslat.TabIndex = 3;
            this.btnYavaslat.Text = "Hız--";
            this.btnYavaslat.UseVisualStyleBackColor = true;
            this.btnYavaslat.Click += new System.EventHandler(this.btnYavaslat_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStart.Location = new System.Drawing.Point(926, 620);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(58, 38);
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
            this.lblSaniye.Location = new System.Drawing.Point(986, 9);
            this.lblSaniye.Name = "lblSaniye";
            this.lblSaniye.Size = new System.Drawing.Size(15, 20);
            this.lblSaniye.TabIndex = 5;
            this.lblSaniye.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.lblSaniye);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnYavaslat);
            this.Controls.Add(this.btnHızlandır);
            this.Controls.Add(this.btnAim);
            this.Controls.Add(this.btnStop);
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
    }
}

