using LightHtml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandHTML
{
    public class UpdateElementCommand : Command
    {
        private LightNode _element;
        private string _newText;

        public UpdateElementCommand(LightNode element, string newText)
        {
            _element = element;
            _newText = newText;
        }

        public override void Execute()
        {
            if (_element is LightTextNode)
            {
                var textNode = (LightTextNode)_element;
                textNode.Text = _newText;
            }
            else
            {
                throw new InvalidOperationException("Cannot update non-text node.");
            }
        }
    }
}
