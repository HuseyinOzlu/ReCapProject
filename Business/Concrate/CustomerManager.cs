using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrate
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customers;
        public CustomerManager(ICustomerDal customers)
        {
            _customers = customers;
        }

        public IResult Add(Customers customers)
        {
            _customers.Add(customers);
            return new SuccessResult();
        }

        public IResult Delete(Customers customers)
        {
            _customers.Delete(customers);
            return new SuccessResult();
        }

        public IDataResult<List<Customers>> GetAll()
        {
            return new SuccessDataResult<List<Customers>>(_customers.GetAll());
        }

        public IResult Update(Customers customers)
        {
            _customers.Update(customers);
            return new SuccessResult();
        }
    }
}
