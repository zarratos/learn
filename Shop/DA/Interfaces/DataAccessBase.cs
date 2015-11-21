using Shop.Mapping;

namespace Shop.DA.Interfaces
{
    public abstract class DataAccessBase
    {
        protected readonly DtoMapper Mapper;
        protected DataAccessBase(DtoMapper mapper)
        {
            Mapper = mapper;
        }
    }
}