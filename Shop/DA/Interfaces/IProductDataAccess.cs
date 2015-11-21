using System.Collections.Generic;
using DAL;
using Shop.Models;

namespace Shop.DA.Interfaces
{
    public interface IProductDataAccess : IDataAccess<ProductModel, int>
    {
        IEnumerable<ProductModel> GetProductsByCategoryId(int id);
    }
}