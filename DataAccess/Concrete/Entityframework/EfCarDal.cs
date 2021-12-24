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
using System.Threading.Tasks;

namespace DataAccess.Concrete.Entityframework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapCarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (ReCapCarContext context=new ReCapCarContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join x in context.Colors
                             on c.ColorId equals x.ColorId
                             select new CarDetailDto
                             {
                                 CarId=c.CarId,
                                 CarName=c.CarName,
                                 BrandName=b.BrandName,
                                 ColorName=x.ColorName,
                                 DailyPrice=c.DailyPrice
                             };

                return result.ToList();
                             
            }
        }
    }

}
