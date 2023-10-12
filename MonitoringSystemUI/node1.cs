using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonitoringSystemUI
{
    public partial class node1 : Form
    {
        public node1()
        {
            InitializeComponent();
        }

        private void node1_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.uiMode = "None";
            axWindowsMediaPlayer2.URL = "video.mp4";
            axWindowsMediaPlayer2.settings.autoStart = true;
            axWindowsMediaPlayer2.settings.setMode("loop", true);
        }

        private void node1_FormClosing(object sender, FormClosingEventArgs e)
        {
            axWindowsMediaPlayer2.Ctlcontrols.pause();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }



        /*private void timer1_Tick(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer2.Ctlcontrols.currentPosition == 59.9)
            {
                axWindowsMediaPlayer2.PlayStateChange += axWindowsMediaPlayer2_PlayStateChange;
                // Rewind and play the video again
                axWindowsMediaPlayer2.Ctlcontrols.currentPosition = 0;
                axWindowsMediaPlayer2.Ctlcontrols.play();
            }


        }*/
    }
}
