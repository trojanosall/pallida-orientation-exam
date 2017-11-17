using LicencePlateWebApp.Models;
using LicencePlateWebApp.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LicencePlateWebApp.Controllers
{
    public class ApiController : Controller
    {
        CarPlateRepository CarPlateRepository;

        public ApiController(CarPlateRepository carPlateRepository)
        {
            CarPlateRepository = carPlateRepository;
        }

        [HttpGet]
        [Route("/search{what}")]
        public IActionResult Search([FromBody] CarPlate carPlate, string what)
        {
            var thisCarPlate = CarPlateRepository.GetByPlate(what);

            if (thisCarPlate == null)
            {
                return NotFound();
            }

            return new ObjectResult(thisCarPlate);


        }
    }
}
