using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculatorReference.CalculatorServiceClient client = new CalculatorReference.CalculatorServiceClient();
            string choice = "";
            while (choice != "5")
            {
                Console.WriteLine("\tCalculator");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                Console.WriteLine("5. Exit");
                Console.WriteLine("\tEnter your choice: ");
                choice = Console.ReadLine();
                double num1, num2;
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Enter your first number: ");
                        double.TryParse(Console.ReadLine(), out num1);
                        Console.WriteLine("Enter your second number: ");
                        double.TryParse(Console.ReadLine(), out num2);
                        Console.WriteLine(client.Add(num1, num2));
                        break;
                    case "2":
                        Console.WriteLine("Enter your first number: ");
                        double.TryParse(Console.ReadLine(), out num1);
                        Console.WriteLine("Enter your second number: ");
                        double.TryParse(Console.ReadLine(), out num2);
                        Console.WriteLine(client.Subtract(num1, num2));
                        break;
                    case "3":
                        Console.WriteLine("Enter your first number: ");
                        double.TryParse(Console.ReadLine(), out num1);
                        Console.WriteLine("Enter your second number: ");
                        double.TryParse(Console.ReadLine(), out num2);
                        Console.WriteLine(client.Multiply(num1, num2));
                        break;
                    case "4":
                        Console.WriteLine("Enter your first number: ");
                        double.TryParse(Console.ReadLine(), out num1);
                        Console.WriteLine("Enter your second number: ");
                        double.TryParse(Console.ReadLine(), out num2);
                        Console.WriteLine(client.Divide(num1, num2));
                        break;
                    default:
                        break;
                }
            }
            
        }
    }
}
