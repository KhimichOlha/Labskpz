namespace Proxy
{
    public class SmartTextReader : ISmartTextReader
    {
        public char[][] ReadText(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            char[][] resault = new char[lines.Length][];
            for (int i = 0; i< lines.Length; i++)
            {
                resault[i] = lines[i].ToCharArray();

            }
            return resault;
           
        }
        

    }
}
