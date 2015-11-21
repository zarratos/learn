using System.Collections.Generic;

namespace DAL.Repository.Interfaces
{
    public interface IRepository<TEntity, TKeyType>
    {
        IEnumerable<TEntity> GetAllEntities();
        TEntity GetEntityById(TKeyType id);
        int AddNewEntity(TEntity obj);
        void UpdateEntity(TEntity obj);
        void DeleteEntity(TKeyType id);
    }
}
