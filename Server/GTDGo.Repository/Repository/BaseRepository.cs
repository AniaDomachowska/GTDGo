using System.Linq;
using GTDGo.Repository.Model;

namespace GTDGo.Repository.Repository
{
    public class BaseRepository : IBaseRepository<Task>
    {
        private readonly TasksDbContext taskContext;

        public BaseRepository(TasksDbContext taskContext)
        {
            this.taskContext = taskContext;
        }

        public IQueryable<Task> GetAll()
        {
            return taskContext.Task.AsQueryable();
        }
    }
}