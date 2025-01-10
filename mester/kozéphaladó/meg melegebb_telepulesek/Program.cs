using System;
using System.Diagnostics.CodeAnalysis;

namespace meleg_telepulesek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, m;
            int[,] matrix = new int[1000, 1000];
            Beolvas(matrix, out n, out m);

            // van e benne 18 nal nagyobb homerseklet?
           ;
            Console.WriteLine(Proba(matrix, n, m));
        }

        static void Beolvas(int[,] matrix, out int n, out int m)
        {
            string[] sor = Console.ReadLine().Split(' ');
            n = Convert.ToInt32(sor[0]);
            m = Convert.ToInt32(sor[1]);

            for (int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();
                sor = s.Split(' ');
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = Convert.ToInt32(sor[j]);
                }
            }
        }

        static int Proba(int[,] matrix, int n, int m)
        {
            bool megvanE = false;
            int i = 0;
            int j = 0;
            while (i < n && !(megvanE))
            {  
                j = 0;
                while (i < m && !(megvanE))
                {
                    if (matrix[i, j] > 18)
                    {
                        megvanE = true;
                    }
                    j++;
                }
                i++;
            }

            Console.WriteLine($"{i}{j}");
            if (megvanE)
            {
                return matrix[i - 1, j - 1];
            }
            else
            {
                return -1;
            }
        }
    }
}
