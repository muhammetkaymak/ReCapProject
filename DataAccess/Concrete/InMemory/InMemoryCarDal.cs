using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;   //Global Değişkenleri altçizgi "_" ile gösteririz.

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1,BrandId=1,BrandName="Volvo",ColorName="White",ModelYear=2020,DailyPrice=100,Description="Volvo marka beyaz bir araç"},
                new Car{CarId=2,BrandId=1,BrandName="Volvo",ColorName="Black",ModelYear=2021,DailyPrice=150,Description="Volvo marka siyah bir araç"},
                new Car{CarId=3,BrandId=2,BrandName="Fiat",ColorName="Blue",ModelYear=2018,DailyPrice=70,Description="Fiat marka mavi bir araç"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorName = car.ColorName;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
