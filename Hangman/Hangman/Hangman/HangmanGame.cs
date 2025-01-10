using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
     class HangmanGame
    {
        public string SecretsWord { get; set; }
        private HashSet<char> GuessedLetters;
        public int RemindTry { get; set; }
        public List<char> WrongLetters { get; set; }

        public HangmanGame(string secretWord, int attetion) 
        {
            SecretsWord = secretWord.ToLower();
            GuessedLetters = new HashSet<char>();
            RemindTry = attetion;
            WrongLetters = new List<char>();
        }
        public bool GuessLetter(char letter)
        {
            if (GuessedLetters.Contains(letter)|| WrongLetters.Contains(letter))
            {
                return false;
            }
            if (SecretsWord.Contains(letter))
            {
                return true;
            }
            else
            {
                WrongLetters.Add(letter);
                RemindTry--;
                return false;
            }

        }
        public string GetWordProgress()
        {
            return string.Concat(SecretsWord.Select(c => GuessedLetters.Contains(c) ? c : '_'));
        }

        public bool IsGameWon() => !GetWordProgress().Contains('_');
        public bool IsGameOver() => RemindTry <= 0;
    }
}
