using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace VisitorHTML
{
    public class VisibilityChecker : IHtmlElementVisitor
    {
        public void Visit(LightElementNode lightElement)
        {
            if (lightElement.CssClasses.Contains("hidden")|| lightElement.CssClasses.Contains("invisible"))
            {
                Console.WriteLine($"Element '{lightElement.TagName}' is hidden.");
            }
            else
            {
                Console.WriteLine($"Element '{lightElement.TagName}' is visible.");
            }
            foreach(var child in lightElement.Children)
            {
                if(child is LightElementNode)
                {
                    ((LightElementNode)child).Accept(this);
                }
            }
        }

        public void Visit(LightTextNode lightTextNode)
        {
            Console.WriteLine("Text node is visible.");
        }
    }
}
