using DataAccess.Abstract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
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
                new Car{Id=1, BrandId=1, ColorId=1, DailyPrice=500, ModelYear=2019, Description="A Marka spor tipi araba"},
                new Car{Id=2, BrandId=1, ColorId=2, DailyPrice=300, ModelYear=2012, Description="A Marka aile tipi araba"},
                new Car{Id=3, BrandId=2, ColorId=2, DailyPrice=650, ModelYear=2020, Description="B Marka spor tipi araba"},
                new Car{Id=4, BrandId=2, ColorId=5, DailyPrice=780, ModelYear=2021, Description="B Marka kamyonet tipi araba"},
                new Car{Id=5, BrandId=3, ColorId=4, DailyPrice=125, ModelYear=2002, Description="E Marka transit"}
            };
        }
          public void Add(Car car)
        {
            _car.Add(car);
        } 
        
        public void Update(Car car)
        {
            throw new NotImplementedException();
        }

        public void Delete(Car car)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetById(int Id)
        {
            return _car.Where(c => c.Id == Id).ToList();
        }

       
        
        
    }
}
