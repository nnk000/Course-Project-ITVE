using System;

class Program
{
    static void Main()
    {
        double b = 3;
        double c = 4;

        // Цикл WHILE
        double a_while = -5;
        double lastXWhile = 0;

        while (a_while <= 5)
        {
            lastXWhile = (18 / Math.Pow(c, 1.5)) - (a_while / ((14 / (b * b)) + a_while - 12 * Math.Pow(c, 3)));
            a_while += 0.5;
        }

        // Цикл DO-WHILE
        double a_do_while = -5;
        double lastXDoWhile = 0;

        do
        {
            lastXDoWhile = (18 / Math.Pow(c, 1.5)) - (a_do_while / ((14 / (b * b)) + a_do_while - 12 * Math.Pow(c, 3)));
            a_do_while += 0.5;
        }
        while (a_do_while <= 5);

        Console.WriteLine($"WHILE:     a = {a_while - 0.5:F1}, x = {lastXWhile:F6}");
        Console.WriteLine($"DO-WHILE:  a = {a_do_while - 0.5:F1}, x = {lastXDoWhile:F6}");
    }
}