using System.Collections.Generic;
using System.Web.Mvc;
using Shop.Models;

namespace Shop.ViewModels
{
    public class AddCategoryViewModel
    {
        public CategoryModel Category { get; set; }
        public IEnumerable<CategoryModel> Categories { get; set; }
        public IEnumerable<SelectListItem> CategoriesList { get; set; }
    }
}