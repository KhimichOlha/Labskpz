using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodHTML
{
    public interface ILIfeHooks
    {
        public void CreateWithLifecycleHooks();
        protected void OnCreated();
        protected void OnInserted();
        protected void OnRemoved();
        protected void OnStylesApplied();
        protected void OnClassListApplied();
        protected void OnTextRendered();




    }
}
