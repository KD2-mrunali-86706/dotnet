using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string value;
            do
            {
                int result;
                Console.WriteLine("Enter first number");
                 int numberFirst = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter second number");
                int numberSecond= Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter symbol +,- *,/");
                string operatorCal= Console.ReadLine();
                switch (operatorCal)
                {
                    case "+":
                        result = numberFirst + numberSecond;
                        Console.WriteLine("Addition:" + result);

                        break;
                    case "-":
                        result = numberFirst - numberSecond;
                        Console.WriteLine("Subtraction:" + result);
                        break;
                    case "*":
                        result = numberFirst * numberSecond;
                        Console.WriteLine("Multiplication:" + result);
                        break;
                    case "/":
                        result = numberFirst / numberSecond;
                        Console.WriteLine("division:" + result);
                        break;
                }
                Console.ReadLine();
                Console.Write("Do you want to continue(y/n):");
                value = Console.ReadLine();

            }
            while (true);
        }
    }
}
