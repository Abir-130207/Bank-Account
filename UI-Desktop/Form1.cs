using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using BO;
using Entity;
using System.Threading;

namespace UI_Desktop
{
    public partial class Form1 : Form
    {
        BoAccount kk = new BoAccount();
        Account A;
        List<Account> accountList = new List<Account>();
        int d;
        public Form1()
        {
            InitializeComponent();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            A = new Account();
            A.AccountNo = textBox1.Text;
            A.UserName = textBox2.Text;
            A.Balance = Convert.ToDouble(textBox3.Text);
            A.Address = textBox4.Text;
            A.ContactNo = textBox5.Text;

            bool isMessage = kk.Information(A);

            if (isMessage)
            {
                MessageBox.Show("Saved Successfully", "Message");
            }
            else
            {
                MessageBox.Show("Error", "Error Mmessage");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SearchInfo sf = new SearchInfo();
            sf.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Update u = new Update();
            u.Show();
        }
    }
}
