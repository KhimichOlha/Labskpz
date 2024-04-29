using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceFactoryLogic
{
    public class EBook : Device
    {
        public EBook(string brand)
        {
            Brand = brand;

        }
        public override string Doing()
        {
            return $"I am ebook of {Brand}";
        }
    }
}
