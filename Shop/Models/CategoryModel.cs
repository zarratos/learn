using System.Collections.Generic;
using System.Web.Mvc;

namespace Shop.Models
{
    public class CategoryModel
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int? ParentCategoryId { get; set; }
        public IEnumerable<SelectListItem> CategoryList { get; set; }
    }
}