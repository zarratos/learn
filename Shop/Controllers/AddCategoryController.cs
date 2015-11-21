using System.Drawing.Printing;
using System.Linq;
using System.Web.Mvc;
using DAL.Repository;
using Shop.DA;
using Shop.DA.Interfaces;
using Shop.Mapping;
using Shop.Models;

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
            ViewBag.ParentCategoryId = _dataAccess.GetAllEntities().Select(o => new SelectListItem()
            {
                Text = o.CategoryName,
                Value = o.ParentCategoryId.ToString(),
            });
            return View();
        }

        [HttpPost]
        public ActionResult Index(CategoryModel model)
        {
            if (model.CategoryId != 0)
                model.ParentCategoryId = model.CategoryId;
            _dataAccess.AddNewEntity(model);
            return View();
        }

        public JsonResult GetParentCategories()
        {
            var categoryList = _dataAccess.GetAllEntities();
            return Json(categoryList, JsonRequestBehavior.AllowGet);
        }
    }
}
