using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            Car car1 = new Car();
            car1.CarId = 6;
            car1.BrandId = 2;
            car1.ColorId = 3;
            car1.DailyPrice = 700;
            car1.Description = "1.6 Dizel";

            Car car2 = new Car();
            car2.CarId = 7;
            car2.BrandId = 1;
            car2.ColorId = 2;
            car2.DailyPrice = 450;
            car2.Description = "1.5 Benzin";

            carManager.Add(car1);
            carManager.Add(car2);

            Console.WriteLine("----------------------------------------");

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }

            Console.WriteLine("----------------------------------------");

            carManager.Delete(car2);

            Console.WriteLine("----------------------------------------");

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }

            Console.WriteLine("----------------------------------------");

            car1.Description = "1.2 Dizel";
            carManager.Update(car1);

            Console.WriteLine("----------------------------------------");

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }

            Console.WriteLine("----------------------------------------");

            var findCar = carManager.GetById(1);
            Console.WriteLine(findCar.DailyPrice);
        }
    }
}
