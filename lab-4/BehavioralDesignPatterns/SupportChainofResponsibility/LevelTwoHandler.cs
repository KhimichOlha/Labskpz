﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportChainofResponsibility
{
    public class LevelTwoHandler :SupportHandler
    {
        public override void Hendl(int request)
        {
            if (request == 2)
            {
                Console.WriteLine("2 інформація про ваш баланс або тариф");
            }
            else
            {
                base.Hendl(request);
            }

        }
    }
}
