using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewCoreDemo.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {

            ViewBag.Category = "Category Index";
            return View();
        }
    }
}
