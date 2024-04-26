using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Logic
{
    public class Warehouse
    {

        private readonly IList<Product> _products;

       
        public Warehouse()
        {
            _products = new List<Product>();

        }

        //Program to Interfaces not Implementations
        public IList<Product> Products { get { return _products; } }
        

    }
}
