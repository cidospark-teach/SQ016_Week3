using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Todo.Data.Entities;

namespace Todo.Services.Interfaces
{
    public interface ITodoService
    {
        MyTask AddNew(MyTask enity);
        MyTask Update(MyTask enity);
        bool Delete(MyTask enity);
        public bool Delete(MyTask[] enities);
        MyTask GetById(string Id);
        IEnumerable<MyTask> GetAll();

    }
}
