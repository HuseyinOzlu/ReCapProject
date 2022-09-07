using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Helpers.FileHelpers;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrate;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrate
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;
        IFileHelper _fileHelper;

        public CarImageManager(ICarImageDal carImageDal, IFileHelper fileHelper)
        {
            _carImageDal = carImageDal;
            _fileHelper = fileHelper;
        }
        [ValidationAspect(typeof(CarImageValidator))]
        public IResult Add(IFormFile formFile, CarImage carImage)
        {
            var result = BusinessRules.Run(CheckIfCarImageLimitExceded(carImage.Car_Id));
            if (result != null) { return result; }
            var resultUpload = _fileHelper.Upload(formFile, PathConstant.imagePath);
            if (!resultUpload.Success) { return resultUpload; }
            carImage.Path_Image = resultUpload.Message;
            carImage.Car_Date = DateTime.Now;

            _carImageDal.Add(carImage);
            return new SuccessResult(MessagesTR.CarImageAdded);
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            var result = _carImageDal.GetAll();
            return new SuccessDataResult<List<CarImage>>(result, MessagesTR.CarImageListed);
        }

        public IDataResult<List<CarImage>> GetByCarId(int CarId)
        {
            var result = _carImageDal.GetByCarId(CarId);
            return new SuccessDataResult<List<CarImage>>(result, MessagesTR.CarImageListedByCarId);
        }

        public IResult Remove(CarImage carImage)
        {
            var resultOfDelete = _carImageDal.Get(c => c.Id == carImage.Id);
            var result = _fileHelper.Delete(PathConstant.imagePath + resultOfDelete.Path_Image);
            if (!result.Success) { return result; }
            return new SuccessResult(MessagesTR.SuccessImageDeleted);
            return result;
        }

        public IResult Update(IFormFile formFile, CarImage carImage)
        {
            var result = _fileHelper.Update(formFile, PathConstant.imagePath + carImage.Path_Image, PathConstant.imagePath);
            if(!result.Success) { return result; }
            
            var resultUpdated = _carImageDal.Get(c => c.Path_Image == carImage.Path_Image);

            carImage.Id = resultUpdated.Id;
            carImage.Car_Id = resultUpdated.Car_Id;
            carImage.Car_Date = resultUpdated.Car_Date;
            carImage.Path_Image = resultUpdated.Path_Image;

            _carImageDal.Update(carImage);
            return new SuccessResult();
        }

        //Business Rules

        private IResult CheckIfCarImageLimitExceded(int carId)
        {
            var result = _carImageDal.GetAll(c => c.Car_Id == carId).Count();

            if (result >= 5) { return new ErrorResult(MessagesTR.CarImageLimited); }
            return new SuccessResult();

        }
        private IResult CheckIfImageExist(int carId)
        {
            var result = _carImageDal.GetAll(c=>c.Car_Id == carId).Count;
            if(result > 0) { return new SuccessResult(); }
            return new ErrorResult(MessagesTR.CarImageNotExist);
        }
        
        private IDataResult<List<CarImage>> GetCarDefaultImage(int id)
        {
         List<CarImage> carImages = new List<CarImage>();
            carImages.Add(new CarImage
            {
                Car_Id = id,
                Car_Date = DateTime.Now,
                Path_Image = "wwwroot\\Upload\\Images\\Default_Car_Image.png"
            });
            return new SuccessDataResult<List<CarImage>>(carImages);
        }
    }
}
