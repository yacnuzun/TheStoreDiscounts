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
        public int CustomerId { get; set; }
        public CardTypes Card { get; set; }
        public bool Affilation { get; set; }
        public DateTime MemberDateTime { get; set; }
        public CurrencyCodes CurrencyCode { get; set; }
    }
}
