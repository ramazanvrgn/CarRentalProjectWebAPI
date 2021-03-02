using Business.Abstract;
using Business.Constans;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
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
        [ValidationAspects(typeof(BrandValidator))]
        public Result Add(Brand brand)
        {
           
           _brandDal.Add(brand);
            return new SuccessResult(Messages.BrandsAdded);
        }

        public Result Delete(Brand brand)
        {
            _brandDal.Delete(brand);

            return new SuccessResult(Messages.BrandsDeleted);

        }

        public DataResult<List<Brand>> GetAll()
        {
            
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(), Messages.BrandsListed);
        }

        public DataResult<Brand> GetById(int _brandId)
        {
            return new SuccessDataResult<Brand>(_brandDal.Get(b => b.Id == _brandId));

            
        }

        public Result Update(Brand brand)
        {
            _brandDal.Update(brand);
            return new SuccessResult(Messages.BrandsUpdated);



        }
    }
}
