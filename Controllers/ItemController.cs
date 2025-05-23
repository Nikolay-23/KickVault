using KickVault.Models;
using KickVault.Models.Data;
using KickVault.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;

namespace KickVault.Controllers
{
    public class ItemController : Controller
    {

        private readonly AppDbContext _context;

        public ItemController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var items = _context.Items.ToList(); //Retrieve all items form the database
            return View(items);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new ItemViewModel());
        }

        public IActionResult Details(int id)
        {
            var item = _context.Items.Find(id);

            if (item == null)
            {
                return NotFound();
            }

            return View(item);
        }

        [HttpPost]
        public IActionResult Create(ItemViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var items = new Item
                {
                    ImageURL = viewModel.ImageURL,
                    Model = viewModel.Model,
                    Description = viewModel.Description,
                    Price = viewModel.Price,
                    Size = viewModel.Size,
                    ReleaseDate = viewModel.ReleaseDate
                };

                _context.Items.Add(items);
                _context.SaveChanges();

                return RedirectToAction("Index");

            }
            return View(viewModel);
        }
    }
}
