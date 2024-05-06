using Composer;

namespace Flyweight
{
    public class LightweightFactory
    {
        private Stack<LightNode> textNodePool = new Stack<LightNode>();
        private Stack<LightNode> elementNodePool = new Stack<LightNode>();

        public LightNode GetTextNode(string text)
        {
            if (textNodePool.Count > 0)
            {
                var node = textNodePool.Pop() as LightTextNode;
                node.Text = text;
                return node;
            }
            return new LightTextNode(text);
        }

        public LightNode GetElementNode(string tagName, List<LightNode> children)
        {
            if (elementNodePool.Count > 0)
            {
                var node = elementNodePool.Pop() as LightElementNode;
                node.Children = children;
                return node;
            }
            return new LightElementNode(tagName,false, false, null, children);
        }

        public void Release(LightNode component)
        {
            if (component is LightTextNode)
            {
                textNodePool.Push(component);
            }
            else if (component is LightElementNode)
            {
                elementNodePool.Push(component);
            }
        }
    }
}
