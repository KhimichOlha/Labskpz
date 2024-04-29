using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorySubscription
{
    public class ManagerCall : CreatorSubscription
    {
        public override ISubscription CreateSubscription()
        {
            return new PremiumSubscription();
        }

    }
}
