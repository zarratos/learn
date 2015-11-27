using System.Web.Mvc;
using Shop.Models;
using Shop.Validators;

namespace Shop.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(UserModel model)
        {
            if (!UserValidator.UserEmptyLoginValidate(model, this.ModelState))
                return View();
            
            return RedirectToAction("Index", "Home");
        }
    }
}
