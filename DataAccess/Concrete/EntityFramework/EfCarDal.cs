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
        public List<CarDetailDto> GetCarDetails()
        {
            using (ReCapProjectContext context = new ReCapProjectContext())
            {
                var result = from car in context.Cars
                             join brand in context.Brands
                             on car.BrandID equals brand.BrandID
                             join color in context.Colors
                             on car.ColorID equals color.ColorID
                             select new CarDetailDto {Description = car.Description, ColorName = color.ColorName, BrandName = brand.BrandName, DailyPrice = car.DailyPrice };


                return result.ToList();

            }
        }

        
    }
}
