using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_6_1_1
{
    class Program
    {
        static int[] Input(out int n)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите размерность массива");
                    Console.Write("n = ");
                    n = int.Parse(Console.ReadLine());
                    int[] a = new int[n];
                    for (int i = 0; i < n; ++i)
                    {
                        Console.Write("a[{0}]= ", i);
                        a[i] = int.Parse(Console.ReadLine());
                    }
                    return a;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}\n\n");
                }
            }
        }

        static void Print(int[] a)
        {
            for (int i = 0; i < a.GetLength(0); ++i)
            {
                Console.Write("{0} ", a[i]);
            }
        }

        static void Change(int[] a)
        {
            for (int i = 0; i < a.GetLength(0); ++i)
            {
                if (i % 2 == 0)
                    Console.Write("{0} ", a[i]);
            }
        }

        static void Main()
        {
            int n;
            int[] myArray = Input(out n);
            Console.WriteLine("\nМассив:");
            Print(myArray);
            Console.WriteLine("\nЭлементы с четными индексами:");
            Change(myArray);
            Console.WriteLine("\n");
        }
    }
}
