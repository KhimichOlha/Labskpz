using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceFactoryLogic
{
    public class Prone : IDevice
    {
        public EBook CreateEBook()
        {
            return new EBook("Prone");
        }

        public Laptop CreateLaptop()
        {
            return new Laptop("Prone");
        }

        public Netbook CreateNetbook()
        {
            return new Netbook("Prone");
        }

        public Smartphone CreateSmartphone()
        {
            return new Smartphone("Prone");
        }
    }
}
