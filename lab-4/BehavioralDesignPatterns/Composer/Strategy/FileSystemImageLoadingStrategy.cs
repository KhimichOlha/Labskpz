using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composer.Strategy
{
    public class FileSystemImageLoadingStrategy : IImageLoadingStrategy
    {

        public byte[] LoadImage(string path)
        {
            if (File.Exists(path))
            {
                return File.ReadAllBytes(path);
            }
            else
            {
                throw new FileNotFoundException($"Файл не знайдено {path}");

            }
        }
    }
}
