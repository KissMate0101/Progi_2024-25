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

            //Atlagok(tanulok);

            //Atlagok2(tanulok);

            LegjobbT(tanulok);
            List<double> atlag = Atlagok2(tanulok);
        }

        private static void LegjobbT(List<List<int>> tanulok)
        {
            Console.WriteLine("\n3. feladat: ");
            Console.Write("Maxi elem: ");
            List<double> atlag = Atlagok2(tanulok);
            int maxe = 0;
            int maxi = 0;
            for (int i = 0; i < tanulok.Count; i++)
            {
                if (atlag[i] > maxe)
                {
                    maxe = (int)atlag[i];
                    maxi = i;
                }
            }
            Console.Write(maxi + 1);
        }

        static List<double> Atlagok2(List<List<int>> tanulok)
        {
            Console.WriteLine("\n2. feladat: ");
            Console.Write("Átlagok: ");
            List<double> atlag = new List<double>();
            foreach (List<int> tanulo in tanulok)
            {
                int osszeg = 0;
                foreach (int jegy in tanulo)
                {
                    osszeg += jegy;
                }
                double atlagok = (double)osszeg / tanulo.Count;
                atlag.Add(atlagok);
                Console.Write($"{atlagok:0.00} ");
            }
            return atlag;
        }

        //static void Atlagok(List<List<int>> tanulok)
        //{
        //    Console.WriteLine("\n2. feladat: ");
        //    Console.Write("Átlagok: ");
        //    for (int i = 0; i < tanulok.Count; i++)
        //    {
        //        int ossz = 0;
        //        for (int j = 0; j < tanulok[i].Count; j++)
        //        {
        //            ossz += tanulok[i][j];
        //        }
        //        double atlag = (double)ossz / tanulok[i].Count;
        //        Console.Write($"{atlag:0.00} ");
        //    }
        //    Console.WriteLine();
        //}

        static void Kiir2(List<List<int>> tanulok)
        {
            Console.WriteLine("\n1. feladat: ");
            int db = 0;
            foreach (var tanulo in tanulok)
            {
                Console.Write(db + ". tanuló: ");
                foreach (var jegy in tanulo)
                {
                    Console.Write(jegy + " ");
                }
                db++;
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
