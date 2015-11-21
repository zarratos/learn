using System.Collections.Generic;
using DAL.Repository.Interfaces;


namespace DAL.Repository
{
    public abstract class BaseRepository<TTableType, TKeyType> : IRepository<TTableType, TKeyType> where TTableType : class
    {
        protected readonly ShopContext DbContext;

        protected BaseRepository()
        {
            DbContext = new ShopContext();
        }

        public abstract IEnumerable<TTableType> GetAllEntities();

        public abstract TTableType GetEntityById(TKeyType id);

        public abstract int AddNewEntity(TTableType obj);

        public abstract void UpdateEntity(TTableType obj);

        public abstract void DeleteEntity(TKeyType id);
    }
}
