using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorySubscription
{
    public class WebSite : CreatorSubscription
    {
        public override ISubscription CreateSubscription()
        {
            return new EducationalSubscription();
        }
    }
}
