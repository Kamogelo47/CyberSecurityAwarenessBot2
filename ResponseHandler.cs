namespace CybersecurityAwarenessBot
{
    public class ResponseHandler
    {
        public string GetResponse(string input, string userName)
        {
            string message = input.ToLower();

            if (message.Contains("how are you"))
            {
                return $"I am doing well, {userName}, and I am ready to help you stay safe online.";
            }

            if (message.Contains("what's your purpose") || message.Contains("what is your purpose"))
            {
                return "My purpose is to raise cybersecurity awareness and teach users how to protect themselves online.";
            }

            if (message.Contains("what can i ask you about"))
            {
                return "You can ask me about password safety, phishing, safe browsing, scams, and online privacy.";
            }

            if (message.Contains("password"))
            {
                return "Use strong passwords that include uppercase letters, lowercase letters, numbers, and symbols. Avoid using personal details, and never reuse the same password across multiple accounts.";
            }

            if (message.Contains("phishing"))
            {
                return "Phishing is when attackers pretend to be trusted companies or people to steal your information. Be careful with suspicious emails, fake links, and urgent messages asking for passwords or banking details.";
            }

            if (message.Contains("safe browsing") || message.Contains("browsing"))
            {
                return "To browse safely, only visit trusted websites, look for HTTPS in the address bar, avoid clicking unknown pop-ups, and keep your browser updated.";
            }

            if (message.Contains("scam") || message.Contains("online scam"))
            {
                return "Online scams often promise prizes, urgent help, or quick money. Always verify the source before sharing personal information or making payments.";
            }

            if (message.Contains("privacy"))
            {
                return "Protect your privacy by using strong passwords, limiting the personal information you share online, and reviewing app or social media privacy settings regularly.";
            }

            if (message.Contains("thank you") || message.Contains("thanks"))
            {
                return $"You are welcome, {userName}. I am glad I could help.";
            }

            return "I didn't quite understand that. Could you rephrase? You can ask me about passwords, phishing, safe browsing, scams, or privacy.";
        }
    }
}