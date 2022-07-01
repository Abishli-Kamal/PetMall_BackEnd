using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PetMall_Project.DAL;
using PetMall_Project.Models;
using PetMall_Project.View_Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PetMall_Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            HomeVM model = new HomeVM
            {
                Sliders = await _context.Sliders.ToListAsync(),
                ProductCardOnes = await _context.ProductCardOnes.ToListAsync(),
                Products = await _context.Products.ToListAsync(),
                Categories = await _context.Categories.ToListAsync(),   
                Contacts=await _context.Contacts.ToListAsync(),
                
            };
            return View(model);
        }   
    }
}
