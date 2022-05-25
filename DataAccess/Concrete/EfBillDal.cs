using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.DTOs;
using Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EfBillDal : EfEntityRepositoryBase<Bill, TheStoreDbContext>, IBillDal
    {
        public BuyDiscountDto GetAllByDiscount(int id)
        {
            using (TheStoreDbContext context=new TheStoreDbContext())
            {
                var result = from c in context.Customers.Where(c => c.Id == id)
                             select new BuyDiscountDto()
                             {

                                 CustomerId = c.Id,
                                 Card = c.Card,
                                 Affilation = c.Affilation,
                                 MemberDateTime = c.MemberDateTime
                             };
                return result.SingleOrDefault();
            }
            
        }
    }
}
