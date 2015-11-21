using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using DAL.Repository.Interfaces;

namespace DAL.Repository
{
    public class ProductRepository : BaseRepository<Product, int>, IProductRepository
    {
        public override IEnumerable<Product> GetAllEntities()
        {
            return DbContext.Products;
        }

        public override Product GetEntityById(int id)
        {
            throw new System.NotImplementedException();
        }

        public override int AddNewEntity(Product obj)
        {
            DbContext.Products.Add(obj);
            return DbContext.SaveChanges();
        }

        public override void UpdateEntity(Product obj)
        {
            throw new System.NotImplementedException();
        }

        public override void DeleteEntity(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Product> GetProductsByCatecoryId(int id)
        {
            return DbContext.Products.Where(o => o.CategoryId == id);
        }
    }
}
