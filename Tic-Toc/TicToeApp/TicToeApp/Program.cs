using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter name for player 1: ");
        string player1Name = Console.ReadLine();
        Console.Write("Enter name for player 2: ");
        string player2Name = Console.ReadLine();

        Player player1 = new Player(player1Name, 'X');
        Player player2 = new Player(player2Name, 'O');

        Game game = new Game(player1, player2);
        game.Play();
    }
}
