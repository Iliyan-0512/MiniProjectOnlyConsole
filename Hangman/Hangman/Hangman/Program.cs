using System;

namespace Hangman
{
    public class Program
    {
        static void Main(string[] args)
        {
           HangmanGame game=new HangmanGame("programing",5);
            HangmanUI ui = new HangmanUI();
            while (!game.IsGameOver() && !game.IsGameWon())
            {
                ui.DisplayWord(game.GetWordProgress());
                char guess = ui.GetPlayerInput();
                bool correct = game.GuessLetter(guess);

                if (correct)
                    ui.DisplayMessage("\nCorrect guess!");
                else
                    ui.DisplayMessage("\nWrong guess!");

                Console.WriteLine($"Remaining attempts: {game.RemindTry}");
            }

            if (game.IsGameWon())
                ui.DisplayMessage("You won!");
            else
                ui.DisplayMessage("You lost!");
        }
    }
}