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
    public partial class FrmKocskadobasok : Form
    {
        static Random rnd = new Random();
        public FrmKocskadobasok()
        {
            InitializeComponent();
        }

        private void BtnDobas_Click(object sender, EventArgs e)
        {
            rtbDobasok.Clear();
            for (int i = 0; i < int.Parse(tbDb.Text); i++)
            {
                rtbDobasok.Text += rnd.Next(1, 7) + " ";
            }

            for (int i = 0; i < rtbDobasok.Text.Length; i++)
            {
                rtbDobasok.SelectionStart = i;
                rtbDobasok.SelectionLength = 1;
                if (rtbDobasok.Text[i] == '1')
                    rtbDobasok.SelectionColor = Color.Red;
                if (rtbDobasok.Text[i] == '6')
                    rtbDobasok.SelectionColor = Color.Green;
            }
        }
    }
}
