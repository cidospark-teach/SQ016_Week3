using Microsoft.EntityFrameworkCore.ChangeTracking;
using Todo.Data;
using Todo.Data.Entities;
using Todo.Services.Interfaces;

namespace Todo.Services
{
    public class TodoService : ITodoService
    {
        private readonly TodoContext context;
        public TodoService(TodoContext context) {
            this.context = context;
        }

        public MyTask AddNew(MyTask enity)
        {
            if(enity == null)
                throw new ArgumentNullException(nameof(enity));

            context.Add(enity);
            var status = context.SaveChanges();
            if (status > 0)
                return enity;

            return null;
        }

        public bool Delete(MyTask enity)
        {
            if (enity == null)
                throw new ArgumentNullException(nameof(enity));

            context.Remove(enity);
            var status = context.SaveChanges();
            if (status > 0)
                return true;

            return false;
        }
        public bool Delete(MyTask[] enities)
        {
            if (enities.Length < 1)
                throw new ArgumentNullException(nameof(enities));

            context.RemoveRange(enities);
            var status = context.SaveChanges();
            if (status > 0)
                return true;

            return false;
        }

        public IEnumerable<MyTask> GetAll()
        {
            return context.MyTasks.ToList();
        }

        public MyTask GetById(string Id)
        {
            return context.MyTasks.FirstOrDefault(x => x.Id == Id);
        }

        public MyTask Update(MyTask enity)
        {
            if (enity == null)
                throw new ArgumentNullException(nameof(enity));

            context.Update(enity);
            var status = context.SaveChanges();
            if (status > 0)
                return enity;

            return null;
        }
    }
}