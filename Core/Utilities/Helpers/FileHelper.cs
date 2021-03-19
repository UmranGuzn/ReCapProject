using Core.Utilities.Results;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Core.Utilities.Helpers
{
   public class FileHelper
    {
        public static string Add(IFormFile file)
        {
            var sourcePath = Path.GetTempFileName();
            if (file!=null)
            {
                using (var uploading=new FileStream(sourcePath, FileMode.Create))
                {
                    file.CopyTo(uploading);
                }
            }

            string filePath = FilePath(file);
            File.Move(sourcePath, filePath);
            return filePath;
        }

        public static string Update(string sourcePath,IFormFile formFile)
        {
            string result = FilePath(formFile);
           
                if (sourcePath.Length!=0)
                {
                    using (var stream=new FileStream(result,FileMode.Create))
                    {
                        formFile.CopyTo(stream);
                    }
                }

                File.Delete(sourcePath);


            return result;
        }

        public static IResult Delete(string path)
        {
            try
            {
                File.Delete(path);
            }
            catch (Exception e)
            {

                return new ErrorResult(e.Message);
            }

            return new SuccessResult();
        }

        public static string FilePath(IFormFile file)
        {
            FileInfo fI = new FileInfo(file.FileName);

            string fileExtension = fI.Extension;

          
            string path = Environment.CurrentDirectory + @"\wwwroot\Images";
            var newPath = Guid.NewGuid().ToString() + fileExtension;


            string result = $@"{path}\{newPath}";

            return result;
        }
    }
}
