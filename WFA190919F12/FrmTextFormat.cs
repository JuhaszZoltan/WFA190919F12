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
    public partial class FrmTextFormat : Form
    {
        Color lblForeC;
        Color lblBackC;
        Font lblFont;
        ContentAlignment lblAligne;
        string lblText;
        public FrmTextFormat()
        {
            InitializeComponent();
            lblForeC = lblSzoveg.ForeColor;
            lblBackC = lblSzoveg.BackColor;
            lblText = lblSzoveg.Text;
            lblFont = lblSzoveg.Font;
            lblAligne = lblSzoveg.TextAlign;
        }

        private void BtnAlap_Click(object sender, EventArgs e)
        {
            lblSzoveg.ForeColor = lblForeC;
            lblSzoveg.BackColor = lblBackC;
            lblSzoveg.Text = lblText;
            lblSzoveg.TextAlign = lblAligne;
            lblSzoveg.Font = lblFont;
        }

        private void BtnKek_Click(object sender, EventArgs e)
        {
            lblSzoveg.ForeColor = Color.Blue;
        }

        private void BtnFeher_Click(object sender, EventArgs e)
        {
            lblSzoveg.BackColor = Color.White;
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            lblSzoveg.Text = "";
        }

        private void BtnBK_Click(object sender, EventArgs e)
        {
            lblSzoveg.TextAlign = ContentAlignment.MiddleLeft;
        }

        private void BtnKK_Click(object sender, EventArgs e)
        {
            lblSzoveg.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void BtnJK_Click(object sender, EventArgs e)
        {
            lblSzoveg.TextAlign = ContentAlignment.MiddleRight;
        }

        private void BtnCsN_Click(object sender, EventArgs e)
        {
            lblSzoveg.Text = lblSzoveg.Text.ToUpper();
        }

        private void BtnNagyit_Click(object sender, EventArgs e)
        {
            lblSzoveg.Font = new Font(lblSzoveg.Font.FontFamily, lblSzoveg.Font.Size + 2);
        }

        private void BtnKicsinyit_Click(object sender, EventArgs e)
        {
            if(lblSzoveg.Font.Size > 2)
                lblSzoveg.Font = new Font(lblSzoveg.Font.FontFamily, lblSzoveg.Font.Size - 2);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
