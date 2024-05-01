using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class FileLoggerAdapter : Logger
    {
        private readonly IFileWriter _writer;
        public FileLoggerAdapter(IFileWriter writer)
        {
            _writer = writer;
        }
        public void LogToFile(string message)
        {
            _writer.WriteLine("[LOG] "+message);

        }
        public void ErrorToFile(string message)
        {
            _writer.WriteLine("[ERROR] " + message);

        }
        public void WarnToFile(string message)
        {
            _writer.WriteLine("[Warn] " + message);
        }
    }
}
