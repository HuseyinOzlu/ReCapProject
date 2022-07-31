using Business.Abstract;
using Business.Constants;
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
    public class RentalManager : IRentalsService
    {
        IRentalsDal _rental;

        public RentalManager(IRentalsDal rental)
        {
            _rental = rental;
        }

        public IResult Add(Rentals rentals)
        {
            var result = _rental.Get(r => r.CarId == rentals.CarId && (r.ReturnDate == null || r.ReturnDate > rentals.ReturnDate));
            if (result == null) {
                _rental.Add(rentals);
                return new SuccessResult();
            }
            else
            {
                return new ErrorResult(MessagesTR.CarDontDeliver);
            }

        }

        public IDataResult<List<Rentals>> GetAll()
        {
            return new SuccessDataResult<List<Rentals>>(_rental.GetAll());
        }

        public IResult Remove(Rentals rentals)
        {
            _rental.Delete(rentals);
            return new SuccessResult();
        }

        public IResult Update(Rentals rentals)
        {
            _rental.Update(rentals);
            return new SuccessResult();
        }
    }
}
