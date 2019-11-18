namespace GTDGo.Service
{
    public interface IEntityMapper
    {
        TOut Map<TIn, TOut>(TIn input);
        TOut Map<TOut>(object input);
    }
}