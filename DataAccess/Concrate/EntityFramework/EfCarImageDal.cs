using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrate.EntityFramework
{
    public class EfCarImageDal :EfEntityRepositoryBase<CarImage, NorthwindContext>, ICarImageDal
    {
      
        public List<CarImage> GetByCarId(int carId)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = from image in context.CarImage orderby image.Car_Id select image;
                return (List<CarImage>)result;
            }
        }
    }
}
