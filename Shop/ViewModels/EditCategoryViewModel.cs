using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Shop.Models;

namespace Shop.ViewModels
{
    public class EditCategoryViewModel
    {
        public int ParentCategoryId { get; set; }
        public IEnumerable<CategoryModel> Categories { get; set; }
        public IEnumerable<SelectListItem> CategoriesList { get; set; }
    }
}