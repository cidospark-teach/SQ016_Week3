using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Todo.Data.Entities;
using Todo.Services.Interfaces;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MyTodo.UI
{
    public partial class ManageTask : Form
    {
        private readonly ITodoService todoService;
        private readonly HelperUtil helper;

        public ManageTask(ITodoService todoService)
        {
            InitializeComponent();

            this.todoService = todoService;
            helper = new HelperUtil(this.todoService);
        }

        private void btnUpdateTask_Click(object sender, EventArgs e)
        {
            var taskId = lblTaskId.Text;
            var taskDesc = lblTaskToManage.Text;

            var task = todoService.GetById(taskId);
            if (task == null)
                MessageBox.Show($"No user found with Id: {taskId}");
            
            task.Description = taskDesc;
            var result = todoService.Update(task);
            if (result != null)
            {
                helper.LoadData();
                this.Close();
            }
            else
                MessageBox.Show("Description update failed!");
        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            var taskId = lblTaskId.Text;

            var task = todoService.GetById(taskId);
            if (task == null)
                MessageBox.Show($"No user found with Id: {taskId}");

            var result = todoService.Delete(task);
            if (result)
            {
                helper.LoadData();
                this.Close();
            }
            else
                MessageBox.Show("Could not delete task!");
        }
    }
}
