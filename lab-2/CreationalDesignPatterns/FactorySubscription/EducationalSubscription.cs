using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorySubscription
{
    internal class EducationalSubscription : ISubscription
    {

        public decimal MonthlyFee { get; set; } = 110;
        public int MinSubscriptionMonths { get; set; } = 3;
        public List<string> Channels { get; set; } = new List<string>() { "1+1", "k1", "TET", "piksel", "ctb" };
    }
}
