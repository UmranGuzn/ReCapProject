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
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapProjectContext>, ICarDal
    {
       
        public List<CarDetailDto> GetCarDetails(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            using (ReCapProjectContext context=new ReCapProjectContext())
            {
                var result = from car in context.Cars

                             join c in context.Colors
                             on car.ColorId equals c.ColorId

                             join b in context.Brands
                             on car.BrandId equals b.BrandId

                            
                             select new CarDetailDto 
                             { 
                                 CarId = car.CarId, 
                                 DailyPrice = car.DailyPrice, 
                                 ColorName = c.ColorName, 
                                 Descriptions = car.Descriptions,
                                 BrandName=b.BrandName,
                                 ModelYear=car.ModelYear,
                                 BrandId=b.BrandId,
                                 ColorId=c.ColorId
                                 
                             };

                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }
      
        public CarDetailDto GetCarDetails(int carId)
        {
            using (ReCapProjectContext context = new ReCapProjectContext())
            {
                var result = from car in context.Cars.Where(c => c.CarId == carId)
                             join color in context.Colors
                             on car.ColorId equals color.ColorId
                             join brand in context.Brands
                             on car.BrandId equals brand.BrandId
                             select new CarDetailDto()
                             {
                                 CarId=car.CarId,
                                 BrandId = brand.BrandId,
                                 ColorId = color.ColorId,
                                 BrandName = brand.BrandName,
                                 ColorName = color.ColorName,
                                 DailyPrice = car.DailyPrice,
                                 Descriptions = car.Descriptions,
                                 ModelYear = car.ModelYear
                             };
                return result.SingleOrDefault();
            }

            
        }
    }
}
