using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Logic
{
    //Інверсія залежностей
    public class ShopReport : IShop<Reporting>
    {
        public Reporting Get()
        {
           var warehouse = new Warehouse();
           return new Reporting(warehouse);
        }
    }
}
