using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskListByElliot
{
    class Program
    {
        static void Main(string[] args)
        {
            var quit = false;
            var tasks = new List<string>();

            //load the list from a file here 

            do
            {
                PringMenu();

                Console.Write("Select your item: ");
                string input = Console.ReadLine();
                Console.WriteLine(" ");

                //So, now we have input. Let check it against some pre-conditions

                quit = HandleInput(tasks, input);

            } while (!quit);

            // save the list on a file here
        }

        private static bool HandleInput(List<string> tasks, string input)
        {
            bool quit = false;
            if (input == "0")

            {
                quit = true;
            }

            else if (input == "1")
            {
                Console.Write("Enter your task: ");
                var newTask = Console.ReadLine();

                //Now, add the input task to the list.
                tasks.Add(newTask);


            }

            else if (input == "2")
            {
                //print the list
                //The square brackets access one index in the list.
                //It's inportant we start at 0, because list are 0 index
                Console.Clear();

                for (int i = 0; i < tasks.Count; ++i)
                {

                    Console.WriteLine($"{i + 1}. {tasks[i]}");
                }
                Console.Write("Enter any key to return to the main menu ");
                Console.ReadKey();

            }

            else
            {
                Console.WriteLine("Invalid input press any key to try again.\n");
                Console.ReadKey();
            }

            return quit;
        }

        private static void PringMenu()
        {

            //if we really want to now, we could use the refactoring toold to break this out in methods.
            //PrintMenu();
            Console.Clear();
            //First things first, print the user interface
            Console.WriteLine(" Task List");
            Console.WriteLine(" ================");

            Console.WriteLine(" ");

            Console.WriteLine(" 1. add a task");
            Console.WriteLine(" 2. Display  task");
            Console.WriteLine(" 3. Quit");
        }
    }
}
