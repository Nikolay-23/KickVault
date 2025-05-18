using Microsoft.AspNetCore.Mvc;

namespace KickVault.Controllers
{
    public class BrandController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
