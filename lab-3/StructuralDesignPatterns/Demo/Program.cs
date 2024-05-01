using Adapter;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DemoAdapter();
        }
        static void DemoAdapter()
        {
            FileWriter fileWriter = new FileWriter("log.txt");
            FileLoggerAdapter fileLoggerAdapter = new FileLoggerAdapter(fileWriter);
            fileLoggerAdapter.Error("HI");
            fileLoggerAdapter.Log("How are you?");
            fileLoggerAdapter.Warn("Good");
            fileLoggerAdapter.ErrorToFile("HI");
            fileLoggerAdapter.LogToFile("How are you?");
            fileLoggerAdapter.WarnToFile("Good");

        }
    }
}
