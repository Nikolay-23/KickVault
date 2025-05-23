using KickVault.Models;
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
            //fetch all items in the favorite itmes list
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

        [HttpPost]
        public async Task<IActionResult> AddToFavoriteItem(int itemId)
        {
            var userId = _userManager.GetUserId(User);

            var userItem = await _context.UserItems
                .FirstOrDefaultAsync(ui => ui.UserId == userId && ui.ItemId == itemId);

            if (userItem == null)
            {
                //add the item to the watchlist
                userItem = new UserItem
                {
                    UserId = userId,
                    ItemId = itemId
                };

                _context.UserItems.Add(userItem);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction("Index", "Item");
        }

        [HttpPost]
        public async Task<IActionResult> RemoveFromFavoriteItem(int itemId)
        {
            var userId = _userManager.GetUserId(User);

            //find the item in the favoriteItemList
            var userItem = await _context.UserItems
                .FirstOrDefaultAsync(ui => ui.UserId == userId && ui.ItemId == itemId);

            if (userItem != null)
            {
                //remove the item from favoriteItemList
                _context.UserItems.Remove(userItem);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction("Index");
        }
    }
}
