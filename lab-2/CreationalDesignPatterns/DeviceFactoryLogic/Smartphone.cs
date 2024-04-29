using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceFactoryLogic
{
    public class Smartphone : Device
    {
        public Smartphone(string brand)
        {
            Brand = brand;

        }
        public override string Doing()
        {
            return $"I am {Brand}. I call";
        }
    }

}
