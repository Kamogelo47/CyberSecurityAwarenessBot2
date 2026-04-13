using System;
using System.Runtime.Versioning;

namespace CybersecurityAwarenessBot
{
    public class Chatbot
    {
        private readonly AudioPlayer _audioPlayer;
        private readonly UserInterface _ui;
        private readonly ResponseHandler _responseHandler;
        private readonly InputValidator _inputValidator;

        [SupportedOSPlatform("windows")]
        public Chatbot()
        {
            _audioPlayer = new AudioPlayer();
            _ui = new UserInterface();
            _responseHandler = new ResponseHandler();
            _inputValidator = new InputValidator();
        }

        [SupportedOSPlatform("windows")]
        public void Start()
        {
            Console.Title = "Cybersecurity Awareness Bot";

            _ui.ShowStartupScreen();
            _audioPlayer.PlayGreeting("Assets/welcome.wav");
            _ui.DisplayAsciiLogo();
            _ui.ShowWelcomeMessage();

            string userName = AskUserName();

            _ui.TypeText($"\nHello, {userName}! It is great to meet you.", ConsoleColor.Green);
            _ui.TypeText("I am your Cybersecurity Awareness Bot.", ConsoleColor.Green);
            _ui.TypeText("You can ask me about passwords, phishing, safe browsing, scams, and privacy.\n", ConsoleColor.Yellow);

            RunChat(userName);
        }

        private string AskUserName()
        {
            while (true)
            {
                _ui.TypeText("Please enter your name: ", ConsoleColor.White, false);
                string? input = Console.ReadLine();

                if (_inputValidator.IsValidName(input))
                {
                    return input!.Trim();
                }

                _ui.TypeText("That name is not valid. Please enter a non-empty name.", ConsoleColor.Red);
            }
        }

        private void RunChat(string userName)
        {
            bool running = true;

            while (running)
            {
                _ui.ShowDivider();
                _ui.TypeText($"{userName}, what would you like to ask?", ConsoleColor.Cyan);
                _ui.TypeText("Type 'help' to see topics or 'exit' to close the chatbot.", ConsoleColor.DarkYellow);
                _ui.TypeText("> ", ConsoleColor.White, false);

                string? input = Console.ReadLine();

                if (!_inputValidator.IsValidInput(input))
                {
                    _ui.TypeText("Input cannot be empty. Please type a question.", ConsoleColor.Red);
                    continue;
                }

                string cleanedInput = input!.Trim();

                if (cleanedInput.Equals("exit", StringComparison.OrdinalIgnoreCase))
                {
                    _ui.TypeText($"\nGoodbye, {userName}. Stay safe online!", ConsoleColor.Magenta);
                    running = false;
                    continue;
                }

                if (cleanedInput.Equals("help", StringComparison.OrdinalIgnoreCase))
                {
                    _ui.ShowHelpMenu();
                    continue;
                }

                string response = _responseHandler.GetResponse(cleanedInput, userName);
                _ui.TypeText(response, ConsoleColor.Green);
            }
        }
    }
}
