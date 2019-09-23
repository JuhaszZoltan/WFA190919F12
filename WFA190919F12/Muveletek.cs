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
    public partial class FrmMuveletek : Form
    {
        public FrmMuveletek()
        {
            InitializeComponent();
            foreach (var btn in this.Controls)
            {
                if(btn is Button) (btn as Button).Click += ButtonClick;
            }
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            if ((sender as Button).Text == "Törlés")
            {
                foreach (var tb in this.Controls)
                    if (tb is TextBox) (tb as TextBox).Clear();
            }
            else if (tbA.Text == "" || tbB.Text == "")
            {
                MessageBox.Show("Előbb töltsd ki a mezőket!");
            }
            else if (!int.TryParse(tbA.Text, out _) || !int.TryParse(tbA.Text, out _))
            {
                MessageBox.Show("Nem szám");
            }
            else
            {
                switch ((sender as Button).Text)
                {
                    case "+":
                        tbE.Text = int.Parse(tbA.Text) + int.Parse(tbB.Text) + "";
                        return;
                    case "-":
                        tbE.Text = int.Parse(tbA.Text) - int.Parse(tbB.Text) + "";
                        return;
                    case "*":
                        tbE.Text = int.Parse(tbA.Text) * int.Parse(tbB.Text) + "";
                        return;
                    case "/":
                        tbE.Text = string.Format("{0:0.00}",
                            int.Parse(tbA.Text) / float.Parse(tbB.Text));
                        return;
                }
            }

        }
    }
}
