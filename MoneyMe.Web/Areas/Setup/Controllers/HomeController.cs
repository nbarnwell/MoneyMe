using System;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Web.Mvc;
using MoneyMe.Web.Controllers;

namespace MoneyMe.Web.Areas.Setup.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var controllers =
                Assembly.GetExecutingAssembly()
                        .GetTypes()
                        .Where(x => typeof(Controller).IsAssignableFrom(x))
                        .Where(x => x.GetMethod("Index") != null)
                        .Select(GetControllerViewModel)
                        .ToList();

            ViewBag.Controllers = controllers;

            return View();
        }

        private ControllerViewModel GetControllerViewModel(Type arg)
        {
            var controllerViewModel = new ControllerViewModel
            {
                Area        = GetAreaName(arg),
                Name        = GetControllerName(arg),
                DisplayName = GetControllerName(arg)
            };
            return controllerViewModel;
        }

        private string GetControllerName(Type type)
        {
            return Regex.Replace(type.Name, "Controller$", "");
        }

        private string GetAreaName(Type type)
        {
            if (type.Namespace == null)
            {
                return null;
            }

            if (!type.Namespace.Contains(".Areas."))
            {
                return null;
            }

            return Regex.Match(type.Namespace, @"\.Areas\.([A-Za-z0-9]+)\.").Groups[1].Value;
        }
    }
}