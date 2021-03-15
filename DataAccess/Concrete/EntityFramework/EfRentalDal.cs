using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, CarRentalContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (CarRentalContext context=new CarRentalContext())
            {
                var result = from r in context.Rentals
                             join c in context.Customers on r.CustomerId equals c.CustomerId
                             join u in context.Users on c.UserId equals u.Id
                             join cr in context.Cars on r.CarId equals cr.Id
                             join b in context.Brands on cr.BrandId equals b.Id
                             select new RentalDetailDto
                             {
                                 RentalId = r.RentalId,
                                 BrandName = b.BrandName,
                                 UserName= u.FirstName +" "+ u.LastName,
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate
                             };


                return result.ToList();
            }
        }
    }
}
