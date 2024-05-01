using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Artifact : InventoryDecorator
    {
        public Artifact(IInventory inventory) : base(inventory) { }
        public override void Equip()
        {
            Console.WriteLine("Equipping artifact");
            if (_inventory != null)
            {
                _inventory.Equip();

            }
               
        }
    }
}
