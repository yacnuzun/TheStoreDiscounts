using Core.Utilities.Results;
using Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBillService
    {
        IDataResult<List<Bill>> GetAll();
        IDataResult<Bill> Get(int id);
        IResult Buy(Bill bill);
    }
}
