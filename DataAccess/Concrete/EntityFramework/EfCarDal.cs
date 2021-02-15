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
    public class EfCarDal : EfEntityRepositoryBase<Car, RentaCarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (RentaCarContext context = new RentaCarContext())
            {
                var result = from c in context.Cars
                             join o in context.Colors
                             on c.ColorId equals o.ColorId
                             select new CarDetailDto
                             { Id = c.Id, ColorName = o.ColorName, BrandName = c.BrandName, DailyPrice = c.DailyPrice };
                return result.ToList();
                             
                             

            }
        }
    }
}
