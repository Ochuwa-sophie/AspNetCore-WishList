using System;
using Microsoft.AspNetCore.Mvc;

namespace Wishlist
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("~/Views/Home/Index.cshtml");
        }

        public IActionResult Error()
        {
            return View("~/Views/Shared/Error.cshtml");
        }

        
    }
}