using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LightHTML;

namespace LightHTMLLiterator
{
    public class HtmlDocumentIterator : IEnumerator<LightNode>
    {
        private Queue<LightNode> _queue;

        public HtmlDocumentIterator(LightNode root)
        {
            _queue = new Queue<LightNode>();
            _queue.Enqueue(root);
        }

        public LightNode Current => _queue.Peek();

        object IEnumerator.Current => Current;

        public void Dispose() { }

        public bool MoveNext()
        {
            if (_queue.Count == 0)
                return false;

            var current = _queue.Dequeue();
            if (current is LightElementNode)
            {
                var elementNode = current as LightElementNode;
                foreach (var child in elementNode.Children)
                {
                    _queue.Enqueue(child);
                }
            }

            return true;
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
