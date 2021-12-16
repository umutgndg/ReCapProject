using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Data Transformation Object
            //CarTest();
            //IoC
            BrandTest();

        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetBrandDetails())
            {
                Console.WriteLine("{0} / {1} / {2} / {3} ", brand.CarName , brand.BrandName , brand.ColorName , brand.DailyPrice);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetByDailyPrice(100, 600))
            {
                Console.WriteLine(car.CarName);
            }
        }
    }
}