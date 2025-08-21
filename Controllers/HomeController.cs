using System.Diagnostics;
using CATERINGMANAGEMENTSERVICE.Models;
using Microsoft.AspNetCore.Mvc;

namespace CATERINGMANAGEMENTSERVICE.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Welcome"] = User.Identity?.IsAuthenticated == true
            ? $"Welcome back, {User.Identity.Name}!"
            : "Welcome to Cucina de Corazon Catering Services!";

            return View();
        }
        
        public IActionResult Privacy()
        {
            return View();
        }

    }
}
