using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportChainofResponsibility
{
    public abstract class SupportHandler : IHandler
    {
        private IHandler _nexthandler;

        public virtual void Hendl(int request)
        {
            if (_nexthandler != null)
            {
                _nexthandler.Hendl(request);

            }
            
        }

        public IHandler SetNext(IHandler handler)
        {
            _nexthandler = handler;
            return handler;
        }
        
    }
}
