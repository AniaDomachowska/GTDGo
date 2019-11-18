using GTDGo.Repository.Model;
using Microsoft.EntityFrameworkCore;

namespace GTDGo.Repository
{
    public class TasksDbContext : DbContext
    {
        public TasksDbContext(DbContextOptions options) : base(options)
        {
        }
            
        public DbSet<Task> Task { get; set; }
        public DbSet<TaskContext> TaskContext { get; set; }
    }
}