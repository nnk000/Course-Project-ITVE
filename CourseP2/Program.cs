using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            Console.WriteLine("a=F/s=Ee    механич. напряжение, Па");
            Console.WriteLine("================");
            Console.Write("Решение будет по той формуле, значения для которой ~= 0.\nЕсли подходят обе, то берётся случайная\n");
            Console.WriteLine("================");
            //
            // Значение для проверки валидности, если F и S валидны
            int choice = 0;
            //
            // Проверка чтобы на эксепшены, ( IsValid() )
            //
            // local numF = GetNumber() or 0
            //
            Console.WriteLine("Введите F: ");
            double.TryParse(Console.ReadLine(), out double numF);
            //
            Console.WriteLine("Введите s:");
            double.TryParse(Console.ReadLine(), out double numS);
            //
            Console.WriteLine("Введите E:");
            double.TryParse(Console.ReadLine(), out double numE);
            //
            Console.WriteLine("Введите e:");
            double.TryParse(Console.ReadLine(), out double numExt);
            //
            if (numF != 0 && numS != 0)
            {
                choice = 1;
            }
            if (numE != 0 && numExt != 0)
            {
                choice = 2;
            }
            if (numF != 0 && numS != 0 && numE != 0 && numExt != 0)
            {
                Random random = new Random();
                choice = random.Next(1, 2);
            }
            //
            switch(choice)
            {
                case 0:
                    Console.WriteLine("Невозможно выполнить операцию.");
                    break;
                case 1:
                    Console.WriteLine("Механическое напряжение = " + Math.Round(numF/numS, 2) + " Па");
                    break;
                case 2:
                    Console.WriteLine("Механическое напряжение = " + Math.Round(numE*numExt, 2) + " Па");
                    break;
            }
        }
    }
}