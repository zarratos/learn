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
        private readonly IProductDataAccess _dataAccess;
        //
        // GET: /AddProduct/

        public AddProductController()
        {
            _dataAccess = new ProductDataAccess(new DtoMapper(), new ProductRepository());
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
            _dataAccess.AddNewEntity(model);
            return View();
        }

        public JsonResult GetActiveCompanies()
        {
            var a = new List<CategoryModel>();
            for (int i = 0; i < 5; i++)
            {
                a.Add(new CategoryModel {CategoryId = i+1, CategoryName = "Name" + i});
            }
            return Json(a, JsonRequestBehavior.AllowGet);
        }
    }
}
