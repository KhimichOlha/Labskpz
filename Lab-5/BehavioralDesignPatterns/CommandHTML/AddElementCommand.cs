using LightHtml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandHTML
{
    public class AddElementCommand : Command
    {
        private LightNode _parent;
        private LightNode _element;

        public AddElementCommand(LightNode parent, LightNode element)
        {
            _parent = parent;
            _element = element;
        }

        public override void Execute()
        {
            if (_parent is LightElementNode)
            {
                var parentElement = (LightElementNode)_parent;
                parentElement.Children.Add(_element);
            }
            else
            {
                throw new InvalidOperationException("Cannot add element to non-element node.");
            }
        }
    }
