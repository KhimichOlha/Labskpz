using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorHTML
{
    public interface IHtmlElementVisitor
    {
        void Visit(LightElementNode lightElement);
        void Visit(LightTextNode lightTextNode);

    }
}
