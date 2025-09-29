using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите четыре числа a, b, c, d (c и d не равны нулю одновременно):");
            // Parse круче Convert, Change my mind
            int numA = CheckForInt(Console.ReadLine());
            int numB = CheckForInt(Console.ReadLine());
            int numC = CheckForInt(Console.ReadLine());
            int numD = CheckForInt(Console.ReadLine());
            if (numC == 0 && numD == 0)
            {
                Console.WriteLine("c и d не могут быть нулями одновременно, ахтунг и эксепшн, завершение работы.");
                return;
            }
            // local function checkForInt( var )
            static int CheckForInt( string inputStr )
            {
                if (int.TryParse(inputStr, out int ResultInt))
                {
                    return ResultInt;
                }
                else;
                {
                    Environment.Exit(1);
                }
                return 0;
            }
            Console.WriteLine("Вывод:");
            bool hasSolution = false;
            int? solution = null;
            // (ax + b) : (cx + d) = 0
            if (numA != 0)
            {
                if ((-numB) % numA == 0)
                {
                    int numX = -numB / numA;
                    //
                    if (numC*numX+numD != 0)
                    { 
                        hasSolution = true;
                        solution = numX;
                    }
                }
            }
            else
            {
                if (numB == 0)
                {
                    if (numC == 0)
                    {
                        Console.WriteLine("INF");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("INF");
                        return;
                    }
                }
                else
                {

                }
            }
            if (hasSolution)
            {
                Console.WriteLine(solution);
            }
            else
            {
                Console.WriteLine("NO");
            }
            return;
        }
    }
}
