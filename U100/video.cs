using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace U100
{
    public partial class video : Form
    {
        public string crtDir = Directory.GetCurrentDirectory().ToString() + @"\informatii_unire";
        public video()
        {
            InitializeComponent();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            
        }

        private void video_Load(object sender, EventArgs e)
        {
            crtDir = Directory.GetCurrentDirectory().ToString() + @"\informatii_unire";
            axWindowsMediaPlayer1.URL = crtDir + @"\marea_unire.mp4";
        }

        private void butt_exit_Click(object sender, EventArgs e)
        {
            Form mn = new main();
            mn.Show();
            this.Close();
        }

        private void butt_exit_MouseEnter(object sender, EventArgs e)
        {
            butt_exit.BackgroundImage = U100.Properties.Resources._2_buton_iesire;
        }

        private void butt_exit_MouseLeave(object sender, EventArgs e)
        {
            butt_exit.BackgroundImage = U100.Properties.Resources._3_buton_iesire;
        }
    }
}
