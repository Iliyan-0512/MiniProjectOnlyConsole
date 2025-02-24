﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EndersDungeon
{
    internal class Encounters
    {
        //Encounters Generic
        static Random rand = new Random();


        //Encounters
        public static void FirstEncounter()
        {
            Console.WriteLine("You throw open the door and grab a rusty metal sword while charging toward your captor");
            Console.WriteLine("He turns...");
            Console.ReadKey();
            Combat(false, "Human Roughe", 1, 4);
        }

        //Encounters tool

        public static void Combat(bool random, string name, int power, int health)
        {
            string n = "";
            int p = 0;
            int h = 0;
            if (random)
            {

            }
            else
            {
                n = name;
                p = power;
                h = health;
            }
            while (h > 0)
            {
                Console.WriteLine(n);
                Console.WriteLine(p +"/"+ h);
                Console.WriteLine("=====================");
                Console.WriteLine("| (A)ttack (D)efend");
                Console.WriteLine("| (R)un (H)eal");
                Console.WriteLine("=====================");
                Console.WriteLine("Potions:" + Program.currentPlayer.potion + "health" + Program.currentPlayer.health);
                string input = Console.ReadLine();
                if (input.ToLower() == "a" || input.ToLower() == "Attack")
                {
                    Console.WriteLine("With haste you surge forth, your sword flying in your " +
                        "hands! As you pass, the " + n + "strikes you");

                    int damage = p - Program.currentPlayer.armorValue;
                    if (damage < 0)
                    {
                        damage = 0;
                    }
                    int attack = rand.Next(0, Program.currentPlayer.waeponValue) + rand.Next(1, 4);
                    Console.WriteLine("You lose" + damage + "health and deal" + attack + "damage");
                    Program.currentPlayer.health -= damage;
                    h -= attack;
                }
                else if (input.ToLower() == "d" || input.ToLower() == "Defend")
                {
                    Console.WriteLine("As the" + n + "prepare to strike, you ready your sword in a defensive stance");

                    int damage = (p / 4) - Program.currentPlayer.armorValue;
                    if (damage < 0)
                    {
                        damage = 0;
                    }

                    int attack = rand.Next(0, Program.currentPlayer.waeponValue) / 2;
                    Console.WriteLine("You lose" + damage + "health and deal" + attack + "damage");
                    Program.currentPlayer.health -= damage;
                    h -= attack;
                }
                else if (input.ToLower() == "r" || input.ToLower() == "run")
                {
                    if (rand.Next(0, 2) == 0)
                    {
                        Console.WriteLine("As you sprint aways from the" + n + ", its strike catches" +
                            " you in the back");
                        int damage = p - Program.currentPlayer.armorValue;
                        if (damage < 0)
                        {
                            damage = 0;
                        }
                        Console.WriteLine("You lose" + damage + "health and are unable to escape");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("You use your crazy ninja moves to evade the" + n + "and you successfully escape");
                        Console.ReadKey();
                        // go to store
                    }
                }
                else if (input.ToLower() == "h" || input.ToLower() == "heal")
                {
                    if (Program.currentPlayer.potion==0)
                    {
                        Console.WriteLine("As you desperatly graps from a potion in your " +
                            "bag, all that you feel are empty glass flasks");
                        int damage = p - Program.currentPlayer.armorValue;
                        if (damage < 0)
                        {
                            damage = 0;
                        }
                        Console.WriteLine("The" +n+ "strikers you with a mighty blow and you lose" + damage+ "health!");

                    }
                    else
                    {
                        Console.WriteLine("You reach into your bag and pull out a glowing, purple," +
                            " flask. You take a long drink.");
                        int potionV = 5;
                        Console.WriteLine("You again" + potionV + "health");
                        Program.currentPlayer.health = potionV;
                        Console.WriteLine("As you were occupied, the"+n+"advanced and struck");
                        int damage=(p/2)-Program.currentPlayer.armorValue;
                        if (damage < 0)
                        {
                            damage = 0;
                        }
                        Console.WriteLine("You lose " + damage + "health");

                    }
                    Console.ReadKey();
                }
                Console.ReadKey();

            }
            Console.WriteLine();
        }
    }
}
