﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportChainofResponsibility
{
    public interface IHandler
    {
        IHandler SetNext(IHandler handler);
        void Hendl(int request);

    }
}
