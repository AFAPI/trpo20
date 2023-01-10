using System;
using System.Runtime.InteropServices;

namespace Example
{
    class Program
    {
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
            Console.WriteLine($"Разность максимального и минимального элементов: {a.Max()-a.Min()}");
        }
    }
}
