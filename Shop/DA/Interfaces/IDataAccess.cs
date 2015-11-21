using System.Collections.Generic;

namespace Shop.DA.Interfaces
{
    public interface IDataAccess <TEntity, TKeyType>
    {
        IEnumerable<TEntity> GetAllEntities();
        TEntity GetEntityById(TKeyType id);
        int AddNewEntity(TEntity obj);
        void UpdateEntity(TEntity obj);
        void DeleteEntity(TKeyType id);
    }
}