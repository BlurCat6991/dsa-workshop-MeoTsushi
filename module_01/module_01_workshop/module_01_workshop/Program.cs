using System;
using System.Security.Cryptography.X509Certificates;

namespace module_01_workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            string input_mode = " ";
            do
            {
                Console.WriteLine("Input 1 for Part 8 (Printing \"Hello Worlds!\") or 2 for Part 11 (Loop Exercises).");
                input_mode = Console.ReadLine();
            } while (input_mode != "1" && input_mode != "2");
            switch (input_mode)
            {
                case "1":
                    M01_P8();
                    break;
                case "2":
                    M01_P11();
                    break;
                default:
                    return;
            }
        }

        static void M01_P8 ()
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

            // FUNC
            static void DisplayHelloWorld()
            {
                Console.WriteLine("Hello World!");
            }
        }

        static void M01_P11 ()
        {
            Ex01();
            Ex02();
            Ex03();
            Ex04();
            Ex05();

            // FUNC
            static void Ex01 ()
            {
                // Exercise 01: Print multiplication table
                // Separated 'for' loops are required
                Console.WriteLine("EX 01: Printing multiplication table:");
                for (int i = 1; i <= 10; i++) {
                    Console.WriteLine($"1 x {i} = {i}");
                }
                for (int i = 1; i <= 10; i++) {
                    Console.WriteLine($"2 x {i} = {2 * i}");
                }
                for (int i = 1; i <= 10; i++) {
                    Console.WriteLine($"3 x {i} = {3 * i}");
                }
                for (int i = 1; i <= 10; i++) {
                    Console.WriteLine($"4 x {i} = {4 * i}");
                }
                for (int i = 1; i <= 10; i++) {
                    Console.WriteLine($"5 x {i} = {5 * i}");
                }
                for (int i = 1; i <= 10; i++) {
                    Console.WriteLine($"6 x {i} = {6 * i}");
                }
                for (int i = 1; i <= 10; i++) {
                    Console.WriteLine($"7 x {i} = {7 * i}");
                }
                for (int i = 1; i <= 10; i++) {
                    Console.WriteLine($"8 x {i} = {8 * i}");
                }
                for (int i = 1; i <= 10; i++) {
                    Console.WriteLine($"9 x {i} = {9 * i}");
                }
                for (int i = 1; i <= 10; i++) {
                    Console.WriteLine($"10 x {i} = {10 * i}");
                }
                Console.WriteLine();
            }

            static void Ex02 ()
            {
                // Exercise 02: Calculate factorial
                Console.WriteLine("EX 02: Calculating factorial");
                Console.WriteLine("Please input N");
                string input = Console.ReadLine();
                float result = Convert.ToInt32(input);
                for (int i = (int)result - 1; i > 0; i--) {
                    result *= i;
                }
                Console.WriteLine($"N! = {result}");
                Console.WriteLine();
            }

            static void Ex03 ()
            {
                // Exercise 03: List all prime numbers from 0 to 100
                // Use 'for' loop for every number - no sieving
                for (int i = 2; i <= 100; i++)
                {
                    int factors = 0;
                    for (int j = 2; j <= Math.Sqrt(i); j++)
                    {
                        if (i % j == 0)
                        {
                            factors++;
                        }
                        if (factors >= 1) break;
                    }
                    if (factors < 1)
                    {
                        Console.Write($"{i} ");
                    }
                }
                Console.WriteLine();
            }

            static void Ex04 ()
            {
                // Exercise 04: Sum of all even numbers from 1 to N
                Console.WriteLine("EX 03: Sum of even numbers");
                Console.Write("Please input N = ");
                int n = int.Parse(Console.ReadLine());
                int sum = 0;
                for (int i = 1; i <= n; i++)
                {
                    if (i % 2 == 0) sum += i;
                }
                Console.WriteLine($"The sum is {sum}");
            }

            static void Ex05 ()
            {
                // Exercise 05: Draw triangle
                Console.WriteLine("EX 04: Draw triangle");
                Console.Write("Input triangle size N (should be larger than 1) = ");
                int size = int.Parse(Console.ReadLine());
                for (int i = 1; i <= size; i++)
                {
                    for (int j = 1; j <= i; j++) {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
