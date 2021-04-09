using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemCarDal
    {
        List<Car> _cars;
        public InMemCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1,BrandId=1,ColorId=1,ModelYear=2020,DailyPrice=150,Description="Araba 1"},
                new Car{Id=2,BrandId=2,ColorId=1,ModelYear=2019,DailyPrice=150,Description="Araba 2"},
                new Car{Id=3,BrandId=2,ColorId=1,ModelYear=2021,DailyPrice=150,Description="Araba 3"},
                new Car{Id=4,BrandId=3,ColorId=2,ModelYear=2020,DailyPrice=150,Description="Araba 4"},
                new Car{Id=5,BrandId=3,ColorId=2,ModelYear=2021,DailyPrice=150,Description="Araba 5"}
            };
        }

        // GetById, GetAll, Add, Update, Delete

        public Car GetById(int id)
        {
            return _cars.SingleOrDefault(c => c.Id == id);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }


    }
}
