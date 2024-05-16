using LightHtml;

namespace VisitorHTML
{
    public abstract class LightNodeVisitor : LightNode
    {
        public abstract void Accept(IHtmlElementVisitor visitor);

    }
}
