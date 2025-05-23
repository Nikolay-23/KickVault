using System.Diagnostics;
using KickVault.Models;
using Microsoft.AspNetCore.Mvc;

namespace KickVault.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
