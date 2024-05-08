using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportChainofResponsibility
{
    public class LevelThreeHandler : SupportHandler
    {
        public override void Hendl(int request)
        {
            if (request == 3)
            {
                Console.WriteLine("3 Перевірка або поповнення балансу");
            }
            else
            {
                base.Hendl(request);
            }

        }
    }
}
