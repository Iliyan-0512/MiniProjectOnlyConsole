using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Dictionary<string, Dictionary<string, string>> pieces = new Dictionary<string, Dictionary<string, string>>();

        for (int i = 0; i < n; i++)
        {
            string[] pieceInfo = Console.ReadLine().Split("|");
            string piece = pieceInfo[0];
            string composer = pieceInfo[1];
            string key = pieceInfo[2];
            pieces[piece] = new Dictionary<string, string> { { "composer", composer }, { "key", key } };
        }

        string command = Console.ReadLine();

        while (command != "Stop")
        {
            string[] tokens = command.Split("|");
            string action = tokens[0];

            if (action == "Add")
            {
                string piece = tokens[1];
                string composer = tokens[2];
                string key = tokens[3];

                if (pieces.ContainsKey(piece))
                {
                    Console.WriteLine($"{piece} is already in the collection!");
                }
                else
                {
                    pieces[piece] = new Dictionary<string, string> { { "composer", composer }, { "key", key } };
                    Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                }
            }
            else if (action == "Remove")
            {
                string piece = tokens[1];

                if (pieces.ContainsKey(piece))
                {
                    pieces.Remove(piece);
                    Console.WriteLine($"Successfully removed {piece}!");
                }
                else
                {
                    Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                }
            }
            else if (action == "ChangeKey")
            {
                string piece = tokens[1];
                string newKey = tokens[2];

                if (pieces.ContainsKey(piece))
                {
                    pieces[piece]["key"] = newKey;
                    Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                }
                else
                {
                    Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                }
            }

            command = Console.ReadLine();
        }

        foreach (var kvp in pieces)
        {
            string piece = kvp.Key;
            string composer = kvp.Value["composer"];
            string key = kvp.Value["key"];
            Console.WriteLine($"{piece} -> Composer: {composer}, Key: {key}");
        }
    }
}
