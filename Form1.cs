using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private Tetris tetris;
        private Timer timer;
        private int pause = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            tetris = new Tetris(this);
            this.KeyPreview = true;
            timer = new Timer();
            timer.Interval = 400; // saniye*1000;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
            timer.Enabled = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            tetris.Asagi(this);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer.Stop();
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            if (pause == 0)
            {
                btnOlustur.Text = "Resume";
                timer.Stop();
                pause = 1;
            }
            else
            {
                btnOlustur.Text = "Pause";
                timer.Start();
                pause = 0;
            }
        }

        public void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 's' || e.KeyChar == 'S') 
                tetris.Asagi(this);
            if (e.KeyChar == 'd' || e.KeyChar == 'D')
                tetris.Sag(this);
            if (e.KeyChar == 'a' || e.KeyChar == 'A')
                tetris.Sol(this);
            if (e.KeyChar == 'w' || e.KeyChar == 'W')
                tetris.Dondur(this);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

        }

    }
}
