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
            if (file.Length > 0)
            {
                using (var uploading=new FileStream(sourcePath, FileMode.Create))
                {
                    file.CopyTo(uploading);
                }
            }

            var result = newPath(file);
            File.Move(sourcePath, result);
            return result;
        }

        public static string Update(string sourcePath,IFormFile formFile)
        {
            var result = newPath(formFile);
           
                if (sourcePath.Length>0)
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

        public static string newPath(IFormFile file)
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
