using System.Collections.Generic;
using System.Web.Mvc;
using DAL.Repository;
using Shop.DA;
using Shop.DA.Interfaces;
using Shop.Mapping;
using Shop.Models;

namespace Shop.Controllers
{
    public class ShowCategoryController : Controller
    {
        //
        // GET: /ShowCategory/
        private readonly ICategoryDataAccess _dataAccess;
        public ShowCategoryController()
        {
            _dataAccess = new CategoryDataAccess(new DtoMapper(), new CategoryRepository());
        }

        public ActionResult Index(int? parentId)
        {
            var model = MakeCategoryList();
            return View(model);
        }

        private IEnumerable<ShowCategoryModel> MakeCategoryList()
        {
            var model = new List<ShowCategoryModel>();
            var data = _dataAccess.GetAllEntities();
            foreach (var categoryModel in data)
            {
                var entity = new ShowCategoryModel();
                entity.CategoryId = categoryModel.CategoryId;
                entity.CategoryName = categoryModel.CategoryName;
                entity.ParentCategoryId = categoryModel.ParentCategoryId;
                entity.ParentCategoryName = GetcategoryNameById(categoryModel.ParentCategoryId);
                model.Add(entity);
            }
            return model;
        }

        private string GetcategoryNameById(int? parentCategoryId)
        {
            if (parentCategoryId == null)
                return "--Нет--";
            return _dataAccess.GetCategoryById((int) parentCategoryId).CategoryName;
        }

        public ActionResult EditCategory(int categoryId)
        {
            return RedirectToAction("Index", "EditCategory", new {categoryid = categoryId});
        }

        public ActionResult DeleteCategory(int categoryid)
        {
            _dataAccess.DeleteEntity(categoryid);
            return RedirectToAction("Index");
        }
    }
}
