using System;

namespace Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[,] matrix = { 
            //    { 8, 3, 21, 4 },
            //    { 1, -5, 7, 13 },
            //    { 3, 3, 10, -1 } 
            //    };

            //Console.WriteLine(matrix[1, 2]); //2. sor 3. eleme
            //Console.WriteLine($"Elemek száma: {matrix.Length}");
            //Console.WriteLine($"Sorok száma: {matrix.GetLength(0)}"); // 1. dimenzió (oszlop)
            //Console.WriteLine($"Oszlopok száma: {matrix.GetLength(1)}"); // 2. dimenzió (sor)

            //Console.WriteLine();

            //Console.WriteLine("1.feladat: ");
            //Console.WriteLine();

            //int n = matrix.GetLength(0);
            //int m = matrix.GetLength(1);
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        if (j == matrix.GetLength(1) - 1 && i == matrix.GetLength(0) - 1)
            //        {
            //        Console.Write(matrix[i, j]);
            //        }
            //        else
            //        {
            //        Console.Write(matrix[i, j] + ", ");
            //        }
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine();

            //int osszeg = 0;
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        osszeg += matrix[i, j];
            //    }
            //}
            //Console.WriteLine("2.feladat: " + osszeg);
            //Console.WriteLine();

            //int maxi = 0;
            //int maxj = 0;
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        if (matrix[i, j] > matrix[maxi, maxj])
            //        {
            //            maxi = i;
            //            maxj = j;
            //        }
            //    }
            //}
            //Console.WriteLine($"3.feladat: {maxi + 1}, {maxj + 1}");
            //Console.WriteLine();

            //int[] t = { 5, 7, -3, 2 };
            //int maxh = 0;
            //for (int i = 1; i < t.Length; i++)
            //{
            //    if (t[i] > t[maxh])
            //    {
            //        maxh = i;
            //    }
            //}
            //Console.WriteLine("4.feladat: " + maxh + 1);
            //Console.WriteLine();

            //Console.WriteLine("5.feladat (a): ");

            //for (int i = 0; i < n; i++)
            //{
            //    int sorossz = 0;
            //    for (int j = 0; j < m; j++)
            //    {
            //        sorossz += matrix[i, j];
            //    }
            //    Console.Write(sorossz + " ");
            //}
            //Console.WriteLine();



            int n, m;
            int[,] matrix = new int[1000, 1000];

            Beolvas(matrix, out n, out m);
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
