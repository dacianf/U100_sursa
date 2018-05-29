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
using System.Diagnostics;

namespace U100
{
    public partial class teorie : Form
    {
        public string crtDir = Directory.GetCurrentDirectory().ToString() + @"\informatii_unire";//memorez in "crtDir" locația directorului curent
        public string[] uniri = new string[]//creez un vector de stringuri cu locația și denumirea fișierelor pentru teorie
                {
                   @"\u1551.html",
                   @"\u1595.html",
                   @"\u1600.html",
                   @"\u1848.html",
                   @"\u1918.html"
                };
        public teorie()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            //când se mișcă săgeata de pe bară încarc în browser pagina
            //cu teoria corespunzătoare anului aflat sub săgeată
            webBrowser1.Url = new Uri(crtDir + uniri[trackBar1.Value-1]);      
        }

        private void label_1848_Click(object sender, EventArgs e)
        {

        }

        private void teorie_Load(object sender, EventArgs e)
        {
            crtDir = Directory.GetCurrentDirectory().ToString() + @"\informatii_unire";
            webBrowser1.Url = new Uri(crtDir + uniri[trackBar1.Value - 1]);
        }

        private void butt_exit_Click(object sender, EventArgs e)
        {
            Form mn = new main();
            mn.Show();
            this.Close();
        }

        private void butt_exit_MouseEnter(object sender, EventArgs e)
        {
            butt_exit.BackgroundImage = U100.Properties.Resources._3_X_iesire;
        }

        private void butt_exit_MouseLeave(object sender, EventArgs e)
        {
            butt_exit.BackgroundImage = U100.Properties.Resources._1_X_iesire;
        }

    }
}
