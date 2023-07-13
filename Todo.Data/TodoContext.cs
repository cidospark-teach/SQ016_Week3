using Microsoft.EntityFrameworkCore;
using Todo.Data.Entities;

namespace Todo.Data
{
    public class TodoContext: DbContext
    {
        public DbSet<MyTask> MyTasks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-6LH1A8U;Initial Catalog=Todo; Integrated Security=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<MyTask>().HasKey(t => t.Id);
        }
    }
}