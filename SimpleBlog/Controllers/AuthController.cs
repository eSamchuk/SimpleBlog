using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimpleBlog.ViewModels;

namespace SimpleBlog.Controllers
{
    public class AuthController : Controller
    {
        // GET: Auth
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(AuthLogin Al)
        {
            if (!ModelState.IsValid)
            {
                return View(Al);
            }

            if (Al.Username == "Katsuragi Misato")
            {
                ModelState.AddModelError("Username", "Thre is no beer in here, Captain Katsuragi");
                return View(Al);
            }


            return Content("Form is valid");
        }

    }
}