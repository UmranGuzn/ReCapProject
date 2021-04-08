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
            //var sourcePath = Path.GetTempFileName();
            //if (file!=null)
            //{
            //    using (var uploading=new FileStream(sourcePath, FileMode.Create))
            //    {
            //        file.CopyTo(uploading);
            //    }
            //}

            //string filePath = FilePath(file);
            //File.Move(sourcePath, filePath);
            //return filePath;

            var result = newPath(file);

            var sourcePath = Path.GetTempFileName();
            using (var stream=new FileStream(sourcePath,FileMode.Create))
            {
                file.CopyTo(stream);
            }

            File.Move(sourcePath, result.newPath);

            return result.Path2;
        }

        public static string Update(string sourcePath,IFormFile formFile)
        {
            var result = newPath(formFile);
             using (var stream=new FileStream(result.newPath,FileMode.Create))
             {
                formFile.CopyTo(stream);
             }
               File.Delete(sourcePath);


            return result.Path2;
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

        public static (string newPath,string Path2) newPath(IFormFile file)
        {
            FileInfo fI = new FileInfo(file.FileName);

            string fileExtension = fI.Extension;
            var newFileName = Guid.NewGuid() + fileExtension;
          
            string path =Environment.CurrentDirectory + @"\wwwroot\Images";

            string result = $@"{path}\{newFileName}";
            

            return (result,$"\\Images\\{newFileName}");
        }
    }
}
