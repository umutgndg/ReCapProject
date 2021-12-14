using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        public void Add(Car car);
        List<Car> GetAll();
        List<Car> GetAllByBrandId(int brandId);
        List<Car> GetByDailyPrice(int min, int max);
        List<Car> GetCarsByBrandId(int brandId);
        List<Car> GetCarsByColorId(int colorId);
    }
}
