using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BO;
using Entity;

namespace UI_Desktop
{
    public partial class SearchInfo : Form
    {
        BoAccount ba = new BoAccount();
        Account[] a;
        int index;
        public SearchInfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool show = false;
            a = ba.getinfo();
            for (int i = 0; ; i++)
            {
                if (a[i] == null)
                    break;
                if (textBox1.Text == a[i].AccountNo)
                {
                    index = i;
                    show = true;
                    break;
                }
                else
                    show = false;
            }
            if (show)
            {
                shacno.Text = a[index].AccountNo;
                shusnm.Text = a[index].UserName;
                shbl.Text = a[index].Balance.ToString();
                shad.Text = a[index].Address;
                shcn.Text = a[index].ContactNo;
            }
            else
            {
                shacno.Text = "None";
                shusnm.Text = "None";
                shbl.Text = "None";
                shad.Text = "None";
                shcn.Text = "None";
            }
        }
    }
}
