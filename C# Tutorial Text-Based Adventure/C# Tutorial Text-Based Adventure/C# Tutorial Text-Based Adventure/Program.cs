using System;

namespace EndersDungeon
{
    internal class Program
    {
        public static Player currentPlayer = new Player();
        //public static Encounters encounters = new Encounters();
        static void Main(string[] args)
        {
            Start();
            Encounters.FirstEncounter();
        }
        static void Start()
        {
            Console.WriteLine("Ender's Dungeon");
            Console.WriteLine("Name");
            currentPlayer.name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("You awake in a cold, stone, dark room. Yoi feel dazed and having trouble remembering");
            Console.WriteLine("anything about your past.");
            if (currentPlayer.name=="")
            {
                Console.WriteLine("You cant even remember your own name...");
            }
            else
            {
                Console.WriteLine(" You know your name is " + currentPlayer.name);
            }
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("You grope around in the darkness until you find a door handle. You feel some resistance");
            Console.WriteLine("you turn the handle, but the rusty lock breaks with little effort. You see your captor");
            Console.WriteLine("standing with his back to you outside the door");

        }
    }
}