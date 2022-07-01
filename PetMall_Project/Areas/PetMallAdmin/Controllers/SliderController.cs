using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PetMall_Project.DAL;
using PetMall_Project.Models;
using PetMall_Project.Utilities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PetMall_Project.Areas.PetMallAdmin.Controllers
{
    [Area("PetMallAdmin")]
    public class SliderController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public SliderController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            List<Slider> sliders = await _context.Sliders.ToListAsync();
            return View(sliders);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]

        public async Task<IActionResult> Create(Slider slider)
        {
            if (!ModelState.IsValid) return View();
            if (slider.Photo != null)
            {
                if (!slider.Photo.ContentType.Contains("image"))
                {
                    return View();
                }
                if (slider.Photo.Length > 1024 * 1024)
                {
                    return View();
                }
            }

            slider.Image = await slider.Photo.FileCreate(_env.WebRootPath, @"assets/img");
            await _context.AddAsync(slider);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }

        public async Task<IActionResult> Edit(int id)
        {
            Slider sliders = await _context.Sliders.FirstOrDefaultAsync(s => s.Id == id);
            return View(sliders);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]

        public async Task<IActionResult> Edit(Slider slider, int id)
        {
            Slider existedslider = await _context.Sliders.FirstOrDefaultAsync(s => s.Id == id);
            if (existedslider == null) return NotFound();
            if (id != slider.Id) return BadRequest();

            existedslider.Title = slider.Title;
            existedslider.Photo = slider.Photo;

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            Slider slider = await _context.Sliders.FirstOrDefaultAsync(s => s.Id == id);
            return View(slider);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        [ActionName("Delete")]

        public async Task<IActionResult> DeleteSlider(int id)
        {
            Slider slider = await _context.Sliders.FirstOrDefaultAsync(s => s.Id == id);

            Utilities.Utilities.FileDelete(_env.WebRootPath, @"assets/img",slider.Image);
            _context.Sliders.Remove(slider);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));


        }

        public async Task<IActionResult> Detail(int id)
        {
            Slider slider= await _context.Sliders.FirstOrDefaultAsync(s => s.Id == id);
            return View(slider);
        }
    }
}
