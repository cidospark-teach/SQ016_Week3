using System.Data;
using Todo.Data.Entities;
using Todo.Services.Interfaces;

namespace MyTodo.UI
{
    public partial class Form1 : Form
    {
        private readonly ITodoService todoService;
        private  ManageTask manageTask;
        private readonly HelperUtil helper;
        public Form1(ITodoService todoService, ManageTask manageForm)
        {
            InitializeComponent();
            this.todoService = todoService;
            this.manageTask = manageForm;
            helper = new HelperUtil(this.todoService);
            helper.LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var todoDesc = textBox1.Text;
            var status = checkBox1.Checked;

            if (!string.IsNullOrEmpty(todoDesc))
            {
                var task = new MyTask
                {
                    Description = todoDesc,
                    status = status
                };

                var result = todoService.AddNew(task);
                if (result != null)
                {
                    helper.LoadData();
                }
                else
                    MessageBox.Show("Description not failed to add!");
            }
            else
            {
                MessageBox.Show("Description not provided!");
            }

        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            if (selectedRow != null)
            {
                if (!manageTask.Created)
                    manageTask = new ManageTask(todoService);
                manageTask.Show();
                manageTask.lblTaskId.Text = selectedRow.Cells[0].Value.ToString();
                manageTask.lblTaskToManage.Text = selectedRow.Cells[0].Value.ToString();
            }
            else
            {
                MessageBox.Show("Selection returned null!");
            }
        }
    }
}