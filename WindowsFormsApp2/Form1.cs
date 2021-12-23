using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = rnd.Next(0, 101);
            progressBar2.Value = rnd.Next(0, 101);
            progressBar3.Value = rnd.Next(0, 101);
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void btnDurdur_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            progressBar1.Value = 0;
            progressBar2.Value = 0;
            progressBar3.Value = 0;
        }

        private void btnYukle_Click(object sender, EventArgs e)
        {
           
            pictureBox1.ImageLocation = @"C:\Yeni klasör\Adsız.bmp";
        }

        private void pictureBox1_LoadProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar4.Value = e.ProgressPercentage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = ımageList2.Images[0];
        }
    }
}
