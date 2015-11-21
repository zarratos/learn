using System.Web.Mvc;
using DAL.Repository;
using Shop.DA;
using Shop.DA.Interfaces;
using Shop.Mapping;

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
            var model = parentId == null ? _dataAccess.GetAllEntities() : _dataAccess.GetCategoriesByParentId( (int) parentId);
            return View(model);
        }
    }
}
