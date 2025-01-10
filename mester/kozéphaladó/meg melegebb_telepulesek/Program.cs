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

            //Console.WriteLine(Proba(matrix, n, m));

            //irjuk ki a számpárokat:

            //SzamP(matrix, n, m);

            int j = MasnalMelegebb(matrix, n, m);
        }    

        static void Beolvas(int[,] matrix, out int n, out int m)
        {
            string[] sor = Console.ReadLine().Split(' '); // {"3", "5"}
            n = Convert.ToInt32(sor[0]);
            m = Convert.ToInt32(sor[1]);

            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = Convert.ToInt32(s[j]);
                }
            }
        }

        /*
        static void SzamP(int[,] matrix, int n, int m)
        {

            for (int i = 1; i <= 3; i++)
            {
                for (int j = i + 1; j <= 4; j++)
                {
                    Console.Write($"({i}, {j})");
                }
            }
        }
        */

        static void SzamP(int[,] matrix, int n, int m)
        {

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{i} {j} {Melegebb(matrix, n, i, j)} \t");
                }
            }
        }

        private static int MasnalMelegebb(int[,] matrix, int n, int m)
        {
            int i = 0;
            int j = 0;
            bool megvanE = false;
            while (i < n && !(megvanE))
            {
                j = 0;
                while (i < n && !(megvanE))
                {
                    megvanE = Melegebb(matrix, m, i, j);
                    j++;
                }
                i++;
            }
            if (megvanE)
            {
                return i;
            }
            else
            {
                return -1;
            }
        }

        static bool Melegebb(int[,] matrix, int m, int i, int j)
        {
            int k = 0;
            while (k < m && !(matrix[i, k] > matrix[j, k]))
            {
                k++;
            }
            if (i >= m)
            {
                return true;
            }
            else
            {
                return false;
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
