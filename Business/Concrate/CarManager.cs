using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Utilities.Results;
using Core.Aspects.Autofac.Validation;
using DataAccess.Abstract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Business.Concrate
{
    public class CarManager : ICarService
    {
        ICarDal _car;

        public CarManager(ICarDal car)
        {
            _car = car;
        }
        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car car)
        {
            _car.Add(car);

            return new SuccessResult(MessagesTR.CarAdded);
        }

        public IResult Delete(Car car)
        {
            return new SuccessResult(MessagesTR.CarDeleted);
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_car.GetAll(), MessagesTR.CarListed);
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>>(MessagesTR.CarListedByBrand);
        }

        public IDataResult<List<Car>> GetCarsByColorId(int id)
        {
            return new SuccessDataResult<List<Car>>(_car.GetCarsByColorId(id),MessagesTR.CarListedByColor);
        }

        public IResult Update(Car car)
        {
            _car.Update(car);
            return new SuccessResult(MessagesTR.CarUpdated);
        }
    }
}
