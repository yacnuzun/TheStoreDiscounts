using Core.DataAccess;
using Entities.DTOs;
using Entities.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IBillDal:IEntityRepository<Bill>
    {
        BuyDiscountDto GetAllByDiscount(int id);
    }
}