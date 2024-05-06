using Composer;
using Flyweight;
using System.Globalization;

namespace FlyweightDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
           ConvertToHtml(ReadFile("pg1513.txt"));
           ConvertToHTMLLightweight(ReadFile("pg1513.txt"));
        }
        static string ConvertToHtml(string bookText)
        {
            List<LightNode> nodes = new List<LightNode>();
            string[] lins = bookText.Split(Environment.NewLine);
            nodes.Add(new LightElementNode("h1", false, false, null, new List<LightNode> { new LightTextNode(lins[0])}));
            for (int i = 0; i < lins.Length; i++) 
            {
                string line = lins[i];
                if (line.Length < 20)
                {
                    nodes.Add(new LightElementNode("h2", false, false, null, new List<LightNode> { new LightTextNode(line) }));
                }
                else if (string.IsNullOrEmpty(line) && char.IsWhiteSpace(line[0]))
                {
                    nodes.Add(new LightElementNode("blockquote", false, true, null, new List<LightNode> { new LightTextNode(line) }));
                }
                else
                {
                    nodes.Add(new LightElementNode("p", true, true, null, new List<LightNode> { new LightTextNode(line) }));
                }
            }
            LightNode root = new LightElementNode("div", true, false, null, nodes);
            long memory = GC.GetTotalMemory(true);
            Console.WriteLine($"Дерево верстки займає приблизно {memory} байт пам'яті.");
            return root.OuterHTML;
        }
        static string ReadFile(string fileName)
        {
            try
            {
                return File.ReadAllText(fileName);
            }
            catch 
            {
                Console.WriteLine("Erorr read file");
                return string.Empty;
            }
        }
        static string ConvertToHTMLLightweight(string bookText)
        {
            LightweightFactory factory = new LightweightFactory();
            

           
            List<LightNode> components = new List<LightNode>();

            string[] lines = bookText.Split(Environment.NewLine);

            components.Add(factory.GetElementNode("h1", new List<LightNode> { factory.GetTextNode(lines[0]) }));

            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];

            
                if (line.Length < 20)
                    components.Add(factory.GetElementNode("h2", new List<LightNode> { factory.GetTextNode(line) }));
         
                else if (!string.IsNullOrEmpty(line) && char.IsWhiteSpace(line[0]))
                    components.Add(factory.GetElementNode("blockquote", new List<LightNode> { factory.GetTextNode(line) }));
            
                else
                    components.Add(factory.GetElementNode("p", new List<LightNode> { factory.GetTextNode(line) }));
            }

            LightNode root = factory.GetElementNode("div", components);

            


            long memoryUsed = GC.GetTotalMemory(true);
            Console.WriteLine($"Дерево верстки займає приблизно {memoryUsed} байт пам'яті.");
            string html = root.OuterHTML;
            
            foreach (var component in components)
            {
                factory.Release(component);
            }
            return html;
        }
    }
}
