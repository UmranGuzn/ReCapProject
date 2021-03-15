using Business.Abstract;
using Business.CCS;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspect.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        IColorService _colorService;
      
        public CarManager(ICarDal carDal,IColorService colorService)
        {
            _carDal = carDal;
            _colorService = colorService;
           
        }

        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car car)
        {
          IResult result=  BusinessRules.Run(ChechkIfCarCountOfBrandCorrect(car.BrandId), ChechkIfColorLimitExceded());

            if (result!=null)
            {
                return result;
            }
          
            _carDal.Add(car);

            return new SuccessResult(Messages.CarAdded);
          
      
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);

            return new SuccessResult(Messages.CarDeleted);
        }

        public IDataResult<List<Car>> GetAll()
        {
            //iş kodları
            //yetkisi var mı?
            //gerekli koşulları yerine getiriyor mu?
            if (DateTime.Now.Hour == 24)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            }


            return new SuccessDataResult<List<Car>>(_carDal.GetAll(),Messages.AllListed);
        }

        public IDataResult<List<Car>> GetAllByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.BrandId == id));
        }

        public IDataResult<List<Car>> GetAllByColorId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.ColorId == id));
        }

        public IDataResult<List<Car>> GetByDailyPrice(decimal min, decimal max)
        {
            
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.DailyPrice >= min && p.DailyPrice <= max));
        }

        public IDataResult<Car> GetById(int carId)
        {
            return new SuccessDataResult<Car>(_carDal.Get(p => p.CarId == carId));
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());
        }

        [ValidationAspect(typeof(CarValidator))]
        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult(Messages.CarUpdated);
        }


        private IResult ChechkIfCarCountOfBrandCorrect(int brandId)
        {
            var result = _carDal.GetAll(p => p.BrandId == brandId).Count;

            if (result >= 10)
            {
                return new ErrorResult(Messages.BrandCountError);
            }

            return new SuccessResult();
        }

        private IResult ChechkIfColorLimitExceded()
        {
            var result = _colorService.GetAll();

            if (result.Data.Count > 15)
            {
                return new ErrorResult(Messages.ColorLimitExceded);
            }

            return new SuccessResult();
        }


    }
}
