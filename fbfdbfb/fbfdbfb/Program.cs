using System.Linq;

Console.WriteLine("Hello");
int myHeroHealth = 100;
int myAttack = 10;
int enemyHealth = 100;
int enemyAttack = 5;


while (myHeroHealth > 0 && enemyHealth > 0)
{
    Console.WriteLine("select an option");
    Console.WriteLine("1-Attack");
    Console.WriteLine("2-heal");
    //Console.WriteLine("3-");
    string command = Console.ReadLine();

    if (command == "1")
    {
        enemyHealth -= myAttack;
        myHeroHealth -= enemyAttack;
        if (enemyHealth == 0)
        {
            myHeroHealth += 20;
        }
        Console.WriteLine($"Enemy: {enemyHealth}");
        Console.WriteLine($"Hero: {myHeroHealth}");
    }
    else if (command == "2")
    {
        myHeroHealth += 10;
        myHeroHealth -= enemyAttack;
        Console.WriteLine($"Enemy: {enemyHealth}");
        Console.WriteLine($"Hero: {myHeroHealth}");
    }



}
if (myHeroHealth == 0)
{
    Console.WriteLine("You lost");
}
else if (enemyHealth == 0)
{
    Console.WriteLine("You won");
}

