using LicencePlateWebApp.Entities;

namespace LicencePlateWebApp.Repositories
{
    public class CarPlateRepository
    {
        CarPlateContext CarPlateContext;

        public CarPlateRepository(CarPlateContext carPlateContext)
        {
            CarPlateContext = carPlateContext;
        }
    }
}
