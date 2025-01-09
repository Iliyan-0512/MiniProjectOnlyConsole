using System.Linq;

Console.WriteLine("Hello");
int myHeroHealt = 100;
int myAttack = 10;
int enemyHealt = 100;
int enemyAttack = 5;


while (myHeroHealt > 0 && enemyHealt > 0)
{
    Console.WriteLine("select an option");
    Console.WriteLine("1-Attack");
    Console.WriteLine("2-heal");
    //Console.WriteLine("3-");
    string command = Console.ReadLine();

    if (command == "1")
    {
        enemyHealt -= myAttack;
        myHeroHealt -= enemyAttack;
        if (enemyHealt == 0)
        {
            myHeroHealt += 20;
        }
        Console.WriteLine($"Enemy: {enemyHealt}");
        Console.WriteLine($"Hero: {myHeroHealt}");
    }
    else if (command == "2")
    {
        myHeroHealt += 10;
        myHeroHealt -= enemyAttack;
        Console.WriteLine($"Enemy: {enemyHealt}");
        Console.WriteLine($"Hero: {myHeroHealt}");
    }
    


}
if (myHeroHealt == 0)
{
    Console.WriteLine("You lost");
}
else if (enemyHealt == 0)
{
    Console.WriteLine("You won");
}

