using Core.Utilities.Business;
using Core.Utilities.Results;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Helpers.FileHelpers
{
    public class FileHelperManager : IFileHelper
    {
        public IResult Delete(string filePath)
        {
            var result = CheckFileExist(filePath);
            if (!result.Success) { return new SuccessResult(); }
            return new ErrorResult("Resim silinemedi");
        }

        public IResult Update(IFormFile file, string filePath, string root)
        {
            var resultOfDelete = Delete(filePath);
            if (!resultOfDelete.Success)
            {
                return resultOfDelete;
            }
            var resultOfUpload = Upload(file, root);
            return new SuccessResult(resultOfUpload.Message);

        }

        public IResult Upload(IFormFile file, string root)
        {
            var result = BusinessRules.Run(CheckIfFileEnter(file),
                CheckIfFileExtensionValid(Path.GetExtension(file.FileName)));
            if(result != null)
            {
                return result;
            }
            string fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);

            CheckIfDirectoryExist(root);
            CreateFile(root + fileName , file);
            return new SuccessResult(fileName);
        }

        //---Rules---//

        private IResult CheckFileExist(string filePath)
        {
            if (File.Exists(filePath)) { return new SuccessResult(); }
            
            return new ErrorResult("Böyle bir dosya mevcut değil");
        }

        private IResult CheckIfFileEnter (IFormFile file)
        {
            if(file.Length > 0) { return new SuccessResult(); }
            return new ErrorResult("Dosya Girilmemiş");
        }
        private IResult CheckIfFileExtensionValid(string extension) 
        {
            if (extension == ".png" || extension == ".jpg" || extension == ".jpeg" || extension == ".webp") { return new SuccessResult(); }

            return new ErrorResult("Girdiğiniz dosya geçersizdir");
        }
        private void CheckIfDirectoryExist (string root)
        {
            if (!Directory.Exists(root)) { Directory.CreateDirectory("root"); }
        }
        private void CreateFile(string directory, IFormFile file) 
        {
            using (FileStream fileStream = File.Create(directory))
            {
                fileStream.CopyTo(fileStream);
                fileStream.Flush();
            }
        }
        
    }
}
