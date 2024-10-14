using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace m5_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

              
       
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            string task = txtTask.Text.Trim();
            if (!string.IsNullOrEmpty(task))
            {
                lstTasks.Items.Add(task);
                txtTask.Clear();
            }
            else
            {
                MessageBox.Show("Введите задачу.");
            }
        }

        private void btnRemove_Click_1(object sender, EventArgs e)
        {
            if (lstTasks.SelectedItem != null)
            {
                lstTasks.Items.Remove(lstTasks.SelectedItem);
            }
            else
            {
                MessageBox.Show("Выберите задачу для удаления.");
            }
        }

        private void btnComplete_Click_1(object sender, EventArgs e)
        {
            if (lstTasks.SelectedItem != null)
            {
                lstTasks.Items[lstTasks.SelectedIndex] += " (Выполнено)";
            }
            else
            {
                MessageBox.Show("Выберите задачу для отметки как выполненную.");
            }
        }
    }
}
