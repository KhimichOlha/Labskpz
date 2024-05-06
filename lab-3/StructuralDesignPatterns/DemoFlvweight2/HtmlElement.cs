using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoFlvweight2
{
    public class HtmlElement
    {
        private readonly ElementStyle style; 

        public string TagName { get; set; }
        public string Text { get; set; }

        public HtmlElement(ElementStyle style, string tagName, string text = "")
        {
            this.style = style;
            TagName = tagName;
            Text = text;
        }

        public string GetHTML()
        {
            string html = $"<{TagName} style=\"font-family: {style.FontFamily}; color: {style.Color};\">";
            html += Text;
            html += $"</{TagName}>";
            return html;
        }
    }
}
