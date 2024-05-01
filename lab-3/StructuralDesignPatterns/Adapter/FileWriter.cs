namespace Adapter

{
    
    public class FileWriter : IFileWriter
    {
        private readonly string _filePath;
        public FileWriter(string filePath)
        {
            _filePath = filePath;
        }
        public void Write(string message)
        {
            using (TextWriter textWriter = new StreamWriter(_filePath,true))
            {
                textWriter.Write(message);

            }
        }

        public void WriteLine(string message)
        {
            using (TextWriter textWriter = new StreamWriter(_filePath, true))
            {
                textWriter.WriteLine(message);

            }
        }
    }
}
