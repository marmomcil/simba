using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace simba
{
    public partial class frmDobrodosli : Form
    {
        public frmDobrodosli()
        {
            InitializeComponent();
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            progressBar1.Maximum = 3;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value != 3)
            {
                progressBar1.Value++;
            }
            else
            {
                timer1.Stop();
                this.Hide();
                frmGlavniIzbornik gui = new frmGlavniIzbornik();
                gui.Show();
            }
        }
    }
}
