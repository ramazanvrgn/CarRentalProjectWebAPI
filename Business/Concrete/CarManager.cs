﻿using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constans;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        [SecuredOperation("car.add,admin")]
        [ValidationAspects(typeof(CarValidator))]

        public Result Add(Car car)
        {
                _carDal.Add(car);
                return new SuccessResult(Messages.CarsAdded);
           
        }

        public Result Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.CarsDeleted);

        }

        public DataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour==11)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Car>> ( _carDal.GetAll(),Messages.CarsListed);
        }

        public DataResult<Car> GetById(int _id)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c => c.Id == _id));
        }

        public DataResult<List<Car>> GetByModelYear(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Car>>( _carDal.GetAll(c => c.ModelYear >= min && c.ModelYear <= max));
        }

        public DataResult<List<CarDetailDto>> GetCarDetail()
        {
            return new SuccessDataResult<List< CarDetailDto >>( _carDal.GetCarDetails());
        }

        public DataResult<List<Car>> GetCarsByBrandId(int _brandId)
        {
          return new SuccessDataResult<List<Car>> (_carDal.GetAll(c => c.BrandId == _brandId));
        }

        public DataResult<List<Car>> GetCarsByColorId(int _colorId)
        {
            return new SuccessDataResult<List<Car>> (_carDal.GetAll(c => c.ColorId == _colorId));
        }

        public Result Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult(Messages.CarsUpdated);

        }
    }
}
