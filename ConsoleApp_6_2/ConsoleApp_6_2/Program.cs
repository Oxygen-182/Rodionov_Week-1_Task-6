using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_6_2
{
    internal class Program
    {
        static double[] Input()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите размерность массива");
                    int n = int.Parse(Console.ReadLine());
                    double[] a = new double[n];
                    for (int i = 0; i < n; ++i)
                    {
                        Console.Write("a[{0}]= ", i);
                        a[i] = double.Parse(Console.ReadLine());
                    }
                    return a;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}\n\n");
                }
            }
        }

        static int f(double[] a)
        {
            int kolvo = 0;
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i - 1] % a[i] == 0)
                    kolvo++;
            }
            return kolvo;
        }

        static void Main()
        {
            double[] myArray = Input();
            Console.WriteLine("Количество пар соседних элементов, в которых предыдущий элемент кратен последующему = " + f(myArray));
        }
    }
}
