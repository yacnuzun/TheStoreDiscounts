﻿using Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entity
{
    public enum CurrencyCodes
    {
        TRY,
        USD
    }
    public class Bill:IEntity
    {
        [Key]
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int Amount { get; set; }
        public CurrencyCodes CurrencyCode { get; set; }
    }
}
