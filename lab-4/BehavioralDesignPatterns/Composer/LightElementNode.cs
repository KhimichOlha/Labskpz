using System.Text;

namespace Composer
{
    public class LightElementNode : LightNode, ISubject
    {
        private List<IObserver> observers = new List<IObserver>();
        public string TagName { get; }
        public bool IsBlock { get; }
        public bool IsSelfClosing { get; }
        public List<string> CssClasses { get; }
        public List<LightNode> Children { get; set; }
        public LightElementNode (string tagName, bool isBlock, bool isSelfClosing, List<string> cssClasses, List<LightNode> children)
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
                StringBuilder html = new StringBuilder ();
                html.Append ($"<{TagName}");
                if(CssClasses != null && CssClasses.Count>0)
                {

                    html.Append (" class=\"");
                    foreach(string item in CssClasses)
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
                    if (Children != null  )
                    {
                        foreach(var child in Children)
                        {
                            html.Append(child.OuterHTML);

                        }
                        
                    }
                    html.Append($"</{TagName}>");
                }
                return html.ToString ();

            }

        }

        public override string InnerHTML
        {
            get
            {
                StringBuilder html = new StringBuilder ();
                if (Children != null)
                {
                    foreach (var child in Children)
                    {
                        html.Append(child.OuterHTML);

                    }

                }
                return html .ToString ();

            }
        }

        public void Attach(IObserver observer)
        {
            observers.Add(observer);

        }

        public void Detach(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify(string eventType, object eventData)
        {
            foreach (var observer in observers)
            {
                observer.Update(eventType, eventData);
            }
        }
    }
}
