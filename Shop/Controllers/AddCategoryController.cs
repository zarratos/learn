using System.Collections.Generic;
using System.Drawing.Printing;
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
    public class AddCategoryController : Controller
    {
        //
        // GET: /AddCategory/
        private readonly ICategoryDataAccess _dataAccess;
        public AddCategoryController()
        {
            _dataAccess = new CategoryDataAccess(new DtoMapper(), new CategoryRepository());
        }

        public ActionResult Index()
        {
            var model = MakeCategoryList();
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(AddCategoryViewModel model)
        {
            _dataAccess.AddNewEntity(model.Category);
            return RedirectToAction("Index", "ShowCategory");
        }

        private AddCategoryViewModel MakeCategoryList()
        {
            var model = new AddCategoryViewModel();
            model.CategoriesList =
                _dataAccess.GetAllEntities()
                    .Select(cat => new SelectListItem { Text = cat.CategoryName, Value = cat.CategoryId.ToString()});
            model.Category = new CategoryModel();
            model.Category.CategoryList = model.CategoriesList;
            model.Categories = _dataAccess.GetAllEntities();
            return model;
        }

        public ActionResult DeleteCategory(int categoryId)
        {
            _dataAccess.DeleteEntity(categoryId);
            return RedirectToAction("Index");
        }

        public ActionResult UpdateCategory(int categoryid, string categoryname, int? categoryparentid)
        {
            throw new System.NotImplementedException();
        }
    }
}
