using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aim_gelistirme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int _sayac = 0;
        int _saniye = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            lblPoint.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int x, y;
            Random rnd = new Random();

            x = rnd.Next(0, 1000);
            y = rnd.Next(0, 650);

            btnAim.Location = new Point(x, y);
        }

        private void btnAim_Click(object sender, EventArgs e)
        {
            _sayac++;
            lblPoint.Text = _sayac.ToString();
        }

        private void btnHızlandır_Click(object sender, EventArgs e)
        {
            timer1.Interval -= 100;
        }

        private void btnYavaslat_Click(object sender, EventArgs e)
        {
            timer1.Interval += 100;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            MessageBox.Show(_sayac.ToString(),"Your score");
            _saniye = 0;
            _sayac = 0;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lblSaniye.Text = _saniye++.ToString();
        }
    }


}
