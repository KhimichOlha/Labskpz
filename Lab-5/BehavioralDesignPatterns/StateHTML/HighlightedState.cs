using LightHtml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateHTML
{
    public class HighlightedState : IElementState
    {
        public string ApplyState(LightNode node)
        {
            if (node is LightElementNode)
            {
                var elementNode = (LightElementNode)node;
                return $"<{elementNode.TagName} class=\"highlighted\">";
            }
            else
            {
                throw new InvalidOperationException("Cannot apply highlighted state to non-element node.");
            }
        }
    }
}
