using Business.Abstract;
using Business.Constants;
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

        public IResult Delete(Brand brand)
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorResult(Messages.MaintenanceTime);
            }

            _brandDal.Delete(brand);
            return new SuccessResult(Messages.BrandDeleted);
        }

        public IDataResult<List<Brand>> GetAll()
        {
            if (DateTime.Now.Hour==22)
            {
                return new ErrorDataResult<List<Brand>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(), Messages.BrandListed);
        }

        public IDataResult<List<BrandDetailDto>> GetBrandDetails()
        {
            if (DateTime.Now.Hour == 23)
            {
                return new ErrorDataResult<List<BrandDetailDto>>(Messages.MaintenanceTime);
            }
            return new  SuccessDataResult<List<BrandDetailDto>>(_brandDal.GetBrandDetails());
        }

        public IDataResult<Brand> GetByBrandId(int brandId)
        {
            return new SuccessDataResult<Brand>(_brandDal.Get(c => c.BrandId == brandId));
        }

        public IResult Update(Brand brand)
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorResult(Messages.MaintenanceTime);
            }

            _brandDal.Update(brand);
            return new SuccessResult(Messages.BrandUpdated);
        }
    }
}