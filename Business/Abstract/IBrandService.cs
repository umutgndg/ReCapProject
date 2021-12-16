using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandService
    {
        IResult Add(Brand brand);
        List<Brand> GetAll();
        Brand GetById(int brandId);
        List<BrandDetailDto> GetBrandDetails();
    }
}