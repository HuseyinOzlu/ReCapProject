using DataAccess.Abstract;
using Entities.Concrate;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrate.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;

        public InMemoryCarDal()
        {
            _car = new List<Car>
            {
                new Car{Id=1, Daily_Price=500, Model_Year=2019, Description="A Marka spor tipi araba"},
                new Car{Id=2, Daily_Price=300, Model_Year=2012, Description="A Marka aile tipi araba"},
                new Car{Id=3, Daily_Price=650, Model_Year=2020, Description="B Marka spor tipi araba"},
                new Car{Id=4, Daily_Price=780, Model_Year=2021, Description="B Marka kamyonet tipi araba"},
                new Car{Id=5, Daily_Price=125, Model_Year=2002, Description="E Marka transit"}
            };
        }
          public void Add(Car car)
        {
            _car.Add(car);
        } 
        
        public void Update(Car car)
        {
            Car carToUpdate = _car.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Model_Year = car.Model_Year; 
            carToUpdate.Daily_Price = car.Daily_Price;
            carToUpdate.Description = car.Description; 
            carToUpdate.BrandsId = car.BrandsId;
            carToUpdate.ColorsId = car.ColorsId;
        }

        public void Delete(Car car)
        {
            Car carToDelete = _car.SingleOrDefault(c => c.Id == car.Id);
            _car.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetById(int Id)
        {
            return _car.Where(c => c.Id == Id).ToList();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }
    }
}
