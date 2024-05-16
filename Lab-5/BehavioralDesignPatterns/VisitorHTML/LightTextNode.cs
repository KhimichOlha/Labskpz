using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorHTML
{
    public class LightTextNode : LightNodeVisitor
    {
        public string Text { get; set; }
        public LightTextNode(string text)
        {
            Text = text;
        }
        public override string OuterHTML => Text;

        public override string InnerHTML => Text;

        public override void Accept(IHtmlElementVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
