using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_6_4
{
    internal class Program
    {
        static int[][] Input()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите размерность массива");
                    Console.Write("n = ");
                    int n = int.Parse(Console.ReadLine());
                    int[][] a = new int[n][];
                    for (int i = 0; i < n; ++i)
                    {
                        a[i] = new int[n];
                        for (int j = 0; j < n; ++j)
                        {
                            Console.Write("a[{0},{1}]= ", i, j);
                            a[i][j] = int.Parse(Console.ReadLine());
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

        static void Print1(int[] a)
        {
            for (int i = 0; i < a.Length; ++i)
                Console.Write("{0,5} ", a[i]);
        }

        static void Print2(int[][] a)
        {
            for (int i = 0; i < a.Length; ++i, Console.WriteLine())
                for (int j = 0; j < a[i].Length; ++j)
                    Console.Write("{0,5} ", a[i][j]);
        }

        static int F(int[] a)
        {
            int el = 0;
            for (int i = 1; i < a.GetLength(0); i++)
            {
                if (a[i - 1] != a[i])
                {
                    el = i;
                    break;
                }
            }
            return el;
        }

        static void Main()
        {
            int[][] myArray = Input();
            Console.WriteLine("Исходный массив:");
            Print2(myArray);
            int[] rez = new int[myArray.Length];
            for (int i = 0; i < myArray.Length; ++i)
                rez[i] = F(myArray[i]);
            Console.WriteLine("Номера первых пар неравных элементов в каждой строке:");
            Print1(rez);
        }
    }
}
