using System.Runtime.Versioning;

namespace CybersecurityAwarenessBot
{
    internal class Program
    {
        [SupportedOSPlatform("windows")]
        static void Main(string[] args)
        {
            Chatbot bot = new Chatbot();
            bot.Start();
        }
    }
}