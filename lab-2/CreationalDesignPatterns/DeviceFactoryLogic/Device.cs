using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceFactoryLogic
{
    public abstract class Device
    {
        public string Brand { get; protected set; }
        public abstract string Doing();

    }
}
