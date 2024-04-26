using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Logic
{
    public class Dollar : Money
    {
        public Dollar(int whole, int fraction) : base(whole, fraction)
        {
        }
        public override string ToString()
        {
            return $"{GetWhole()} dollars {GetFraction()} cents";

        }
    }
}
