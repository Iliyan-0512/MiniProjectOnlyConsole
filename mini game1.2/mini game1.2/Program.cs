using System.Linq;

Console.WriteLine("Hello");
int myHeroHealt = 100;
int myAttack = 10;
//var monster = new List<string>();-good idea
string[] monster = { "Monster", "Goblin", "Snake" };
//int enemyHealt = 100;- atribute of enemy
//int enemyAttack = 5;


while (true)
{

    //monster.Add("Monster");-add monster
    Console.WriteLine("select an option");
    Console.WriteLine("1-Attack");
    Console.WriteLine("2-heal");
    //Console.WriteLine("3-");
    string command = Console.ReadLine();

    if (command == "1")
    {
        //enemyHealt -= myAttack;
        //myHeroHealt -= enemyAttack;
        //if (enemyHealt == 0)
        //{
            //myHeroHealt += 20;
        //}
        //Console.WriteLine($"Enemy: {enemyHealt}");
        //Console.WriteLine($"Hero: {myHeroHealt}");
    }
    else if (command == "2")
    {
        //myHeroHealt += 10;
        //myHeroHealt -= enemyAttack;
        //Console.WriteLine($"Enemy: {enemyHealt}");
        //Console.WriteLine($"Hero: {myHeroHealt}");
    }



}
//if (myHeroHealt == 0)
//{
//    Console.WriteLine("You lost");
//}
//else if (enemyHealt == 0)
//{
//    Console.WriteLine("You won");
//}
