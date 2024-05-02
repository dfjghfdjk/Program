using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace тест2
{
    public partial class Form1 : Form
    {
        private List<string> tasks = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            string newTask = txtTask.Text.Trim();
            if (!string.IsNullOrEmpty(newTask))
            {
                int selectedIndex = lstTasks.SelectedIndex;
                if (selectedIndex != -1)
                {
                    tasks[selectedIndex] = newTask;
                    lstTasks.Items[selectedIndex] = newTask;
                }
                else
                {
                    tasks.Add(newTask);
                    lstTasks.Items.Add(newTask);
                }
                txtTask.Clear();
                lstTasks.ClearSelected();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedIndex != -1)
            {
                int selectedIndex = lstTasks.SelectedIndex;
                tasks.RemoveAt(selectedIndex);
                lstTasks.Items.RemoveAt(selectedIndex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tasks.Clear();
            lstTasks.Items.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedIndex != -1)
            {
                string selectedTask = lstTasks.SelectedItem.ToString();
                txtTask.Text = selectedTask;
            }
        }
    }
}
