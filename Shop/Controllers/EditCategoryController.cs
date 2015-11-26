using System.Linq;
using System.Web.Mvc;
using DAL.Repository;
using Shop.DA;
using Shop.DA.Interfaces;
using Shop.Mapping;
using Shop.Models;
using Shop.ViewModels;

namespace Shop.Controllers
{
    public class EditCategoryController : Controller
    {
        //
        // GET: /EditCategory/

        private readonly ICategoryDataAccess _dataAccess;
        public EditCategoryController()
        {
            _dataAccess = new CategoryDataAccess(new DtoMapper(), new CategoryRepository());
        }
        
        public ActionResult Index(int categoryId)
        {
            var model = MakeCategoryList();
            return View(model);
        }

        private EditCategoryViewModel MakeCategoryList()
        {
            var model = new EditCategoryViewModel();
            model.CategoriesList =
                _dataAccess.GetAllEntities()
                    .Select(cat => new SelectListItem { Text = cat.CategoryName, Value = cat.CategoryId.ToString() });
            model.Categories = _dataAccess.GetAllEntities();
            return model;
        }

        public ActionResult UpdateCategory(int categoryid, string categoryname, int? categoryparentid)
        {
            throw new System.NotImplementedException();
        }

        public ActionResult DeleteCategory(int categoryid)
        {
            throw new System.NotImplementedException();
        }
    }
}
