using System.Collections.Generic;
using System.Linq;
using GTDGo.Repository;

namespace GTDGo.Service.Service
{
    public class CrudService<TEntity, TModel>
    {
        private readonly IBaseRepository<TEntity> baseRepository;
        private readonly IEntityMapper mapper;

        public CrudService(IBaseRepository<TEntity> baseRepository, IEntityMapper mapper)
        {
            this.baseRepository = baseRepository;
            this.mapper = mapper;
        }

        public IList<TModel> GetList()
        {
            return baseRepository
                .GetAll()
                .Select(element => mapper.Map<TModel>(element))
                .ToList();
        }
    }
}