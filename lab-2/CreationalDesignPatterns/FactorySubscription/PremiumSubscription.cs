using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorySubscription
{
    internal class PremiumSubscription : ISubscription
    {
        public decimal MonthlyFee { get; set; } = 120;
        public int MinSubscriptionMonths { get; set; } = 3;
        public List<string> Channels { get; set; } = new List<string>() { "1+1", "k1", "TET", "H", "2+2", "HTH", "ICTV", "KVARTAL TV" };
    }
}
