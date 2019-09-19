using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA190919F12
{
    public partial class FrmHelloWorld : Form
    {
        public FrmHelloWorld()
        {
            InitializeComponent();
        }

        private void BtnHW_Click(object sender, EventArgs e)
        {
            this.Text = "Hello World!";
            lblHW.Text = "";
        }

        private void BtnFrm_Click(object sender, EventArgs e)
        {
            lblHW.Text = "Hello World!";
            this.Text = "-- EZ ITT A CÍMSOR --";
        }

        private void BtnMB_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World!");
            lblHW.Text = "";
            this.Text = "-- EZ ITT A CÍMSOR --";
        }
    }
}
