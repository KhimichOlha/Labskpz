using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceFactoryLogic
{
    public class Netbook : Device
    {
        public Netbook(string brand)
        {
            Brand = brand;

        }
        public override string Doing()
        {
            return $"I am netbook of {Brand}";
        }
    }
}
