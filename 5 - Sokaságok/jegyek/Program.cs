using System;
using System.Collections.Generic;

namespace jegyek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> tanulok = new List<List<int>>();
            Beolvas(tanulok);

            Kiir(tanulok);

            Kiir2(tanulok);

            Atlagok(tanulok);

            Atlagok2(tanulok);

            LegjobbT(tanulok);
        }

        static void LegjobbT(List<List<int>> tanulok)
        {
            Console.WriteLine();
            Console.WriteLine("\n3. feladat: ");
            for (int i = 0; i < tanulok.Count; i++)
            {
                int maxi = 0;
                int maxe = 0;
                for (int j = 0; j < tanulok[i].Count; j++)
                {
                    if (tanulok[i][j] > maxe)
                    {
                        maxe = tanulok[i][j];
                        maxi = j;
                    }
                }
                Console.WriteLine(i + 1);
            }
        }

        static void Atlagok2(List<List<int>> tanulok)
        {
            Console.WriteLine("\n2. feladat(2): ");
            Console.Write("Átlagok: ");
            foreach (List<int> tanulo in tanulok)
            {
                int osszeg = 0;
                foreach (int jegy in tanulo)
                {
                    osszeg += jegy;
                }
                double atlagok = (double)osszeg / tanulo.Count;
                Console.Write($"{atlagok:0.00} ");
            }
        }

        static void Atlagok(List<List<int>> tanulok)
        {
            Console.WriteLine("\n2. feladat: ");
            Console.Write("Átlagok: ");
            for (int i = 0; i < tanulok.Count; i++)
            {
                int ossz = 0;
                for (int j = 0; j < tanulok[i].Count; j++)
                {
                    ossz += tanulok[i][j];
                }
                double atlag = (double)ossz / tanulok[i].Count;
                Console.Write($"{atlag:0.00} ");
            }
            Console.WriteLine();
        }

        static void Kiir2(List<List<int>> tanulok)
        {
            Console.WriteLine("\n1. feladat(2): ");
            foreach (var tanulo in tanulok)
            {
                Console.Write( ". tanuló: ");
                foreach (var jegy in tanulo)
                {
                    Console.Write(jegy + " ");
                }
                Console.WriteLine();
            }
        }

        static void Kiir(List<List<int>> tanulok)
        {
            Console.WriteLine("1. feladat: ");
            for (int i = 0; i < tanulok.Count; i++)
            {
                Console.Write(i + 1 + ". tanuló: ");
                for (int j = 0; j < tanulok[i].Count; j++)
                {
                    Console.Write(tanulok[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void Beolvas(List<List<int>> tanulok)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                List<int> jegyek = new List<int>();
                string[] sor = Console.ReadLine().Split(' ');
                foreach (string jegy in sor)
                {
                    jegyek.Add(int.Parse(jegy));
                }
                tanulok.Add(jegyek);
            }
        }
    }
}
