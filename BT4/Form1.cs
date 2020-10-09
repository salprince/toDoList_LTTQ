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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            textBoxUserName.Text = "";
            textBoxPassword.Text = "";
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            var myForm = new Form2(this);
            myForm.Show();
            this.Hide();
        }

        private void textBoxUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.textBoxPassword.Focus();
            }
        }

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                LoginManage ql = new LoginManage();
                ql.list = ql.importData("D:\\LTTQ\\BT4\\BT4\\Login.txt");
                String pass = ql.find(textBoxUserName.Text);
                if (textBoxPassword.Text.Trim().Equals(pass.Trim()))
                {
                    MessageBox.Show("Login Success");
                    var myForm = new toDoListForm(this.textBoxUserName.Text);
                    myForm.Show();
                }
                else MessageBox.Show("Try Again");
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            LoginManage ql = new LoginManage();
            ql.list = ql.importData("D:\\LTTQ\\BT4\\BT4\\Login.txt");
            String pass = ql.find(textBoxUserName.Text);
            loadToDoForm(textBoxUserName.Text);
            /*if (textBoxPassword.Text.Trim().Equals(pass.Trim()))
            {
                //MessageBox.Show("Login Success");
                loadToDoForm();
            }
            else MessageBox.Show("Try Again");*/
        }
        private void loadToDoForm(String userName)
        {
            var myForm = new toDoListForm(this.textBoxUserName.Text);
            myForm.Show();
            toDoList myList = new toDoList();
            myList.import("D:\\LTTQ\\BT4\\toDoList.txt");
            for (int i = 0; i < myList.toDo.Count; i++)
                if(myList.userName[i] == userName)
                    myForm.toDo.DataGridView.Rows.Add(myList.toDo[i], myList.checkBox[i]);
        }
    }
}
