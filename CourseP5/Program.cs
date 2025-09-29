using System;

class Program
{
    static void Main()
    {
        double x0 = 0.1;
        double epsilon = 1e-6;
        int maxIterations = 100;

        double x = x0;

        Console.WriteLine($"{"Итерация",-10} {"x",-15} {"f(x)",-15} {"Погрешность",-15}");
        Console.WriteLine(new string('-', 55));

        for (int i = 0; i < maxIterations; i++)
        {
            double xNew = IterationFunction(x);
            double error = Math.Abs(xNew - x);

            Console.WriteLine($"{i + 1,-10} {x,-15:F8} {Function(x),-15:F8} {error,-15:E2}");

            if (error < epsilon)
            {
                return;
            }

            x = xNew;
        }

    }

    static double IterationFunction(double x)
    {
        double arg = -Math.Pow(x, 4) + 1;

        if (arg < -1) arg = -1;
        if (arg > 1) arg = 1;

        return 6 - Math.Acos(arg);
    }

    static double Function(double x)
    {
        return Math.Cos(x - 6) + Math.Pow(x, 4) - 1;
    }
}