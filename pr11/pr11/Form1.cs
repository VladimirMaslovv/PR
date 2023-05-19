using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr11
{
    public partial class Form1 : Form
    {
        private Bitmap[] Frames;
        private int FrameNum = 0;
        private int Speed = 0;

        public Form1()
        {
            InitializeComponent();
            Form1_Load();
        }

        private void Form1_Load()
        {
            Frames = new Bitmap[20];
            for(int i = 0; i< 10; i++)
            {
                Frames[i] = new Bitmap($"Frame{i}.png");
                Frames[19-i] = new Bitmap($"Frame{i}.png");
            }

            picFrame.Image = Frames[FrameNum];
        }        

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            //picFrame.Image = Frames[trackBar1.Value];
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Speed = 1; 

            if (timer1.Enabled == false) { timer1.Enabled = true; trackBar1.Enabled = false; button1.Text = "Stop"; }
            else { timer1.Enabled = false; trackBar1.Enabled = true; button1.Text = "Start"; }

            //FrameNum = ++FrameNum; if (FrameNum == 10) FrameNum = 9;
            //picFrame.Image = Frames[FrameNum];
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (Speed == trackBar1.Value)
            {
                Speed = 0;
                FrameNum = ++FrameNum % Frames.Length;
                picFrame.Image = Frames[FrameNum];
            }

            Speed++;
        }
    }
}
