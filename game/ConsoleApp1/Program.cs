using System.Linq;

Console.WriteLine("Hello");
int myAttack = 8;
int enemyHealt = 100;
int enemyAttack = 10;
double money = 10;
int myHeroHealt = 100;

// to do of random to choose command // for enemy

while (myHeroHealt > 0 && enemyHealt > 0)
{
    Console.WriteLine("select an option");
    Console.WriteLine("1-Attack");
    Console.WriteLine("2-heal");
    Console.WriteLine("3-block");// when press block the enemise attack but has limit one time of 2
    Console.WriteLine("4-shop");//Elf's Sword(+10 hit points)
    string command = Console.ReadLine();

    if (command == "1")
    {
        enemyHealt -= myAttack;
        myHeroHealt -= enemyAttack;
        money += 0.5;
        if (enemyHealt == 0)
        {
            myHeroHealt += 20;
        }
        Console.WriteLine($"Enemy: {enemyHealt}");
        Console.WriteLine($"Hero: {myHeroHealt}");
        Console.WriteLine($"Money: {money}");
    }
    else if (command == "2")
    {
        myHeroHealt += 15;
        myHeroHealt -= enemyAttack;
        Console.WriteLine($"Enemy: {enemyHealt}");
        Console.WriteLine($"Hero: {myHeroHealt}");
        Console.WriteLine($"Money: {money}");
    }
    else if (command == "3")//
    {

        myHeroHealt -= 0;
        Console.WriteLine($"Enemy: {enemyHealt}");
        Console.WriteLine($"Hero: {myHeroHealt}");
        Console.WriteLine($"Money: {money}");
    }
    //else if (command == "3")
    //{

    //}



}
if (myHeroHealt < 0)
{
    Console.WriteLine("You lost");
}
else if (enemyHealt < 0)
{
    Console.WriteLine("You won");
}

