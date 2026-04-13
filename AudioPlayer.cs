using System;
using System.IO;
using System.Media;
using System.Runtime.Versioning;

namespace CybersecurityAwarenessBot
{
    [SupportedOSPlatform("windows")]
    public class AudioPlayer
    {
        public void PlayGreeting(string filePath)
        {
            try
            {
                string fullPath = Path.GetFullPath(filePath);
                Console.WriteLine("Looking for audio file at: " + fullPath);

                if (File.Exists(filePath))
                {
                    Console.WriteLine("Audio file found.");
                    SoundPlayer player = new SoundPlayer(filePath);
                    player.Load();
                    player.PlaySync();
                    Console.WriteLine("Audio played successfully.");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Audio file not found: " + fullPath);
                    Console.ResetColor();
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Unable to play audio: " + ex.Message);
                Console.ResetColor();
            }
        }
    }
}