﻿using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IResult Add(Brand brand)
        {
            if (brand.BrandName.Length<2)
            {
                return new ErrorResult("Marka ismi min 2 karakter olmalıdır");
            }
            _brandDal.Add(brand);

            return new SuccessResult("Marka eklendi");
        }

        public IDataResult<List<Brand>> GetAll()
        {
            if (DateTime.Now.Hour==22)
            {
                return new ErrorResult();
            }
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(),true,"Markalar listelendi");
        }

        public List<BrandDetailDto> GetBrandDetails()
        {
            return _brandDal.GetBrandDetails();
        }

        public Brand GetById(int brandId)
        {
            return _brandDal.Get(c => c.BrandId == brandId);
        }
    }
}