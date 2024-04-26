using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Logic
{
    public class Basket
    {
        private readonly List<Product> _products;
        public Basket()
        {
            _products = new List<Product>();
        }
        public void Add(Product product)
        {
            _products.Add(product);

        }
        public void Remove(Product product)
        {
            _products.Remove(product);

        }
        public IEnumerable<Product> GetProducts()
        {
            return _products;
        }
    }
}
