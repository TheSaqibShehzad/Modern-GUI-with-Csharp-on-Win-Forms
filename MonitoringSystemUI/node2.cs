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
    public partial class node2 : Form
    {
        public node2()
        {
            InitializeComponent();
        }

        private void node2_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.uiMode = "None";
            axWindowsMediaPlayer2.URL = "video.mp4";
            axWindowsMediaPlayer2.settings.autoStart = true;
            axWindowsMediaPlayer2.settings.setMode("loop", true);
        }

        private void node2_FormClosing(object sender, FormClosingEventArgs e)
        {
            axWindowsMediaPlayer2.Ctlcontrols.pause();
        }
    }
}
