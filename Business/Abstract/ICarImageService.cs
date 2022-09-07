using Core.Utilities.Results;
using Entities.Concrate;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarImageService
    {
        IDataResult<List<CarImage>> GetAll();
        IDataResult<List<CarImage>> GetByCarId(int byCarId);
        IResult Add(IFormFile formFile ,CarImage carImage);
        IResult Remove(CarImage carImage);
        IResult Update(IFormFile formFile, CarImage carImage);
    }
}
