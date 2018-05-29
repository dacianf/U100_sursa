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
    public partial class player_teste : Form
    {
        public player_teste()
        {
            InitializeComponent();
        }

        private void label_max_scor_Click(object sender, EventArgs e)
        {

        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_incepe_Click(object sender, EventArgs e)
        {
            Form tf = new testare();
            tf.Activate();
            tf.Show();
            
            this.Close();
        }
    }
}
