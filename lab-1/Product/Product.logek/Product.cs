using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Logic
{
    public class Product
    {
        private DateOnly _lastdate;
        private string _name;
        private Money _price;
        private string _unitOfMeasurement;
        public Product (string name, Money price, DateOnly lastdate, string unitOfMeasurement)
        {
            _name = name;
            _price = price;
            _lastdate = lastdate;
            _unitOfMeasurement = unitOfMeasurement;
        }
        public DateOnly DateImport { get { return _lastdate; } }
        public string Name { get { return _name; } }
        public Money Price { get { return _price; } }
        public string UnitOfMeasurement {  get { return _unitOfMeasurement; } }
        public void ReducePrice(Money money) 
        {
            _price = _price - money;
           
        }
        public override string ToString()
        {
            return $"{_name} ціна {_price} за {_unitOfMeasurement}";

        }

    }
   
}
