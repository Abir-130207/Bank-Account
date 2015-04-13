using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using BO;
using Entity;

namespace UI_Desktop
{
    public partial class Update : Form
    {
        BoAccount kk = new BoAccount();
        Account[] ac;
        int index = 0;
        double diposit;
        public Update()
        {
            InitializeComponent();
            t_diposit.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ac = kk.getinfo();
            bool isShow = false;

            for (int i = 0; ; i++)
            {
                if (ac[i] == null)
                    break;
                if (textBox1.Text == ac[i].AccountNo)
                {
                    index = i;
                    isShow = true;
                    break;
                }
                else
                    isShow = false;
            }

            if (isShow)
            {
                textBox2.Text = ac[index].AccountNo;
                textBox3.Text = ac[index].UserName;
                textBox4.Text = ac[index].Balance.ToString();
                textBox5.Text = ac[index].Address;
                textBox6.Text = ac[index].ContactNo;
            }
            else
            {
                textBox2.Text = "None";
                textBox3.Text = "None";
                textBox4.Text = "None";
                textBox5.Text = "None";
                textBox6.Text = "None";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double newbalance = Convert.ToDouble(textBox4.Text) + diposit;
            ac[index].AccountNo = textBox2.Text;
            ac[index].UserName = textBox3.Text;
            ac[index].Balance = newbalance;
            ac[index].Address = textBox5.Text;
            ac[index].ContactNo = textBox6.Text;

            bool test = kk.update(ac);
            if (test)
                MessageBox.Show("Successfull");
            else
                MessageBox.Show("Error");

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Update_Load(object sender, EventArgs e)
        {

        }
    }
}
