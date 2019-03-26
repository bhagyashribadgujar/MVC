using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GetPostProject.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            Response.Write("Get Request");
            return View();
        }
        [HttpPost]
        public ActionResult Login(FormCollection formCollection)
        {
            Response.Write("Post Request <br/>");
            string str1 = formCollection["uid"];
            string str2 = formCollection["pwd"];
            if (str1 == "admin" && str2 == "admin123")
            {
                Response.Write("welcome to Admin");
            }
            else
            {
                Response.Write("Invalid User-id or Password");
            }
            return View();
        }

        [HttpGet]
        public ActionResult Sum()
        {
            Response.Write("Get Request");
            return View();
        }
        [HttpPost]
        public ActionResult sum(int x, int y)
        {
            int z = x + y;
            Response.Write("Addition is : " + z);
            return View();
        }

    }
}
