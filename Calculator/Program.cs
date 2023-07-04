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
            Console.Write("Escolha entre Somar, Subtrair, Dividir ou Multiplicar: ");
            string operation = Console.ReadLine();

            double num1, num2;

            Console.Write("Digite o primeiro número: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            double[] nums = { num1, num2 };

            switch (operation)
            {
                case ("Somar"):
                    Console.WriteLine(Sum(nums));
                    break;
                case ("Dividir"):
                    Console.WriteLine(Divide(nums));
                    break;
                case ("Subtrair"):
                    Console.WriteLine(Subtract(nums));
                    break;
                case ("Multiplicar"):
                    Console.WriteLine(Multiply(nums));
                    break;
                default:
                    Console.WriteLine("Operação Inválida!");
                    break;
            }

            Console.ReadLine();
        }

        static double Sum(double[] nums) => nums.Sum(x => x);

        static double Subtract(double[] nums) => nums.Aggregate((acc, x) => acc - x);

        static double Divide(double[] nums) => nums[0] / nums[1];

        static double Multiply(double[] nums) => nums.Aggregate((acc, x) => acc * x);
    }
}
