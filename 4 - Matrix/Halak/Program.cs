using System;

namespace Halak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, m;
            int[,] matrix = new int[70, 20];
            Beolvas(matrix, out n, out m);

            Halfajtak(matrix, n, m);
        }

        private static void Halfajtak(int[,] matrix, int n, int m)
        {
            int ossz = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {

                }
            }
        }

        static void Beolvas(int[,] matrix, out int n, out int m)
        {
            string[] sor = Console.ReadLine().Split(' ');
            n = Convert.ToInt32(sor[0]);
            m = Convert.ToInt32(sor[0]);
            for (int i = 0; i < n; i++)
            {
                sor = Console.ReadLine().Split(' ');
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = Convert.ToInt32(sor[j]);
                }
            }
        }
    }
}
