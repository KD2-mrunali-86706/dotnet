using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, result = 0;
            char choice;
            bool exit = false;


            do
            {
                Console.WriteLine("\n--------- Basic Calculator-------------");
                Console.WriteLine("1. Addition (+)");
                Console.WriteLine("2. Subtraction (-)");
                Console.WriteLine("3. Multiplication (*)");
                Console.WriteLine("4. Division (/)");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");
                choice = Console.ReadKey().KeyChar;
                Console.WriteLine();

                if (choice == '5')
                {
                    exit = true;
                    Console.WriteLine("Exiting the calculator. Goodbye!");
                    break;
                }

                Console.Write("Enter the first number: ");
                while (!double.TryParse(Console.ReadLine(), out num1))
                {
                    Console.Write("Invalid input. Please enter a valid number: ");
                }

                Console.Write("Enter the second number: ");
                while (!double.TryParse(Console.ReadLine(), out num2))
                {
                    Console.Write("Invalid input. Please enter a valid number: ");
                }

                switch (choice)
                {
                    case '1':
                        result = num1 + num2;
                        Console.WriteLine($"Result: {num1} + {num2} = {result}");
                        break;

                    case '2':
                        result = num1 - num2;
                        Console.WriteLine($"Result: {num1} - {num2} = {result}");
                        break;

                    case '3':
                        result = num1 * num2;
                        Console.WriteLine($"Result: {num1} * {num2} = {result}");
                        break;

                    case '4':
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                            Console.WriteLine($"Result: {num1} / {num2} = {result}");
                        }
                        else
                        {
                            Console.WriteLine("Error: Division by zero is not allowed.");
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }

            } while (!exit);
        }
    }


}
    

