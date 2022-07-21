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
            // Arabaları şu bilgiler olacak şekilde listeleyiniz. CarName, BrandName, ColorName, DailyPrice. (İpucu : IDto oluşturup 3 tabloya join yazınız)
            {
                // Linq ex.
                var result = from c in context.Cars
                              join b in context.Brands on c.BrandsId equals b.Id
                              join co in context.Colors on c.ColorsId equals co.Id
                              select new CarDetailDto { BrandName = b.BrandName, 
                                  Cars_Name = c.Cars_Name, ColorName = co.ColorName, 
                                  Daily_Price = c.Daily_Price };   
                return (List<CarDetailDto>)result;
            };
        }
    }
}
