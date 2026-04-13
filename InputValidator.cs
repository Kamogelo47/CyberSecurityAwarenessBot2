namespace CybersecurityAwarenessBot
{
    public class InputValidator
    {
        public bool IsValidInput(string? input)
        {
            return !string.IsNullOrWhiteSpace(input);
        }

        public bool IsValidName(string? input)
        {
            return !string.IsNullOrWhiteSpace(input);
        }
    }
}