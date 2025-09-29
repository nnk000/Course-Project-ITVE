using System;

class Program
{
    static void Main()
    {
        int arrayLength = 15;

        Console.WriteLine($"Количество элементов массива: {arrayLength}");

        int[] array = new int[arrayLength];
        Random random = new Random();

        Console.WriteLine("\nИсходный массив:");
        for (int i = 0; i < arrayLength; i++)
        {
            array[i] = random.Next(-100, 101);
            Console.Write(array[i] + " ");
        }

        Array.Sort(array);
        Array.Reverse(array);

        Console.WriteLine("\n\nМассив, упорядоченный по убыванию:");
        for (int i = 0; i < arrayLength; i++)
        {
            Console.Write(array[i] + " ");
        }

        Console.WriteLine("\n\nНажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}