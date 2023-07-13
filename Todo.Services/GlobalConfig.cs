using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Data;
using Todo.Services.Interfaces;

namespace Todo.Services
{
    public static class GlobalConfig
    {
        public static ITodoService TodoService { get; private set; }
        public static void Instantiate()
        {
            var context = new TodoContext();
            TodoService = new TodoService(context);
        }
    }
}
