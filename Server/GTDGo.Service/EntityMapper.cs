using AutoMapper;

namespace GTDGo.Service
{
    public class EntityMapper : IEntityMapper
    {
        private readonly IMapper mapper;

        public EntityMapper(IMapper mapper)
        {
            this.mapper = mapper;
        }

        public TOut Map<TIn, TOut>(TIn input)
        {
            return mapper.Map<TOut>(input);
        }

        public TOut Map<TOut>(object input)
        {
            return mapper.Map<TOut>(input);
        }
    }
}