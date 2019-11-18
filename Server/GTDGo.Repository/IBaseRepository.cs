using System.Linq;

namespace GTDGo.Repository
{
    public interface IBaseRepository<out TEntity>
    {
        IQueryable<TEntity> GetAll();
    }
}