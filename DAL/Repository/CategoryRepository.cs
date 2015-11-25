using System.Collections.Generic;
using System.Linq;
using DAL.Repository.Interfaces;

namespace DAL.Repository
{
    public class CategoryRepository : BaseRepository<Category, int>, ICategoryRepository
    {
        public override IEnumerable<Category> GetAllEntities()
        {
            return DbContext.Categories;
        }

        public override Category GetEntityById(int id)
        {
            return DbContext.Categories.FirstOrDefault(o => o.CategoryId == id);
        }

        public override int AddNewEntity(Category obj)
        {
            DbContext.Categories.Add(obj);
            return DbContext.SaveChanges();
        }

        public override void UpdateEntity(Category obj)
        {
            throw new System.NotImplementedException();
        }

        public override void DeleteEntity(int id)
        {
            var entity = GetEntityById(id);
            DbContext.Categories.Remove(entity);
            DbContext.SaveChanges();
        }
    }
}
