using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Weapon : InventoryDecorator
    {
        public Weapon(IInventory inventory) : base(inventory) { }
        public override void Equip()
        {
            Console.WriteLine("Equipping weapon");
            if (_inventory != null)
            {
                _inventory.Equip();
            }
        }
        
    }
}
