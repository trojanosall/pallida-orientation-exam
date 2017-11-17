using LicencePlateWebApp.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LicencePlateWebApp.Controllers
{
    public class HomeController : Controller
    {
        CarPlateRepository CarPlateRepository;

        public HomeController(CarPlateRepository carPlateRepository)
        {
            CarPlateRepository = carPlateRepository;
        }

        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
