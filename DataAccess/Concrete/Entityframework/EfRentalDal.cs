using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Entityframework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, ReCapCarContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (ReCapCarContext context=new ReCapCarContext())
            {
                var result = from r in context.Rentals
                             join b in context.Brands
                             on r.BrandId equals b.BrandId
                             join x in context.Customers
                             on r.CustomerId equals x.CustomerId
                             select new RentalDetailDto
                             {
                                 RentalId=r.RentalId,
                                 BrandName=b.BrandName,
                                 FirstName=x.FirstName,
                                 LastName=x.LastName

                             };


                return result.ToList();


            }
        }
    }
}
