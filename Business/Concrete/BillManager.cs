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

        

        public BillManager(IBillDal billDal)
        {
            _billDal = billDal;
        }

        public IResult Buy(Bill bill)
        {
            double discount= AmountDiscount(bill);
            bill.Amount=discount;
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
        public double AmountDiscount(Bill bill)
        {
            List<double> discount = new List<double>();
            var _buyDiscountDto = _billDal.GetAllByDiscount(bill.CustomerId);
            if(_buyDiscountDto.Affilation == true)
            {
                double AffilationDiscount = bill.Amount-(bill.Amount * 0.1);
                discount.Add(AffilationDiscount);
            }
            if(_buyDiscountDto.Card == CardTypes.Gold)
            {
                double CardDiscount = bill.Amount - (bill.Amount * 0.3);
                discount.Add(CardDiscount);
            }
            if (_buyDiscountDto.Card == CardTypes.Silver)
            {
                double CardDiscount = bill.Amount - (bill.Amount * 0.2);
                discount.Add(CardDiscount);
            }
            if ((DateTime.Now.Year-_buyDiscountDto.MemberDateTime.Year)>=2)
            {
                double YearDiscount = bill.Amount - (bill.Amount * 0.2);
                discount.Add(YearDiscount);
            }
            if (bill.CurrencyCode==CurrencyCodes.USD && bill.Amount>200)
            {
                double m = Math.Floor(bill.Amount / 200);
                double CurrencyDiscpunt = bill.Amount - ( 5 * m);
                discount.Add(CurrencyDiscpunt);
            }
            discount.Sort();
            return discount.FirstOrDefault();
        }
    }
}
