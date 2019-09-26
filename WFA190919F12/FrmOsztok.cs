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
    public partial class FrmOsztok : Form
    {
        public FrmOsztok()
        {
            InitializeComponent();
        }

        private void BtnOsztok_Click(object sender, EventArgs e)
        {
            lbOsztok.Items.Clear();
            lbOsztok.Items.Add(1);
            if (int.Parse(tbSzam.Text) != 1)
            {
                for (int i = 2; i <= int.Parse(tbSzam.Text) / 2; i++)
                {
                    if(int.Parse(tbSzam.Text) % i == 0)
                    {
                        lbOsztok.Items.Add(i);
                    }
                }
                lbOsztok.Items.Add(int.Parse(tbSzam.Text));
            }
        }
    }
}
