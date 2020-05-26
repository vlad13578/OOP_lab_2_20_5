using System;

namespace OOP_lab_2_20_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            int[,] a = new int[n, m];
            int[] zero = new int[m];

            int k = 0;

            var rnd = new Random();

            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    a[i, j] = rnd.Next(-100, 100);
                }
            }

            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    if (a[i, j] == 0)
                    {
                        ++k;
                    }
                }
            }

            for (int i = 0; i < n; ++i)
            {
                zero[i] = 0;
            }

            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    if (a[j, i] == 0)
                    {
                        zero[i] = 1;
                        break;
                    }
                }
            }

            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    Console.Write("{0} ", a[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Кiлькiсть знайдених нульових елементiв: {0}", k);

            Console.WriteLine();

            Console.WriteLine("Номери стовпцiв, в яких є хоча б один нульовий елемент:");

            for (int i = 0; i < n; ++i)
            {
                if (zero[i] == 1)
                {
                    Console.WriteLine(i + 1);
                }
            }
        }
    }
}
