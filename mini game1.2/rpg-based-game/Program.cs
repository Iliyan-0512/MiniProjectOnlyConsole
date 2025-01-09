using System;

namespace TextBasedRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Text-Based RPG!");
            Console.WriteLine("Create your character.");

            // Create a player
            Player player = new Player();

            // Game loop
            while (player.IsAlive)
            {
                Console.WriteLine("Choose your action:");
                Console.WriteLine("1. Fight");
                Console.WriteLine("2. Heal");
                Console.WriteLine("3. Quit");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        player.Fight();
                        break;
                    case "2":
                        player.Heal();
                        break;
                    case "3":
                        player.IsAlive = false;
                        Console.WriteLine("Game over.");
                        break;
                    default:
                        Console.WriteLine("Invalid input.");
                        break;
                }
            }
        }
    }

    // Player class
    class Player
    {
        public int Health { get; set; }
        public bool IsAlive { get; set; }

        public Player()
        {
            Health = 100;
            IsAlive = true;
        }

        public void Fight()
        {
            // Simulate a battle
            Console.WriteLine("You engage in a fierce battle!");
            Health -= 20;

            if (Health <= 0)
            {
                IsAlive = false;
                Console.WriteLine("You were defeated in battle.");
            }
            else
            {
                Console.WriteLine("You won the battle but took some damage.");
                Console.WriteLine($"Your health: {Health}");
            }
        }

        public void Heal()
        {
            // Simulate healing
            Console.WriteLine("You found a healing potion.");
            Health += 20;
            Console.WriteLine($"Your health: {Health}");
        }
    }
}
