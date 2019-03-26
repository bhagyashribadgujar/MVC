using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication2.Models;
namespace MvcApplication2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Dept obj)
        {
            Response.Write("DeptNo:" + obj.Deptno);
            Response.Write("<br/> DeptName: " + obj.Dname);
            Response.Write("<br/> Location: " + obj.Location);
            return View();
        }
    }
}