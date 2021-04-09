using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            InMemCarDal carDal = new InMemCarDal();
            WriteTitle("GetById(1)");
            var carById = carDal.GetById(1);
            Console.WriteLine("| " + "{0,-6}" + " | " + "{1,-9}" + " | " + "{2,-9}" + " | " + "{3,-9}" + " | " + "{4,-10}" + " | " + "{5,-50}" + " | ",
                                        "Id", "BrandId", "ColorId", "ModelYear", "DailyPrice", "Description");
            Console.WriteLine("| " + "{0,-6}" + " | " + "{1,-9}" + " | " + "{2,-9}" + " | " + "{3,-9}" + " | " + "{4,-10}" + " | " + "{5,-50}" + " | ",
                                   carById.Id, carById.BrandId, carById.ColorId, carById.ModelYear, carById.DailyPrice, carById.Description);
            WriteSeperate();


            WriteTitle("GetAll()");
            GetAllCars(carDal);


            WriteTitle("Add(6)");
            var addCar = new Car
            {
                Id = 6,
                BrandId = 3,
                ColorId = 3,
                ModelYear = 2019,
                DailyPrice = 100,
                Description = "Araba 6"
            };
            carDal.Add(addCar);
            GetAllCars(carDal);


            WriteTitle("Update(5)");
            var updateCar = new Car
            {
                Id = 5,
                BrandId = 3,
                ColorId = 3,
                ModelYear = 2019,
                DailyPrice = 105,
                Description = "Araba 555"
            };
            carDal.Update(updateCar);
            GetAllCars(carDal);


            WriteTitle("Delete(5)");
            var deleteCar = new Car
            {
                Id = 5
            };
            carDal.Delete(deleteCar);
            GetAllCars(carDal);
        }

        private static void WriteTitle(string title)
        {
            Console.WriteLine($"++++++++++ {title} ++++++++++");
        }

        private static void WriteSeperate()
        {
            Console.WriteLine("------------------------------");
        }

        private static void GetAllCars(InMemCarDal carDal)
        {
            Console.WriteLine("| " + "{0,-6}" + " | " + "{1,-9}" + " | " + "{2,-9}" + " | " + "{3,-9}" + " | " + "{4,-10}" + " | " + "{5,-50}" + " | ",
                            "Id", "BrandId", "ColorId", "ModelYear", "DailyPrice", "Description");
            var carList = carDal.GetAll();
            foreach (var carItem in carList)
            {
                Console.WriteLine("| " + "{0,-6}" + " | " + "{1,-9}" + " | " + "{2,-9}" + " | " + "{3,-9}" + " | " + "{4,-10}" + " | " + "{5,-50}" + " | ",
                                   carItem.Id, carItem.BrandId, carItem.ColorId, carItem.ModelYear, carItem.DailyPrice, carItem.Description);
            }
            WriteSeperate();
        }
    }
}
