using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shop.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var cookie = new HttpCookie ("test_cookie", DateTime.Now.ToString("dd.MM.yyyy"))
            {
                Expires = DateTime.Now.AddMinutes(10),
            };
            Response.SetCookie(cookie);

            return View();
        }

    }
}
