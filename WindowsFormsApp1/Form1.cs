using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnResimYukle_Click(object sender, EventArgs e)
        {
            ResimYukle();
        }
        private void ResimYukle()
        {
            int i =0;
            folderBrowserDialog1.ShowDialog();
            foreach (string dosya in Directory.GetFiles(folderBrowserDialog1.SelectedPath))
            {
                FileInfo file = new FileInfo(dosya);
                if (file.Extension == ".jpg" || file.Extension == ".JPEG")
                {
                    Button btn = new Button();
                    btn.Width = 20;
                    btn.Height = 20;
                    btn.Left = 20 * i;
                    btn.Top = 10;
                    btn.Tag = dosya;
                    btn.Text = (1 + i).ToString();
                    btn.Click += Btn_Click;
                    panel1.Controls.Add(btn);
                    i++;
                }
            }
           
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = ((Button)sender).Tag.ToString();
            
        }
    }
}
