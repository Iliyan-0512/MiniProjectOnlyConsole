using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect
{
    public class Field
    {
        Player player = new Player();
        Enemy enemy = new Enemy();
        public void Start()
        {
            Console.WriteLine("Welcome");
            Console.WriteLine("PlayerName-Zoro");
        }
        public void MeetEnemy()
        {
            Console.WriteLine("An enemy appears!");

            while (player.Health > 0 && enemy.Health > 0)
            {
                Console.WriteLine("Choose your action: 1 (Attack), 2 (Heal)");
                string command = Console.ReadLine();

                if (command == "1")
                {
                    Attack();
                }
                else if (command == "2")
                {
                    Heal();
                }

                if (player.Health <= 0)
                {
                    Console.WriteLine("You have been defeated. Good game.");
                    break;
                }
                else if (enemy.Health <= 0)
                {
                    Console.WriteLine("You defeated the enemy!");
                    player.Money += 5;
                    Console.WriteLine($"You earned 5 money. Total money: {player.Money}");
                    Console.WriteLine($"Bravo! Tpu pass next level");
                    player.Level += 1;
                    player.Money += 10;
                    enemy.Level += 1;
                    enemy.Health += 10;
                    break;
                }
            }
            Console.Clear();
            Console.WriteLine($"Welcome next level");
            Wolf wolf = new Wolf();
            WildWolf wildWolf = new WildWolf();
            Random enemies = new Random();
        }

        private List<Enemy> enemiesList = new List<Enemy>
    {
        new Wolf(),
        new WildWolf() 
        // Add other enemy types here
    };




        public void CreateRandomMonster()
        {

        }

        private void Attack()
        {
            enemy.Health -= player.Attack;
            Console.WriteLine($"You attack the enemy. Enemy health: {enemy.Health}");
            if (enemy.Health > 0)
            {
                player.Health -= enemy.Attack;
                Console.WriteLine($"Enemy attacks back. Your health: {player.Health}");
            }
        }

        private void Heal()
        {
            if (player.Money >= 3)
            {
                player.Health += 10;
                player.Money -= 3;
                Console.WriteLine($"You heal yourself. Your health: {player.Health}, Money left: {player.Money}");
            }
            else
            {
                Console.WriteLine("Not enough money to heal.");
            }
        }
    }
}

