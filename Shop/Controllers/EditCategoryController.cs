using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using DAL.Repository;
using Shop.DA;
using Shop.DA.Interfaces;
using Shop.Mapping;
using Shop.Models;

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
            var model = _dataAccess.GetCategoryById(categoryId);
            model.CategoryList = MakeCategoryList();
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(ShowCategoryModel model)
        {
            var entity = new CategoryModel
            {
                CategoryId = model.CategoryId,
                CategoryName = model.CategoryName,
                ParentCategoryId = model.ParentCategoryId
            };
            _dataAccess.UpdateEntity(entity);
            return RedirectToAction("Index", "ShowCategory");
        }

        private IEnumerable<SelectListItem> MakeCategoryList()
        {
            var result =
                _dataAccess.GetAllEntities()
                    .Select(cat => new SelectListItem { Text = cat.CategoryName, Value = cat.CategoryId.ToString() });
            return result;
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
