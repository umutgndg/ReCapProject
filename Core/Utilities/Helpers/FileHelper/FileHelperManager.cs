using Core.Utilities.Helpers.GuidHelperr;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Core.Utilities.Helpers.FileHelper
{
    public class FileHelperManager : IFileHelper
    {
        public void Delete(string filePath)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }

        public string Update(IFormFile file, string filePath, string root)
        {
            if (File.Exists(filePath))      // Tekrar if kontrolü ile parametrede gelen adreste öyle bir dosya var mı diye kontrol ediliyor.
            {
                File.Delete(filePath);      //Varsa siliyor.
            }
            return Upload(file, root);
        }

        public string Upload(IFormFile file, string root)
        {
            if (file.Length > 0)
            {
                if (!Directory.Exists(root))    //Bool döndürür.
                {
                    Directory.CreateDirectory(root);    //Eğer dizin yoksa dizini oluşturur.
                }

                string extension = Path.GetExtension(file.FileName);    //Dosyanın uzantısını döndürür.
                string guid = GuidHelper.CreateGuid();
                string filePath = guid + extension;

                using (FileStream fileStream = File.Create(root + filePath))
                {
                    file.CopyTo(fileStream);      
                    fileStream.Flush();          
                    return filePath;
                }
            }
            return null;
        }
    }
}