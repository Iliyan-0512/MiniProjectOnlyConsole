using System;
using System.Reflection.Metadata;

namespace Connect
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Field field = new Field();
            field.Start();
            field.MeetEnemy();
        }
        //Inventory: Manage player's items, potions, and other resources.
        //Item: Base class for different items (e.g., weapons, potions).
        //Weapon: Inherits from Item and adds properties like damage and durability.
        //Potion: Inherits from Item and provides healing or buffs.
        // Game: Handles the overall game flow, including starting and ending the game, and managing levels.


    }
}