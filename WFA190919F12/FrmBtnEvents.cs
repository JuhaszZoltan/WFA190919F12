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
    public partial class FrmBtnEvents : Form
    {
        static Random rnd = new Random();

        Color[] cols = { Color.Red, Color.Green, Color.Blue, Color.Yellow };

        Color frmColor;
        string frmText;
        string btnText;
        
        public FrmBtnEvents()
        {
            InitializeComponent();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            btn.Text = btn.Text.ToUpper();
        }

        private void Btn_MouseEnter(object sender, EventArgs e)
        {
            frmText = this.Text;
            frmColor = this.BackColor;
            btnText = btn.Text;

            this.BackColor = cols[rnd.Next(cols.Length)];
        }

        private void Btn_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = string.Format($"[x: {Cursor.Position.X} ; y: {Cursor.Position.Y}]");
        }

        private void Btn_MouseLeave(object sender, EventArgs e)
        {
            this.Text = frmText;
            this.BackColor = frmColor;
            btn.Text = btnText;
        }
    }
}
