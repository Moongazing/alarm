using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace çalarSaat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        System.Media.SoundPlayer player;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1000;
            button1.Enabled = false;
            button2.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (player != null) player.Stop();
            timer1.Enabled = false;
            button1.Enabled = true;
            button2.Enabled = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(dateTimePicker1.Value<=DateTime.Now)
            {
                timer1.Enabled = false;
                button1.Enabled = true;
                button2.Enabled = false;

                player = new System.Media.SoundPlayer();
                string path = Application.StartupPath.ToString() + "\\Ölümsüz.wav";
                player.SoundLocation = path;
                player.Play();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
