using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceFactoryLogic
{
    public class Laptop : Device
    {
        public Laptop(string brand)
        {
            Brand = brand;

        }
        public override string Doing()
        {
            return $"I am {Brand}. I give opotunites of development";
        }
    }
}
