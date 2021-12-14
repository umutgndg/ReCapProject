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
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> { 
                new Car{CarId=1,BrandId=2,ColorId=1,DailyPrice=300,Description="1.3 Dizel"},
                new Car{CarId=2,BrandId=1,ColorId=2,DailyPrice=400,Description="1.4 Benzin"},
                new Car{CarId=3,BrandId=2,ColorId=1,DailyPrice=300,Description="1.5 Dizel"},
                new Car{CarId=4,BrandId=1,ColorId=2,DailyPrice=400,Description="1.6 Dizel"},
                new Car{CarId=5,BrandId=2,ColorId=1,DailyPrice=500,Description="2.0 Benzin"}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
            Console.WriteLine(car.CarId+ " Id nolu araç sisteme eklendi");
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);

            _cars.Remove(carToDelete);
            Console.WriteLine(car.CarId + " Id nolu araç sistemden silindi");
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public Car GetById(int carId)
        {
            return _cars.Find(c => c.CarId == carId);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            
            Console.WriteLine(carToUpdate.CarId + " Id nolu araç bilgileri güncellendi");
        }
    }
}