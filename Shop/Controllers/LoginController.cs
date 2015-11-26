using System.Web.Mvc;
using Shop.Models;

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
            
            return View();
        }
    }
}
