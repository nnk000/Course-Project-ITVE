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
            bool killProgram = false;
            // Parse круче Convert, Change my mind...
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
                    Console.Write("\nНеправильно, выключение пк через 10 секунд");
                    //System.Diagnostics.Process.Start("Shutdown", "-s -t 10");
                    for (int i = 0; i < 10; i++)
                    {
                        Thread.Sleep(1000);
                        Console.Write(".");
                    }
                    Console.WriteLine("\nШутка! Вызов функции закомменчен.");
                    Environment.Exit(1); // Другого способа выхода из программы кажись нет
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
                        // Практически само 2 строки вставило, хотя иногда выбешивает когда нужно вписать новую переменную
                        // а оно автокомплитит в случаюную функцию, Notepad++ onelove
                        hasSolution = true;
                        solution = numX;
                    }
                }
            }
            else
            {
                if (numB == 0)
                {
                    if (numC == 0) // Чё за бред я уже пишу
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
