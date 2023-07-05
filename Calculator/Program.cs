using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Escolha entre +, -, / ou *: ");
                string operation = Console.ReadLine();

                double num1, num2;

                Console.Write("Digite o primeiro número: ");
                num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Digite o segundo número: ");
                num2 = Convert.ToInt32(Console.ReadLine());
                if (num2 == 0 && operation == "/") {
                    Console.WriteLine("Cannot divide by zero");
                    Console.ReadLine();
                    return;
                }

                double[] nums = { num1, num2 };

                switch (operation)
                {
                    case ("+"):
                        Console.WriteLine(Sum(nums));
                        break;
                    case ("/"):
                        Console.WriteLine(Divide(nums));
                        break;
                    case ("-"):
                        Console.WriteLine(Subtract(nums));
                        break;
                    case ("*"):
                        Console.WriteLine(Multiply(nums));
                        break;
                    default:
                        Console.WriteLine("Operação Inválida!");
                        break;
                }

                Console.ReadLine();
            }
            /*catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }*/ // Commented because doubles divided by double 0 return infinite and catch was useless.
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }

           
        }

        static double Sum(double[] nums) => nums.Sum(x => x);

        static double Subtract(double[] nums) => nums.Aggregate((acc, x) => acc - x);

        static double Divide(double[] nums) => nums.Aggregate((acc, x) => acc / x);

        static double Multiply(double[] nums) => nums.Aggregate((acc, x) => acc * x);
    }
}
