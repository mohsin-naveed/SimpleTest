using TextABCReader.Interfaces;

namespace TextABCReader
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string stuff)
        {
            Console.WriteLine(stuff);
        }
    }
}
