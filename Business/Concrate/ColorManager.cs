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
    public class ColorManager : IColorService
    {
        IColorDal _color;

        public ColorManager(IColorDal color)
        {
            _color = color;
        }

        public IResult Add(Color color)
        {
            _color.Add(color);
            return new SuccessResult();
        }

        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_color.GetAll(),MessagesTR.ColorListed);
        }

        public IResult Remove(Color color)
        {
            _color.Delete(color);
            return new SuccessResult(MessagesTR.ColorRemoved);
        }

        public IResult Update(Color color)
        {
            _color.Update(color);
            return new SuccessResult(MessagesTR.ColorUpdated);
        }
    }
}
