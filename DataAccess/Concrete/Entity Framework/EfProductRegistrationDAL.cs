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

namespace DataAccess.Concrete.Entity_Framework
{
    public class EfProductRegistrationDAL : EfEntityRepositoryBase<ProductRegistration, CompanyDbContext>, IProductRegistrationDAL
    {
        public List<ProductDetailsDto> GetProductDetails()
        {
            using (CompanyDbContext context = new CompanyDbContext())
            {
                var result = from p in context.ProductRegistration
                             join c in context.SoldProduct      
                             on p.NewProductId equals c.BuyerId
                             select new ProductDetailsDto
                             {
                                 ProductName = p.NewProductName,
                                 BuyerName = c.BuyerName
                             };
                return result.ToList();
            }
        }
    }
}
