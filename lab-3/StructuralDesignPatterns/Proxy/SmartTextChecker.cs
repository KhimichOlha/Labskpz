using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class SmartTextChecker : ISmartTextReader
    {
        private readonly ISmartTextReader _reader;
        public SmartTextChecker(ISmartTextReader reader)
        {
            _reader = reader;
        }

        public char[][] ReadText(string filePath)
        {
            Console.WriteLine($"Opening file {filePath}");
            char[][] resault = _reader.ReadText(filePath);
            Console.WriteLine("File read successfully.");
            int totalChars = 0;

            foreach(var line in resault)
            {
                totalChars += line.Length;
                
            }
            Console.WriteLine($"Total lines: {resault.Length}, Total characters: {totalChars}");
            Console.WriteLine("Closing file.");
            return resault;
        }

    }
}
