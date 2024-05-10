using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class TextEditor
    {
        private TextDocument curentDocument;
        private Stack<TextDocument> history;
        public TextEditor()
        {
            history = new Stack<TextDocument>();
        }
        public void CreatDocument(string context) 
        {
            curentDocument = new TextDocument(context);
            history.Push(new TextDocument(context));

        }
        public void SaveChanges(string context)
        {
            curentDocument.Content = context;
            history.Push(new TextDocument(context));
            
        }
        public void UndoChanges()
        {
            history.Pop();
            curentDocument = history.Peek();
        }
        public void Print()
        {
            Console.WriteLine(curentDocument.Content);
        }
    }
}
