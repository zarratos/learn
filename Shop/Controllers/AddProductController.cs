using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using DAL.Repository;
using Shop.DA;
using Shop.DA.Interfaces;
using Shop.Mapping;
using Shop.Models;

namespace Shop.Controllers
{
    public class AddProductController : Controller
    {
        private readonly IProductDataAccess _productDataAccess;
        private readonly ICategoryDataAccess _caregoryDataAccess;
        //
        // GET: /AddProduct/

        public AddProductController()
        {
            _productDataAccess = new ProductDataAccess(new DtoMapper(), new ProductRepository());
            _caregoryDataAccess = new CategoryDataAccess(new DtoMapper(), new CategoryRepository());
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(ProductModel model, HttpPostedFileBase image)
        {
            if (image != null)
            {
                model.ImageMimeType = image.ContentType;
                model.ImageData = new byte[image.ContentLength];
                image.InputStream.Read(model.ImageData, 0, image.ContentLength);
            }
            _productDataAccess.AddNewEntity(model);
            return View();
        }

        public JsonResult GetCategories()
        {
            var categoryList = _caregoryDataAccess.GetAllEntities();
            return Json(categoryList, JsonRequestBehavior.AllowGet);
        }
    }
}
