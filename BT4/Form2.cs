using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT4
{
    public partial class Form2 : Form
    {
        public Form parent;
        public Form2(Form parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        private void labelLogin_Click(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            textBoxPassword.Text = "";
            textBoxUserName.Text = "";
            textBoxRePass.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            parent.Show();

            this.Hide();
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelPassword_Click(object sender, EventArgs e)
        {

        }
        private void textBoxUserName_TextChanged(object sender, EventArgs e)
        {

        }
        private void labelUserName_Click(object sender, EventArgs e)
        {

        }
        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.textBoxRePass.Focus();
            }
        }
        private void textBoxRePass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (this.textBoxPassword.Text == this.textBoxRePass.Text)
                {
                    LoginManage ql = new LoginManage();
                    ql.list = ql.importData("D:\\LTTQ\\BT4\\BT4\\Login.txt");
                    String pass = ql.find(textBoxUserName.Text);
                    if (pass == "***")
                        ql.list.Add(new Login(textBoxUserName.Text, textBoxPassword.Text));
                    ql.exportData("D:\\LTTQ\\BT4\\BT4\\Login.txt");

                }
            }
        }

        private void textBoxUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.textBoxPassword.Focus();
            }
        }
    }
}
