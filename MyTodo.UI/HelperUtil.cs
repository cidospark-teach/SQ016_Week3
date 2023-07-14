using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Todo.Services;
using Todo.Services.Interfaces;

namespace MyTodo.UI
{
    public class HelperUtil
    {
        private readonly ITodoService todoService;
        public HelperUtil(ITodoService todoService)
        {
            this.todoService= todoService;
        }

        public void LoadData()
        {
            var list = todoService.GetAll();

            var table = new DataTable();
            table.Columns.Add("Id");
            table.Columns.Add("Description");
            table.Columns.Add("Status");

            int counter = 0;
            if (list.Count() > 0)
            {
                foreach (var listItem in list)
                {
                    table.Rows.Add(listItem.Id, listItem.Description, listItem.status);
                    counter++;
                }

                Form1.dataGridView1.DataSource = table;
            }
            else
            {
                MessageBox.Show("No records found!");
            }
            Form1.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
