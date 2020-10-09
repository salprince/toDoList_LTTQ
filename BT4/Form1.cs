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
                this.login();
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.login();
        }
        private void loadToDoForm(String userName)
        {
            var myForm = new toDoListForm(this.textBoxUserName.Text);
            myForm.Show();
            toDoList myList = new toDoList();
            myList.import("toDoList.txt");
            String newData = "";
            for (int i = 0; i < myList.toDo.Count; i++)
            {
                if (myList.userName[i] == userName)
                    myForm.toDo.DataGridView.Rows.Add(myList.toDo[i], myList.checkBox[i]);
                else
                    newData += $"{myList.userName[i]},{myList.toDo[i]},{myList.checkBox[i]}\n";
            }
            myList.exportOverwrite("toDoList.txt", newData);
        }
        public void login()
        {
            LoginManage ql = new LoginManage();
            ql.list = ql.importData("Login.txt");
            String pass = ql.find(textBoxUserName.Text);
            if (textBoxPassword.Text.Trim().Equals(pass.Trim()))
            {
                loadToDoForm(textBoxUserName.Text);
            }
            else MessageBox.Show("Try Again");
        }
    }
}
