using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBrandDal : EfEntityRepositoryBase<Brand, ReCapContext>, IBrandDal
    {
        public List<BrandDetailDto> GetBrandDetails()
        {
            using (ReCapContext context = new ReCapContext())
            {
                var result = from b in context.Brands
                             join ca in context.Cars
                             on b.BrandId equals ca.CarId
                             join co in context.Colors
                             on b.BrandId equals co.ColorId
                             select new BrandDetailDto
                             {
                                 BrandId = b.BrandId,
                                 BrandName = b.BrandName,
                                 CarName = ca.CarName,
                                 ColorName=co.ColorName,
                                 DailyPrice = ca.DailyPrice
                             };
                return result.ToList();
            }
        }
    }
}