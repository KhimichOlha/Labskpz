using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Logic
{
    public interface IShop<T> where T : class
    {
        T Get();
        
    }
}
