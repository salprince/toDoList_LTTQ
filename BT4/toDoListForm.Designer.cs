﻿namespace BT4
{
    partial class toDoListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>

        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btDelete = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.toDo,
            this.checkBox});
            this.dataGridView1.Location = new System.Drawing.Point(2, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(830, 353);
            this.dataGridView1.TabIndex = 0;
            // 
            // toDo
            // 
            this.toDo.HeaderText = "                                                    toDoList";
            this.toDo.MinimumWidth = 6;
            this.toDo.Name = "toDo";
            this.toDo.Width = 500;
            // 
            // checkBox
            // 
            this.checkBox.HeaderText = "";
            this.checkBox.MinimumWidth = 6;
            this.checkBox.Name = "checkBox";
            this.checkBox.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.checkBox.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.checkBox.Width = 75;
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btDelete.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.Location = new System.Drawing.Point(2, 10);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(110, 40);
            this.btDelete.TabIndex = 1;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btSave.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.Location = new System.Drawing.Point(132, 10);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(213, 40);
            this.btSave.TabIndex = 3;
            this.btSave.Text = "Save and Exit";
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.Save_Click);
            // 
            // toDoListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(844, 479);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.dataGridView1);
            this.Name = "toDoListForm";
            this.Text = "toDoListForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Button btDelete;
        public System.Windows.Forms.Button btSave;
        public System.Windows.Forms.DataGridViewTextBoxColumn toDo;
        public System.Windows.Forms.DataGridViewCheckBoxColumn checkBox;
    }
}