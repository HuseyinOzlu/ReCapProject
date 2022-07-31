using Core.Utilities.Results;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IDataResult<List<Customers>> GetAll();
        IResult Add(Customers customers);
        IResult Update(Customers customers);
        IResult Delete(Customers customers);
    }
}
