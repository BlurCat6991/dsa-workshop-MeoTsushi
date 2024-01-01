using System;

namespace module_01_workshop
{
    class Program
    {
        static void DisplayHelloWorld()
        {
            Console.WriteLine("Hello World!");
        }

        static void Main(string[] args)
        {
            // Hello world
            Console.WriteLine("Hello World!");

            // Hello world with strings
            string hello = "Hello ";
            string world = "World!";
            string result = hello + world;
            // or alternatively string result = string.Concat(hello, world);
            Console.WriteLine($"{hello}{world}");
            Console.WriteLine(result);

            // Hello world with input
            string input = " ";
            while (input != "Hello World!") {
                input = Console.ReadLine();
            }
            Console.WriteLine(input);
            
            // Hello world with function
            DisplayHelloWorld();
        }
    }
}
