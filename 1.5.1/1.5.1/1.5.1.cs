using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // to search solution why became 220 but 200 no!
        Console.WriteLine("Hello");
        double myAttack = 8;
        double myHeroHealth = 100;
        double enemyHealth = 100;
        double enemyAttack = 10;
        double money = 10;
        int cooldown = 1;
        Random enemyChooser = new Random();

        while (myHeroHealth > 0 && enemyHealth > 0)
        {
            Console.WriteLine("Select an option:");
            Console.WriteLine("1-Attack");
            Console.WriteLine("2-Heal");
            Console.WriteLine("3-Block");
            Console.WriteLine("4-Shop");


            string command = Console.ReadLine();

            if (command == "1")
            {
                enemyHealth -= myAttack;
                //myHeroHealth -= enemyAttack;
                money += 3;

                if (enemyHealth <= 0)
                {
                    myHeroHealth += 20;
                }

                Console.WriteLine($"Enemy: {enemyHealth}");
                Console.WriteLine($"Hero: {myHeroHealth}");
                Console.WriteLine($"Money: {money}");
            }
            else if (command == "2")
            {
                myHeroHealth += 20;
                //myHeroHealth -= enemyAttack;
                Console.WriteLine($"Enemy: {enemyHealth}");
                Console.WriteLine($"Hero: {myHeroHealth}");
                Console.WriteLine($"Money: {money}");
                Console.WriteLine("4-Shop");
                if (myHeroHealth >= 200)
                {
                    myHeroHealth = 200;
                }

            }
            else if (command == "3")
            {
                cooldown++;
                if (cooldown > 2)
                {
                    cooldown = 1;
                    continue;
                }
                else
                {
                    myHeroHealth += 10;
                    Console.WriteLine($"Enemy: {enemyHealth}");
                    Console.WriteLine($"Hero: {myHeroHealth}");
                    Console.WriteLine($"Money: {money}");
                }
            }
            else if (command == "4")
            {
                Console.WriteLine("Choose:");
                Console.WriteLine("1-Sword: 13 money");
                Console.WriteLine("2-Armor: 10 money");
                Console.WriteLine($"You have {money}");
                string shopCommand = Console.ReadLine();

                if (shopCommand == "1" && money >= 13)
                {
                    myAttack += myAttack * 0.2;
                    money -= 13;
                    Console.WriteLine($"Your attack is: {myAttack}");
                    Console.WriteLine($"Money: {money}");
                }
                else if (shopCommand == "2" && money >= 10)
                {
                    myHeroHealth += 50;
                    money -= 10;
                    Console.WriteLine($"Health: {myHeroHealth}");
                    Console.WriteLine($"Money: {money}");
                   
                }
            }

            int randomEnemyChoice = enemyChooser.Next(1, 3);
            Console.WriteLine($"Enemy chose: {randomEnemyChoice}");
            if (randomEnemyChoice == 1)
            {
                myHeroHealth -= enemyAttack;
                Console.WriteLine($"Enemy: {enemyHealth}");
                Console.WriteLine($"Hero: {myHeroHealth}");
                Console.WriteLine($"Money: {money}");
            }
            else if (randomEnemyChoice == 2)
            {
                enemyHealth += 20;
                Console.WriteLine($"Enemy: {enemyHealth}");
                Console.WriteLine($"Hero: {myHeroHealth}");
                Console.WriteLine($"Money: {money}");
                if (enemyHealth >= 200)
                {
                    enemyHealth = 200;
                }
            }
            else if (randomEnemyChoice == 3)
            {
                enemyHealth += 20;
                Console.WriteLine($"Enemy: {enemyHealth}");
                Console.WriteLine($"Hero: {myHeroHealth}");
                Console.WriteLine($"Money: {money}");
            }
             //enemyHealth = 200;
            //}
            // Implement enemy actions based on random choice if needed

        }

        if (myHeroHealth <= 0)
        {
            Console.WriteLine("You lost");
        }
        else if (enemyHealth <= 0)
        {
            Console.WriteLine("You won");
        }
    }
}
