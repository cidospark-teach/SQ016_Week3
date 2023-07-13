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
        public ManageTask(ITodoService todoService)
        {
            InitializeComponent();

            this.todoService = todoService;
        }

        private void btnUpdateTask_Click(object sender, EventArgs e)
        {
            var taskId = lblTaskId.Text;
            var taskDesc = lblTaskToManage.Text;

            var task = new MyTask
            {
                Id = taskId,
                Description = taskDesc,
                //status = status
            };

            var result = todoService.Update(task);
            if (result != null)
            {
                this.Close();
            }
            else
                MessageBox.Show("Description update failed!");
        }
    }
}
