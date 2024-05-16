using LightHtml;
using System.Text;

namespace TemplateMethodHTML
{
    public class LightElementNode : LifeNodeHooks
    {
        public string TagName { get; }
        public bool IsBlock { get; }
        public bool IsSelfClosing { get; }
        public List<string> CssClasses { get; }
        public List<LightNode> Children { get; set; }
        public LightElementNode(string tagName, bool isBlock, bool isSelfClosing, List<string> cssClasses, List<LightNode> children)
        {
            TagName = tagName;
            IsBlock = isBlock;
            IsSelfClosing = isSelfClosing;
            CssClasses = cssClasses;
            Children = children;

        }
        public override string OuterHTML
        {
            get
            {
                StringBuilder html = new StringBuilder();
                html.Append($"<{TagName}");
                if (CssClasses != null && CssClasses.Count > 0)
                {

                    html.Append(" class=\"");
                    foreach (string item in CssClasses)
                    {
                        html.Append(string.Join(" ", item));
                    }

                    html.Append("\"");

                }
                if (IsSelfClosing)
                {
                    html.Append(" /> ");
                }
                else
                {
                    html.Append(">");
                    if (Children != null)
                    {
                        foreach (var child in Children)
                        {
                            html.Append(child.OuterHTML);

                        }

                    }
                    html.Append($"</{TagName}>");
                }
                return html.ToString();

            }

        }

        public override string InnerHTML
        {
            get
            {
                StringBuilder html = new StringBuilder();
                if (Children != null)
                {
                    foreach (var child in Children)
                    {
                        html.Append(child.OuterHTML);

                    }

                }
                return html.ToString();

            }
        }
        

      

        protected override void OnCreated()
        {
            Console.WriteLine($"Element '{TagName}' created.");
        }

        protected override void OnInserted()
        {
            Console.WriteLine($"Element '{TagName}' inserted.");
        }

        protected override void OnRemoved()
        {
            Console.WriteLine($"Element '{TagName}' removed.");
        }

        protected override void OnStylesApplied()
        {
            Console.WriteLine($"Styles applied to element '{TagName}'.");
        }

        protected override void OnClassListApplied()
        {
            Console.WriteLine($"Class list applied to element '{TagName}'.");
        }

        protected override void OnTextRendered()
        {
            Console.WriteLine($"Element '{TagName}' text rendered.");
        }
    }
}
