using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrate;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrate.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, NorthwindContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = from c in context.Cars
                              join b in context.Brands on c.BrandsId equals b.Id
                              join co in context.Colors on c.ColorsId equals co.Id
                              select new CarDetailDto { BrandName = b.Brand_name, 
                                  Cars_Name = c.Cars_Name, ColorName = co.Color_name, 
                                  Daily_Price = c.Daily_Price };   
                return (List<CarDetailDto>)result;
            };
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = from car in context.Cars orderby car.BrandsId select car;
                return (List<Car>)result;
            }
           
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = from car in context.Cars orderby car.ColorsId select car;
                return (List<Car>)result;
            }
        }
    }
}
