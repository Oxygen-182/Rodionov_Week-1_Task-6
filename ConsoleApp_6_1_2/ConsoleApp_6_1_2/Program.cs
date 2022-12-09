using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_6_1_2
{
    class Program
    {
        static int[,] Input(out int n, out int m)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите размерность массива");
                    Console.Write("n = ");
                    n = int.Parse(Console.ReadLine());
                    Console.Write("m = ");
                    m = int.Parse(Console.ReadLine());
                    int[,] a = new int[n, m];
                    for (int i = 0; i < n; ++i)
                    {
                        for (int j = 0; j < m; ++j)
                        {
                            Console.Write("a[{0}][{1}]= ", i, j);
                            a[i, j] = int.Parse(Console.ReadLine());
                        }
                    }
                    return a;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}\n\n");
                }
            }
        }

        static void Print(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); ++i, Console.WriteLine())
            {
                for (int j = 0; j < a.GetLength(1); ++j)
                {
                    Console.Write("{0} ", a[i, j]);
                }
            }
        }

        static void Change(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); ++i)
            {
                for (int j = 0; j < a.GetLength(1); ++j)
                {
                    if ((i + j) % 2 == 0)
                        Console.Write("{0} ", a[i, j]);
                }
            }
        }
        static void Main()
        {
            int n, m;
            int[,] myArray = Input(out n, out m);
            Console.WriteLine("\nМассив:");
            Print(myArray);
            Console.WriteLine("\nЭлементы с четной суммой индексовы:");
            Change(myArray);
            Console.WriteLine("\n");
        }
    }
}
