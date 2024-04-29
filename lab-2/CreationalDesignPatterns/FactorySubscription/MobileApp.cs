using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorySubscription
{
    public class MobileApp : CreatorSubscription
    {
        public override ISubscription CreateSubscription()
        {
            return new DomesticSubscription();
        }
    }
}
