using System;
using System.IO;
using System.Threading;

namespace CybersecurityAwarenessBot
{
    public class UserInterface
    {
        public void ShowStartupScreen()
        {
            Console.Clear();
            ShowBorder();
            TypeText("Launching Cybersecurity Awareness Bot...", ConsoleColor.Cyan);
            Thread.Sleep(700);
            ShowBorder();
        }

        public void DisplayAsciiLogo()
        {
            string filePath = "Assets/ascii-logo.txt";

            Console.ForegroundColor = ConsoleColor.Cyan;

            if (File.Exists(filePath))
            {
                Console.WriteLine(File.ReadAllText(filePath));
            }
            else
            {
                Console.WriteLine(@"
   ██████╗██╗   ██╗██████╗ ███████╗██████╗ 
  ██╔════╝╚██╗ ██╔╝██╔══██╗██╔════╝██╔══██╗
  ██║      ╚████╔╝ ██████╔╝█████╗  ██████╔╝
  ██║       ╚██╔╝  ██╔══██╗██╔══╝  ██╔══██╗
  ╚██████╗   ██║   ██████╔╝███████╗██║  ██║
   ╚═════╝   ╚═╝   ╚═════╝ ╚══════╝╚═╝  ╚═╝

        🔒 CYBERSECURITY AWARENESS BOT 🔒
");
            }

            Console.ResetColor();
        }

        public void ShowWelcomeMessage()
        {
            ShowBorder();
            TypeText("Welcome to the Cybersecurity Awareness Bot", ConsoleColor.Yellow);
            TypeText("Learn how to stay safe online.", ConsoleColor.DarkYellow);
            ShowBorder();
        }

        public void ShowHelpMenu()
        {
            ShowDivider();
            TypeText("You can ask about the following topics:", ConsoleColor.Yellow);
            TypeText("- How are you?", ConsoleColor.White);
            TypeText("- What's your purpose?", ConsoleColor.White);
            TypeText("- What can I ask you about?", ConsoleColor.White);
            TypeText("- Password safety", ConsoleColor.White);
            TypeText("- Phishing", ConsoleColor.White);
            TypeText("- Safe browsing", ConsoleColor.White);
            TypeText("- Online scams", ConsoleColor.White);
            TypeText("- Privacy", ConsoleColor.White);
        }

        public void ShowBorder()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(new string('=', 65));
            Console.ResetColor();
        }

        public void ShowDivider()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(new string('-', 65));
            Console.ResetColor();
        }

        public void TypeText(string text, ConsoleColor color, bool newLine = true)
        {
            Console.ForegroundColor = color;

            foreach (char character in text)
            {
                Console.Write(character);
                Thread.Sleep(15);
            }

            if (newLine)
            {
                Console.WriteLine();
            }

            Console.ResetColor();
        }
    }
}