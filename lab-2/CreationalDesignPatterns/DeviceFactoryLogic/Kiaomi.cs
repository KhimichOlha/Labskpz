using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceFactoryLogic
{
    public class Kiaomi : IDevice
    {
        public EBook CreateEBook()
        {
            return new EBook("Kiaomi");
        }

        public Laptop CreateLaptop()
        {
            return new Laptop("Kiaomi");
        }

        public Netbook CreateNetbook()
        {
            return new Netbook("Kiaomi");
        }

        public Smartphone CreateSmartphone()
        {
            return new Smartphone("Kiaomi");
        }
    }
}
