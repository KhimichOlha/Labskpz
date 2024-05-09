using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composer.Strategy
{
    public interface IImageLoadingStrategy
    {
        byte[] LoadImage(string path);
    }
}
