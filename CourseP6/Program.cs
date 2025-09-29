using System;

namespace SumAndProduct
{
    class Program
    {
        static long Factorial(int number)
        {
            long result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }

        static void Main(string[] args)
        {
            int nStart = 1;
            int nEnd = 5;

            double sum = 0;
            double product = 1;

            Console.WriteLine("Вычисление для n от {0} до {1}:", nStart, nEnd);
            Console.WriteLine("n\tЗначение выражения");

            for (int n = nStart; n <= nEnd; n++)
            {
                double expressionValue = ((double)n / Factorial(n)) * Math.Sin(2 / Math.Pow(3, n));

                Console.WriteLine($"{n}\t{expressionValue:F10}");

                sum += expressionValue;
                product *= expressionValue;
            }

            Console.WriteLine("\nСумма выражений: " + sum);
            Console.WriteLine("Произведение выражений: " + product);

            Console.WriteLine("Произведение (науч. нотация): " + product.ToString("E5"));
        }
    }
}