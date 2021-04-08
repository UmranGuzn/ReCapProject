using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspect.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Helpers;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {

        ICarImageDal _carImageDal;
        public CarImageManager(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;
        }


        [ValidationAspect(typeof(CarImageValidator))]
        public IResult Add(IFormFile formFile, CarImage carImage)
        {
            IResult result = BusinessRules.Run(CheckCarImageLimit(carImage.CarId));
            if (result != null)
            {
                return result;
            }
            carImage.ImagePath = FileHelper.Add(formFile);
            carImage.CarImageDate = DateTime.Now;
            _carImageDal.Add(carImage);

            return new SuccessResult(Messages.CarImageAdded);
        }

        public IResult Delete(CarImage carImage)
        {
            var oldPath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\wwroot")) + _carImageDal.Get(i => i.CarId == carImage.CarId).ImagePath;
            var result = BusinessRules.Run(FileHelper.Delete(oldPath));
            if (result != null)
            {
                return result;
            }

            //FileHelper.Delete(carImage.ImagePath);
            _carImageDal.Delete(carImage);

            return new SuccessResult(Messages.CarAdded);
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll());
        }

        public IDataResult<List<CarImage>> GetImagesByCarId(int id)
        {
            IResult result = BusinessRules.Run(CheckIfCarImageNull(id));

            if (result!=null)
            {
                return new ErrorDataResult<List<CarImage>>(result.Message);
            }

            return new SuccessDataResult<List<CarImage>>(CheckIfCarImageNull(id).Data);
        }


        public IDataResult<CarImage> Get(int id)
        {
            return new SuccessDataResult<CarImage>(_carImageDal.Get(p=>p.CarId==id));
        }


        [ValidationAspect(typeof(CarImageValidator))]
        public IResult Update(IFormFile formFile, CarImage carImage)
        {
            var oldPath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\wwroot")) + _carImageDal.Get(i => i.CarId == carImage.CarId).ImagePath;
            carImage.ImagePath = FileHelper.Update(oldPath,formFile);
            carImage.CarImageDate = DateTime.Now;
            _carImageDal.Update(carImage);

            return new SuccessResult();
        }


        private IResult CheckCarImageLimit(int carId)
        {
            var result = _carImageDal.GetAll(p => p.CarId == carId).Count;
            if (result>5)
            {
                return new ErrorResult(Messages.CarImageLimit);
            }

            return new SuccessResult();
        }

        private IDataResult<List<CarImage>> CheckIfCarImageNull(int id)
        {
            try
            {
                string path = @"\Images\default.jpg";
                var result = _carImageDal.GetAll(c => c.CarId == id).Any();
                if (!result)
                {
                    List<CarImage> carImages = new List<CarImage>();
                    carImages.Add(new CarImage { CarId = id, ImagePath = path, CarImageDate = DateTime.Now });
                    return new SuccessDataResult<List<CarImage>>(carImages);
                }
            }
            catch (Exception e)
            {
                return new ErrorDataResult<List<CarImage>>(e.Message);
                
            }
            
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(c => c.CarId == id));
        }
    }
}
