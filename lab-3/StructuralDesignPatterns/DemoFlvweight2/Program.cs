namespace DemoFlvweight2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConvertToHTMLLightweight(ReadFile("pg1513.txt"));
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
        static  void ConvertToHTMLLightweight(string bookText)
        {
            var h1 = new HtmlElement(new ElementStyle { FontFamily = "Arial", Color = "black" }, "h1", "Заголовок книги");
            var paragraphs = new List<HtmlElement>();

            foreach (var line in bookText.Split(Environment.NewLine))
            {
                string tag = line.Length < 20 ? "h2" : char.IsWhiteSpace(line[0]) ? "blockquote" : "p";
                paragraphs.Add(new HtmlElement(new ElementStyle { FontFamily = "Times New Roman", Color = "gray" }, tag, line));
            }
            long memoryUsed = GC.GetTotalMemory(true);
            Console.WriteLine($"Дерево верстки займає приблизно {memoryUsed} байт пам'яті.");
            Console.WriteLine(h1.GetHTML());
            foreach (var paragraph in paragraphs)
            {
                Console.WriteLine(paragraph.GetHTML());
            }
        }
    }
    
}
