using LightHtml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandHTML
{
    public class RemoveElementCommand : Command
    {
        private LightNode _parent;
        private LightNode _element;

        public RemoveElementCommand(LightNode parent, LightNode element)
        {
            _parent = parent;
            _element = element;
        }

        public override void Execute()
        {
            if (_parent is LightElementNode)
            {
                var parentElement = (LightElementNode)_parent;
                parentElement.Children.Remove(_element);
            }
            else
            {
                throw new InvalidOperationException("Cannot remove element from non-element node.");
            }
        }
    }
}
