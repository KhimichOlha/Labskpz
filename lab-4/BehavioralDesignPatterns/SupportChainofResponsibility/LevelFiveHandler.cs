using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportChainofResponsibility
{
    public class LevelFiveHandler : SupportHandler 
    {
        public override void Hendl(int request)
        {
            if (request == 5)
            {
                Console.WriteLine("5 ваш баланс поповнено");
            }
            else
            {
                base.Hendl(request);
            }

        }
    }
}
