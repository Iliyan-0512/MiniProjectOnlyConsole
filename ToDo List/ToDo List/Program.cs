using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> tasks = new List<string>();
            string option = "";
            while (option != "e")
            {
                Console.WriteLine("Chose from 1-3");
                Console.WriteLine("1-Add task");
                Console.WriteLine("2-Remove task");
                Console.WriteLine("3- view current task");

                if (option == "1")
                {
                    Console.WriteLine("Enter task");
                    string AddTask = Console.ReadLine();
                    tasks.Add(AddTask);
                }
                else if (option == "2")
                {
                    int taskNumber = int.Parse(Console.ReadLine());
                    tasks.RemoveAt(taskNumber);
                }
                else if (option == "3")
                {
                    Console.WriteLine("View List");
                    foreach (string task in tasks)
                    {
                        Console.WriteLine(task);
                    }
                   
                }
               option = Console.ReadLine();
            }
        }
    }
}