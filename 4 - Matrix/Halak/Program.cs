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

            Horgasz(matrix, n, m);


        }

        static void Horgasz(int[,] matrix, int n, int m)
        {
            Console.Write("\n3. feladat: ");
            int j;
            for (int i = 0; i < n; i++)
            {
                j = 0;
                while (j < m && !(matrix[i, j] == 0))
                {
                    j++;
                }
                if (j < m)
                {
                    Console.Write(i + 1 + " ");
                }          
            }
        }

        static void Halfajtak(int[,] matrix, int n, int m)
        {
            Console.Write("\n2. feladat: ");
            int ossz;
            for (int i = 0; i < m; i++)
            {
                ossz = 0;
                for (int j = 0; j < n; j++)
                {
                    ossz += matrix[j, i];
                }
                Console.Write(ossz + " ");
            }
        }

        static void Beolvas(int[,] matrix, out int n, out int m)
        {
            string[] sor = Console.ReadLine().Split(' ');
            n = Convert.ToInt32(sor[0]);
            m = Convert.ToInt32(sor[1]);
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
