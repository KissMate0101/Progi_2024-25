using System;
using System.Collections.Generic;

namespace listak_listaja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> gyunolcsok = new List<string> { "alma",   "avokádó",  "mangó"};
            List<string> zoldsegek = new List<string> {  "zeller", "karalábé", "retek", "répa" };

            List<List<string>> etelek = new List<List<string>> {gyunolcsok, zoldsegek};

            // irjuk ki a retket!

            Console.WriteLine("1. feladat: ");
            Console.WriteLine($"2. sor, 3. eleme: {etelek[1][2]}");
            Console.WriteLine();

            Console.Write("Zöldségek: ");
            Kiir(etelek[1]);

            // irjuk ki az eteleket!

            Console.Write("Ételek: ");
            Kiir(etelek);
        }

        static void Kiir(List<List<string>> etelek)
        {
            Console.WriteLine("3. feladat:");
            for (int i = 0; i < etelek.Count; i++)
            {
                for (int j = 0; j < etelek[i].Count; j++)
                {
                    Console.Write(etelek[i][j]);
                }
            }
        }

        static void Kiir(List<string> lista)
        {
            Console.WriteLine("2. feladat: ");
            foreach (string elem in lista)
            {
                Console.Write(elem + " ");
            }
            Console.WriteLine();
        }
    }
}
