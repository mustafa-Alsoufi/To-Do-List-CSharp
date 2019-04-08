using System;
using System.Collections.Generic;

namespace firstProject
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> tasks = new List<string>();
            // Displaying the options for the user
            Console.WriteLine("Choose one of the following options: \n");
            Console.WriteLine("1. Show tasks ");
            Console.WriteLine("2. Add task ");
            Console.WriteLine("3. Remove task ");
            Console.WriteLine("4. Exit ");

            // initilaizing the variables
            string task;
            int taskToRemove;
            // Reading the input from the user
            string input = Console.ReadLine();
            
            // if the user doesn't request to exit then keep looping
            while (input != "4")
            {
                // option one
                if (input == "1" || input == "Show tasks".ToLower())
                {
                    // if tasks are empty
                    if (tasks.Count == 0)
                        Console.WriteLine("No tasks available!");
                    // if there is at least one task in the list
                    else
                    {
                        for (int i = 0; i < tasks.Count; i++)
                        {
                            Console.Write("." + (i + 1) + " ");
                            Console.WriteLine(tasks[i]);
                        }
                    }
                }
                // option two
                else if (input == "2" || input == "add tasks".ToLower())
                {
                    Console.Write("Enter a task: ");
                    task = Console.ReadLine();
                    tasks.Add(task);
                    Console.WriteLine("Your Task Has Been Added.");
                }
                // option three
                else if (input == "3" || input == "remove tasks".ToLower())
                {
                    if (tasks.Count == 0)
                        Console.WriteLine("There is no task to remove!");
                    else
                    {
                        for (int i = 0; i < tasks.Count; i++)
                        {
                            Console.Write("." + (i + 1) + " ");
                            Console.WriteLine(tasks[i]);

                        }
                        Console.Write("Enter a task number to get removed: ");
                        taskToRemove = Convert.ToInt32(Console.ReadLine());
                        tasks.RemoveAt(taskToRemove - 1);
                    }
                }
                else if (input == "exit".ToLower())
                    break;
                else
                    Console.WriteLine("Wrong input");
                //redisplay the options to the user
                Console.WriteLine("\nChoose one of the following options: \n");
                Console.WriteLine("1. Show tasks ");
                Console.WriteLine("2. Add task ");
                Console.WriteLine("3. Remove task ");
                Console.WriteLine("4. Exit ");
                input = Console.ReadLine();

            }


        }
    }
}
