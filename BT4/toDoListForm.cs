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
    public partial class toDoListForm : Form
    {
        public String userName { get; set; }
        public toDoListForm(String userName)
        {
            this.userName = userName;
            InitializeComponent();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            String data = "";
            
            for (int rows = 0; rows < this.toDo.DataGridView.Rows.Count-1; rows++)
            {
                data += $"{this.userName},";
                for (int col = 0; col < this.toDo.DataGridView.Rows[rows].Cells.Count-1; col++)
                {
                    if(this.toDo.DataGridView.Rows[rows].Cells[col].Value!= null)
                        data+= this.toDo.DataGridView.Rows[rows].Cells[col].Value.ToString() +",";
                }
                if (this.toDo.DataGridView.Rows[rows].Cells[this.toDo.DataGridView.Rows[rows].Cells.Count - 1].Value != null)
                    data += this.toDo.DataGridView.Rows[rows].Cells[this.toDo.DataGridView.Rows[rows].Cells.Count - 1].Value.ToString() + "\n";
                else data += "False\n";
            }
            
            toDoList myList = new toDoList();
            myList.export("D:\\LTTQ\\BT4\\toDoList.txt",data);
            MessageBox.Show("Saved!");
        }
    }
}
