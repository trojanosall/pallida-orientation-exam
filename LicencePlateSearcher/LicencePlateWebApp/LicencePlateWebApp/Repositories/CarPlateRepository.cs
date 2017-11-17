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


        public List<CarPlate> GetSearchList(string userInput)
        {
            var listOfCarPlates = (from carplates in CarPlateContext.CarPlates
                                   orderby carplates.Plate descending
                                   select carplates).ToList();

            List<CarPlate> SearchedList = new List<CarPlate>();

            foreach (var item in listOfCarPlates)
            {
                string partOfPlates = item.Plate.Substring(0, userInput.Length);

                if (partOfPlates == userInput)
                {
                    SearchedList.Add(item);
                }
            }

            return SearchedList;
        }

        public List<CarPlate> GetListPoliceCar()
        {
            var listOfCarPlates = (from carplates in CarPlateContext.CarPlates
                                   orderby carplates.Plate descending
                                   select carplates).ToList();

            string policeCarSign = "RB";

            List<CarPlate> SearchedListPoliceCar = new List<CarPlate>();

            foreach (var item in listOfCarPlates)
            {
                string partOfPlates = item.Plate.Substring(0, policeCarSign.Length);

                if (partOfPlates == policeCarSign)
                {
                    SearchedListPoliceCar.Add(item);
                }
            }

            return SearchedListPoliceCar;
        }


        //public List<CarPlate> GetSearchPlate()
        //{

        //    //return CalorieTableContext.Foods.ToList();
        //}
    }
}
