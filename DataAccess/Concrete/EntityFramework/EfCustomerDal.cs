using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, CarRentalContext>, ICustomerDal
    {
        public List<CustomerDetailDto> GetCustomerDetails()
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var result = from ct in context.Customers
                             join u in context.Users
                             on  ct.UserId equals u.Id
                             join r in context.Rentals
                            on ct.CustomerId equals r.CustomerId

                             select new CustomerDetailDto
                             {
                                FirstName=u.FirstName,LastName=u.LastName,CompanyName=ct.CompanyName,RentDate=r.RentDate,ReturnDate=r.ReturnDate
                             };
                return result.ToList();
            }

        }
    }
}
