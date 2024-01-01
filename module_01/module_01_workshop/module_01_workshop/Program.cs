using System;

namespace module_01_workshop
{
    class Program
    {
        static void hello_world()
        {
            Console.WriteLine("Hello World!");
        }

        static void Main(string[] args)
        {
            // Hello world
            Console.WriteLine("Hello World!");

            // Hello world with variables
            string hello = "Hello ";
            string world = "World!";
            string result = hello + world;
            Console.WriteLine(result);

            // Hello world with input
            string input = " ";
            while (input != "Hello World!") {
                input = Console.ReadLine();
            }
            Console.WriteLine(input);
            
            // Hello world with function
            hello_world();
        }
    }
}
