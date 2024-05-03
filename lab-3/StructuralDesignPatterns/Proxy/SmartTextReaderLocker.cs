using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Proxy
{
    public class SmartTextReaderLocker : ISmartTextReader
    {
        private readonly ISmartTextReader _reader;
        private readonly Regex _regex;
        public SmartTextReaderLocker(ISmartTextReader reader, string pattern)
        {
            _reader = reader;
            _regex = new Regex(pattern);
        }

        public char[][] ReadText(string filePath)
        {
            if (_regex.IsMatch(filePath))
            {
                return _reader.ReadText(filePath);
            }
            else
            {  
                Console.WriteLine("Access denied!");
                return null;
            }
        }
    }
}
