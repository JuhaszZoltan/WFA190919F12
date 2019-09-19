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
    public partial class FrmMain : Form
    {
        #region form referencia
        List<Form> referencia = new List<Form>
        {
            new FrmHelloWorld(), //0
            new FrmBtnEvents(), //1
            new FrmColorz(), //2
            new FrmTextFormat(), //3
            null, //4
            null, //5
            null, //6
            null, //7
            null, //8
            null, //9
            null, //10
            null, //11
            null, //12
            null, //13
            null, //14
        };
        #endregion
        public FrmMain()
        {
            InitializeComponent();
            foreach (var btn in this.Controls)
            {

                if (btn is Button)
                {
                    (btn as Button).BackColor = Color.LightBlue;
                    (btn as Button).Click += ButtonClick;
                }
            }
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Red;
            var frm = referencia[(sender as Button).TabIndex];
            frm.ShowDialog();
            (sender as Button).BackColor = Color.LightBlue;
        }
    }
}
