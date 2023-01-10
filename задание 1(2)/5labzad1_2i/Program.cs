using System;
using System.Runtime.InteropServices;

namespace Example
{
    class Program
    {
        static void Print(int[] a)
        {
            for (int j = 0; j<a.Length; j++)
            {
                Console.Write($"{a[j]} ");
            }
            Console.WriteLine();
        }
        static void Main()
        {
            Console.Write("Введите n = ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < a.Length; ++i)
            {
                Console.Write($"a[{i}]= ");
                a[i] = int.Parse(Console.ReadLine());
            }
            int sum = a.Sum() / a.Length;
            Console.WriteLine($"Среднее арифметическое исходного массива: {sum}");
            Print(a);
            int max = a[0];
            int bufer = 0;
            int indexmax = 0;
            for (int i = 0; i < a.Length; ++i)
            {
                if (a[i] > max)
                {
                    max = a[i];
                    indexmax = i;
                }
            }
            a[1] = bufer;
            a[1] = max;
            a[indexmax] = bufer;
            for (int i = indexmax; i < a.Length; ++i)
            {
                a[i] = 0;
            }
            sum = a.Sum() / a.Length;
            Console.WriteLine($"Среднее арифметическое измененного массива: {sum}");
            Print(a);
        }
    }
}
