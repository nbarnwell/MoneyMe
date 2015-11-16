using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using Microsoft.Ajax.Utilities;

namespace MoneyMe.Web.Controllers
{
    [RequireHttps]
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

    public class ControllerViewModel
    {
        public string Name { get; set; }
        public string Area { get; set; }
        public string DisplayName { get; set; }
    }
}