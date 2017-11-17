using LicencePlateWebApp.Entities;
using LicencePlateWebApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace LicencePlateWebApp.Repositories
{
    public class CarPlateRepository
    {
        CarPlateContext CarPlateContext;

        public CarPlateRepository(CarPlateContext carPlateContext)
        {
            CarPlateContext = carPlateContext;
        }

        public CarPlate GetByPlate(string userInput)
        {
            var selectedItem = from selectOne in CarPlateContext.CarPlates
                               where selectOne.Plate == userInput
                               select selectOne;

            return selectedItem.FirstOrDefault();
        }


        public List<CarPlate> GetList()
        {
            var listOfCarPlates = (from carplates in CarPlateContext.CarPlates
                                   orderby carplates.Plate descending
                                   select carplates).ToList();

            return listOfCarPlates;
        }


        //public List<CarPlate> GetSearchPlate()
        //{

        //    //return CalorieTableContext.Foods.ToList();
        //}
    }
}
