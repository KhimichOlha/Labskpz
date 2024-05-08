using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportChainofResponsibility
{
    public class LevelFourHandler : SupportHandler
    {
        public override void Hendl(int request)
        {
            if (request == 4)
            {
                Console.WriteLine("4 ваш баланс складає 100 грн");
            }
            else
            {
                base.Hendl(request);
            }

        }
    }
}
