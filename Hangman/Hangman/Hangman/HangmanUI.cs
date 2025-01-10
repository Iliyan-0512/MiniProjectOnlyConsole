using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    public class HangmanUI
    {
        public void DisplayWord(string wordProgress)
        {
            Console.WriteLine($"Word: {wordProgress}");
        }
        public void DisplayMessage(string message)
        {
            Console.WriteLine($"Message: {message}");
        }
        public char GetPlayerInput()
        {
            Console.Write("Enter a letter: ");
            return Console.ReadKey().KeyChar;
        }
    }
}
