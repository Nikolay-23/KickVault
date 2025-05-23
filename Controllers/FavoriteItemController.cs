using KickVault.Models.Data;
using KickVault.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KickVault.Controllers
{
    public class FavoriteItemController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public FavoriteItemController(AppDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public async Task<IActionResult> Index()
        {
            var userId = _userManager.GetUserId(User);

            var favoriteItems = await _context.UserItems
                .Where(ui => ui.UserId == userId)
                .Include(ui => ui.Item)
                .Select(ui => new FavoriteViewModel
                {
                    ItemId = ui.ItemId,
                    ImageURL = ui.Item.ImageURL,
                    Model = ui.Item.Model,
                    Description = ui.Item.Description,
                    Price = ui.Item.Price,
                    Size = ui.Item.Size,
                    ReleaseDate = ui.Item.ReleaseDate
                })
                .ToListAsync();

            return View(favoriteItems);
        }
    }
}
