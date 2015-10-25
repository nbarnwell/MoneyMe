using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace MoneyMe.Web.Controllers
{
    [RequireHttps]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var controllerNames = Assembly.GetExecutingAssembly()
                                          .GetTypes()
                                          .Where(x => typeof(Controller).IsAssignableFrom(x))
                                          .Select(x => Regex.Replace(x.Name, "Controller$", ""))
                                          .ToList();

            ViewBag.ControllerNames = controllerNames;

            return View();
        }
    }
}