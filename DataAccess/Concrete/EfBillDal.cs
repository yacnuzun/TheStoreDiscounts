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
        public List<BuyDiscountDto> GetAllByDiscount(int id)
        {
            using (TheStoreDbContext context=new TheStoreDbContext())
            {
                var result = from c in context.Customers.Where(c => c.Id == id)
                             join b in context.Bills
                             on c.Id equals b.CustomerId
                             select new BuyDiscountDto
                             {

                                 CustomerId = c.Id,
                                 CardT = c.Card,
                                 Affilation = c.Affilation,
                                 MemberDateTime = c.MemberDateTime,
                                 Currency = b.CurrencyCode
                             };
                return result.ToList();
            }
            
        }
    }
}
