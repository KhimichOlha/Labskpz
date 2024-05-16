using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodHTML
{
    public class LightTextNode : LifeNodeHooks
    {
        public string Text { get; set; }
        public LightTextNode(string text)
        {
            Text = text;
        }
        public override string OuterHTML => Text;

        public override string InnerHTML => Text;

        protected override void OnClassListApplied()
        {
            
        }

        protected override void OnCreated()
        {
            Console.WriteLine("Text node created.");
        }

        protected override void OnInserted()
        {
            Console.WriteLine("Text node inserted.");
        }

        protected override void OnRemoved()
        {
            Console.WriteLine("Text node removed.");
        }

        protected override void OnStylesApplied()
        {
            
        }

        protected override void OnTextRendered()
        {
            Console.WriteLine(" Text rendered.");
        }
    }
}
