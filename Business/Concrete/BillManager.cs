using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.DTOs;
using Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BillManager : IBillService
    {
        IBillDal _billDal;
        ICustomerDal _customerDal;
        public BillManager(IBillDal billDal)
        {
            _billDal = billDal;
        }

        public IResult Buy(Bill bill)
        {
            double discount=Discount(bill);
            bill.Amount = bill.Amount*discount;
            _billDal.Add(bill);
            return new SuccessResult("Success");
        }

        public IDataResult<Bill> Get(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Bill>> GetAll()
        {
            throw new NotImplementedException();
        }
        public double Discount(Bill bill)
        {
            List<double> discount = new List<double>();
            var _customer=_customerDal.Get(c=>c.Id==bill.CustomerId);
            if(_customer.Affilation == true)
            {
                discount.Add(0.1);
            }
            else if(_customer.Card == CardTypes.Gold)
            {
                discount.Add(0.3);
            }
            else if (_customer.Card == CardTypes.Silver)
            {
                discount.Add(0.2);
            }
            else if ((_customer.MemberDateTime.Year-DateTime.Now.Year)>=2)
            {
                discount.Add(0.05);
            }
            else if (bill.CurrencyCode==CurrencyCodes.USD)
            {
                
            }
            discount.Sort();
            return discount.First();
        }
    }
}
