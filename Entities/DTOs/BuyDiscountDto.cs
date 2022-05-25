using Core;
using Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{

    public class BuyDiscountDto:IDto
    {
        public int BillId { get; set; }
        public int CustomerId { get; set; }
        public int MyProperty { get; set; }
        public CardTypes CardT { get; set; }
        public bool Affilation { get; set; }
        public DateTime MemberDateTime { get; set; }
        public CurrencyCodes Currency { get; set; }
        public double Amount { get; set; }
    }
}
