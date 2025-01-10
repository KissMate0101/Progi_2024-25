using System;
using System.Collections.Concurrent;

namespace megszamolas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 5, 7, 2, 2, 9, -1, 4, -3, 9, 3, 2, 1 };
            int n = x.Length;

            Console.WriteLine("1. Feladat");

            //a) feladat
            int prs = 0;
            for (int i = 0; i < n; i++)
            {
                if (x[i] % 2 == 0 )
                {
                    prs++;
                }
            }

            //b) feladat
            int prsszor = 1;
            for (int i = 0; i < n; i++)
            {

                if (x[i] % 2 == 0)
                {
                     prsszor *= x[i];
                }
            }
            Console.WriteLine($"    Páros számok darabja: |{prs}|");
            Console.WriteLine($"    Páros számok szorzata: |{prsszor}|");

            Console.WriteLine();

            Console.WriteLine("2. Feladat");
            
            //c) feladat
            int maxi = 0;
            int maxe = x[0];

            for (int i = 0; i < n; i++)
            {
                if (x[i] > maxe)
                {
                    maxe = x[i];
                    maxi = i;
                }
            }

            Console.WriteLine($"    max érték: |{maxe}|");
            Console.WriteLine($"    indexe: |{maxi + 1}|");

            int maxindex = n - 1, maxertek = x[n - 1];

            for (int i = n - 2; i >= n ; i--)
            {
                if (x[i] > maxertek)
                {
                    maxindex = i;
                    maxertek = x[i];
                }
            }

            Console.WriteLine();

            Console.WriteLine("3. Feladat");
            Console.WriteLine($"    bla bla bla: |{maxindex}|");
            Console.WriteLine($"    bla bla bla*2: |{maxertek}|");

            Console.ReadKey();
        }
    }
}
