using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceFactoryLogic
{
    public interface IDevice
    {
        public Laptop CreateLaptop();
        public Netbook CreateNetbook();
        public EBook CreateEBook();
        public Smartphone CreateSmartphone();

    }
}
