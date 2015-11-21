namespace DAL.Mapping
{
    public interface IMapper
    {
        void Config();
        TDestination Map<TSource, TDestination>(TSource source);
        TDestination Map<TSource, TDestination>(TSource source, TDestination destination);
    }
}