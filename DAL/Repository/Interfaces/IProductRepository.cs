using System.Collections.Generic;

namespace DAL.Repository.Interfaces
{
    public interface IProductRepository : IRepository<Product, int>
    {
        IEnumerable<Product> GetProductsByCatecoryId(int id);
    }
}
