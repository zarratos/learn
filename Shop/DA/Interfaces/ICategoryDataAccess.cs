using System.Collections.Generic;
using Shop.Models;

namespace Shop.DA.Interfaces
{
    public interface ICategoryDataAccess : IDataAccess<CategoryModel, int>
    {
        IEnumerable<CategoryModel> GetCategoriesByParentId(int id);
        bool IsParentCategory(CategoryModel obj);
        CategoryModel GetCategoryById(int id);
    }
}