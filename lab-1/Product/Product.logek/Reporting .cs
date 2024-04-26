using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Logic
{
    public class Reporting
    {
        private Warehouse _warehouse;
        public Reporting(Warehouse warehouse)
        {
            _warehouse = warehouse;

        }
        public string RegisterIncoming(Product product)
        {
            _warehouse.Products.Add(product);
            return $"Надійшов новий товар {product.Name} {product.UnitOfMeasurement} за ціною {product.Price} дата  поставки {product.DateImport.ToShortDateString()}";

        }
        public string ShipGoods(string productname, int quantity)
        {
            var productitems = _warehouse.Products.Where(p=>p.Name == productname).ToList();
            if (productitems.Count >= quantity )
            {
                foreach(var item in productitems)
                {
                    _warehouse.Products.Remove(item);

                }
                return $"Відвантажено {quantity} одиниць товару: {productname}";
            }
            else
            {
                // return $"Помилка: на складі недостатньо товару для відвантаження {quantity} одиниць товару: {productname}";
                //Fail Fast
                throw new Exception($"Помилка: на складі недостатньо товару для відвантаження {quantity} одиниць товару: {productname}");
            }

        }
        public string GenerateInventoryReport()
        {
            string report = "Звіт по інвертирезації\n";
            foreach (var item in _warehouse.Products)
            {
                report += $"Найменування: {item.Name}, Одиниця виміру: {item.UnitOfMeasurement}\n";

            }
            return report ;
        }

    }
}
