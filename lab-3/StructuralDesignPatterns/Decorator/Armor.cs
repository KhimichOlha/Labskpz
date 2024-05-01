using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Armor : InventoryDecorator
    {
        public Armor(IInventory inventory) : base(inventory) { }
        public override void Equip()
        {
            Console.WriteLine("Equipping armor");
            if (_inventory != null)
            {
                _inventory.Equip();
            }
                
        }
    }
}
