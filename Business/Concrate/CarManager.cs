using Business.Abstract;
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

        public void Add(Car car, Brand brand)
        {
            if (car.Daily_Price > 0 && brand.BrandName.Length >= 2)
            {
                _car.Add(car);
            }
            else
            {
                Console.WriteLine("Error, Car didn't added.\nPlease check BrandName(BrandName must be min. 2 charecters) and DailyPrice(DailyPrice must be more than 0)");
            }
        }

        public List<Car> GetAll()
        {
            return _car.GetAll();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetCarsByColorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
