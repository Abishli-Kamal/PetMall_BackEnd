using Microsoft.AspNetCore.Mvc;

namespace PetMall_Project.Areas.PetMallAdmin.Controllers
{
    [Area("PetMallAdmin")]
    public class DashbroadController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
