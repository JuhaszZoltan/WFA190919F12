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
    public partial class FrmColorz : Form
    {
        Color frmColor;
        public FrmColorz()
        {
            InitializeComponent();
            foreach (var pb in this.Controls)
            {
                if(pb is PictureBox) (pb as PictureBox).Click += PbClick;
            }
            frmColor = this.BackColor;
        }

        private void PbClick(object sender, EventArgs e)
        {
            this.BackColor = (sender as PictureBox).BackColor;
        }

        private void BtnAlap_Click(object sender, EventArgs e)
        {
            this.BackColor = frmColor;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmColorz_BackColorChanged(object sender, EventArgs e)
        {
            if(this.BackColor == frmColor || this.BackColor == Color.Yellow)
            {
                lblSzoveg.ForeColor = Color.Black;
            }
            else
            {
                lblSzoveg.ForeColor = Color.White;
            }
        }
    }
}
