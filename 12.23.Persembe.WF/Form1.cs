using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12._23.Persembe.WF
{
    public enum Seviye { Kolay = 10, Orta = 15, Zor = 25 }

    public partial class Form1 : Form
    {
        Seviye seviye;
        int boş;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            seviye = Seviye.Kolay;
            
        }
        private void başlatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MayinTarlasiOlustur(seviye);
            MayinYerlestir(seviye);
        }
        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void başlangıçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SeviyeTemizle();
            seviye = Seviye.Kolay;
            başlangıçToolStripMenuItem.Checked = true;

        }
        private void ortaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SeviyeTemizle();
            seviye = Seviye.Orta;
            ortaToolStripMenuItem.Checked = true;

        }
        private void zorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SeviyeTemizle();
            seviye = Seviye.Zor;
            zorToolStripMenuItem.Checked = true;

        }
        private void MayinTarlasiOlustur(Seviye seviye)
        {
            splitContainer1.Panel2.Controls.Clear();
            int sayac = (int)seviye;
            int toplam = 20;
            boş = (sayac * sayac) - (sayac * (sayac / 5));
            for (int i = 0; i < sayac; i++)
            {
                for (int j = 0; j < sayac; j++)
                {
                    Button btn = new Button();
                    btn.Width = 20;
                    btn.Height = 20;
                    btn.Left = 270 + j * 20;
                    btn.Top = 25 + i * toplam;
                    btn.Tag = false;
                    btn.TabStop = false;
                    btn.Click += Btn_Click;
                    splitContainer1.Panel2.Controls.Add(btn);
                }
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if ((bool)btn.Tag == true)
            {
                btn.BackColor = Color.Red;
                MessageBox.Show("Game Over");
                splitContainer1.Panel2.Controls.Clear();
            }
            else
            {
                btn.Enabled = false;
                //splitContainer1.Panel2.Controls.Remove(btn);
                boş--;
                if (boş == 0)
                {
                    MessageBox.Show("Kazandınız.");
                    splitContainer1.Panel2.Controls.Clear();
                }

            }
        }

        private void SeviyeTemizle()
        {
            foreach (ToolStripMenuItem item in zorlukToolStripMenuItem.DropDownItems)
            {
                item.Checked = false;
            }
        }
        private void MayinYerlestir(Seviye seviye)
        {
            Random rnd = new Random();
            int sayaç = (int)seviye;
            int mayinsayisi = sayaç * (sayaç / 5);
            int i = 0;
            while (i < mayinsayisi)
            {
                int indis = rnd.Next(0, sayaç * sayaç);
                if ((bool)splitContainer1.Panel2.Controls[indis].Tag != true)
                {
                    splitContainer1.Panel2.Controls[indis].Tag = true;
                    splitContainer1.Panel2.Controls[indis].Text = "#";
                    i++;
                }
            }
        }


    }
}
