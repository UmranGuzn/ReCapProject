using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
   public interface ICarService
    {
        IResult Add(Car car);

        IResult Delete(Car car);

        IResult Update(Car car);

        IDataResult<List<Car>> GetAll();

        //IDataResult<List<CarDetailDto>> GetDetail();

        IDataResult<List<Car>> GetAllByBrandId(int id);

        IDataResult<List<Car>> GetAllByColorId(int id);

        IDataResult<List<Car>> GetByDailyPrice(decimal min, decimal max);

        IDataResult<List<CarDetailDto>> GetCarDetails();

        IDataResult<CarDetailDto> GetDetail(int id);

        IDataResult<Car> GetById(int carId);

        IResult AddTransactionalTest(Car car);

        IDataResult<List<CarDetailDto>> GetCarsBrandAndColor(int brandId, int colorId);
    }
}
