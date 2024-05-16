using LightHtml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodHTML
{
    public abstract class LifeNodeHooks : LightNode
    {

        
        public void CreateWithLifecycleHooks()
        {
            OnCreated();
            OnInserted();
            OnRemoved();
            OnStylesApplied();
            OnClassListApplied();
            OnTextRendered();
        }
        protected abstract void OnCreated();
        protected abstract  void OnInserted();
        protected abstract void OnRemoved();
        protected abstract void OnStylesApplied();
        protected abstract void OnClassListApplied();
        protected abstract void OnTextRendered();




    }
}
