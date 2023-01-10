using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace Example
{
    class Program
    {
        static void Print(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"{a[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        static void Main()
        {
            Random random = new Random();
            Console.Write("Введите n: ");
            int n = int.Parse(Console.ReadLine());
            int[,] a = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = random.Next(15);
                }
            }
            Console.WriteLine("Исходный массив:");
            Print(a);
            for (int i = 0; i < n; i++)
            {
                int c = 0;
                for (int j = 0; j < n-1; j++)
                {
                    if (a[j, i] > a[j+1,i])
                    {
                        c = c+1;
                    }
                }
                if (c == n-1)
                {
                    Console.WriteLine("Столбцы - убывающая последовательность:");
                    for (int j = 0; j < n; j++)
                    {
                        Console.WriteLine($"{a[j,i]}");
                    }
                }
            }
        }
    }
}
