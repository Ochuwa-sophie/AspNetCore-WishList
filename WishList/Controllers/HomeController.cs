using System;
using Microsoft.AspNetCore.Mvc;

namespace Wishlist.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("Index");
        }

        public IActionResult Error()
        {
            return View("Error");
        }

        
    }
}