using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U100
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void button_teste_Click(object sender, EventArgs e)
        {
            Form pt = new testare();
            pt.Activate();
            pt.Show();
            this.Hide();
        }

        private void button_teorie_Click(object sender, EventArgs e)
        {
            Form inv = new teorie();
            inv.Activate();
            inv.Show();
            this.Hide();
        }

        private void main_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Width = this.BackgroundImage.Width;
            this.Height = this.BackgroundImage.Height;

            this.Region = RegiuneMain.descoperaRegiunea((Bitmap)this.BackgroundImage, Color.FromArgb(0, 255, 0), 100);
        }

        private void button_video_Click(object sender, EventArgs e)
        {
            Form vid = new video();
            vid.Activate();
            vid.Show();
            this.Hide();
        }

        private void button_invatare_MouseHover(object sender, EventArgs e)
        {

        }

        private void button_iesire_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Se misca forma cand tragem cu mouse-ul de ea
        Point punct;
        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            punct = new Point(e.X, e.Y);
        }

        private void Main_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - punct.X;
                this.Top += e.Y - punct.Y;
            }
        }

        private void button_iesire_MouseHover(object sender, EventArgs e)
        {
            button_iesire.BackgroundImage = U100.Properties.Resources.buton_exit_pressed;
        }

        private void button_iesire_MouseEnter(object sender, EventArgs e)
        {
            button_iesire.BackgroundImage = U100.Properties.Resources.buton_exit_pressed;
        }

        private void button_iesire_MouseLeave(object sender, EventArgs e)
        {
            button_iesire.BackgroundImage = U100.Properties.Resources.buton_exit2;
        }

        private void button_teorie_MouseEnter(object sender, EventArgs e)
        {
            button_teorie.BackgroundImage = U100.Properties.Resources._02_buton_teorie;
        }

        private void button_teorie_MouseLeave(object sender, EventArgs e)
        {
            button_teorie.BackgroundImage = U100.Properties.Resources._01_buton_teorie;
        }

        private void button_video_MouseEnter(object sender, EventArgs e)
        {
            button_video.BackgroundImage = U100.Properties.Resources._02_buton_videoclipuri;
        }

        private void button_video_MouseLeave(object sender, EventArgs e)
        {
            button_video.BackgroundImage = U100.Properties.Resources._01_buton_videoclipuri;
        }

        private void button_teste_MouseEnter(object sender, EventArgs e)
        {
            button_teste.BackgroundImage = U100.Properties.Resources._02_buton_teste;
        }

        private void button_teste_MouseLeave(object sender, EventArgs e)
        {
            button_teste.BackgroundImage = U100.Properties.Resources._01_buton_teste;
        }
    }
}
