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
                        Console.WriteLine(CalcOperations.Sum(nums));
                        break;
                    case ("/"):
                        Console.WriteLine(CalcOperations.Divide(nums));
                        break;
                    case ("-"):
                        Console.WriteLine(CalcOperations.Subtract(nums));
                        break;
                    case ("*"):
                        Console.WriteLine(CalcOperations.Multiply(nums));
                        break;
                    default:
                        Console.WriteLine("Operação Inválida!");
                        break;
                }

                Console.ReadLine();
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
      
        }
    }
}
