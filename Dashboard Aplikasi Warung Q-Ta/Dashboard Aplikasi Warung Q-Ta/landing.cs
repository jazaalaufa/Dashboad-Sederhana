using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard_Aplikasi_Warung_Q_Ta
{
    public partial class landing : Form
    {
        public landing()
        {
            InitializeComponent();
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            regis reg = new regis();
            reg.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            login log = new login();
            log.Show();
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            das dash = new das();
            dash.Show();
            this.Hide();
        }
    }
}
