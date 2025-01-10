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
            Beolvas(matrix,out n,out m);

            int max = Maximum(matrix, n, m);
            //Console.WriteLine(VanEMax(max, n, m, matrix, 0)); // false
            //Console.WriteLine(VanEMax(max, n, m, matrix, 1)); // true
            //Console.WriteLine(VanEMax(max, n, m, matrix, 2)); // true

            int[] melegek = Kivalogatas(matrix, n, m, out int db);

            Kiir(melegek, db);
        }

        static int[] Kivalogatas(int[,] matrix, int n, int m, out int db)
        {
            int max = Maximum(matrix, n, m);
            int[] melegek = new int[1000];
            db = 0;
            for (int i = 0; i < n; i++)
            {
                if (VanEMax(max, n, m, matrix, i))
                {
                    melegek[db] = i;
                    db++;
                }
            }
            return melegek;
        }

        static void Kiir(int[] melegek, int db)
        {
            Console.Write(db + " ");
            for (int i = 0; i < db; i++)
            {
                Console.Write(melegek[i] + 1 + " ");
            }
        }

        static bool VanEMax(int max, int n, int m, int[,] matrix, int i)
        {
            int j = 0;
            while (j < m && !(matrix[i, j] == max))
            {
                j++;
            }
            return j < m;
        }

        static int Maximum(int[,] matrix, int n, int m)
        {
            int maxe = matrix[0, 0];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i, j] > maxe)
                    {
                        maxe = matrix[i, j];
                    }
                }
            }
            return maxe;
        }

        static void Beolvas(int[,] matrix,out int n,out int m)
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
    }
}
