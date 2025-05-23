using KickVault.Models.Data;
using Microsoft.AspNetCore.Mvc;

namespace KickVault.Controllers
{
    public class CartControllers : Controller
    {
        private readonly AppDbContext _context;

        public CartControllers(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
    }
}
