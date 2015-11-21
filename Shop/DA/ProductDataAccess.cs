using System.Collections.Generic;
using DAL;
using DAL.Repository.Interfaces;
using Shop.DA.Interfaces;
using Shop.Mapping;
using Shop.Models;

namespace Shop.DA
{
    public class ProductDataAccess : DataAccessBase, IProductDataAccess
    {
        private readonly IProductRepository _repository;

        public ProductDataAccess(DtoMapper mapper, IProductRepository repository)
            : base(mapper)
        {
            _repository = repository;
        }

        public IEnumerable<ProductModel> GetAllEntities()
        {
            var resultList = Mapper.Map<IEnumerable<Product>, IEnumerable<ProductModel>>(_repository.GetAllEntities());
            return resultList;
        }

        public ProductModel GetEntityById(int id)
        {
            throw new System.NotImplementedException();
        }

        public int AddNewEntity(ProductModel obj)
        {
            var product = Mapper.Map<ProductModel, Product>(obj);
            return _repository.AddNewEntity(product);
        }

        public void UpdateEntity(ProductModel obj)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteEntity(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<ProductModel> GetProductsByCategoryId(int id)
        {
            var resultList = Mapper.Map<IEnumerable<Product>, IEnumerable<ProductModel>>(_repository.GetProductsByCatecoryId(id));
            return resultList;
        }
    }
}