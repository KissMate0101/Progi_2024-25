using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ido
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch ora = new Stopwatch(); // Példányosítás
            Console.WriteLine("Gyakoriság: " + Stopwatch.Frequency + " Hz"); // 1 sec alatt --> 10000000 tick --> 10 Mghz

            const int n = 100; 

            ora.Start();
            List<int> l = Feltolt(n);
            Kiir(l);
            ora.Stop();
            Console.WriteLine("eltel idő (lista): " + ora.ElapsedTicks);

            Console.WriteLine();
            ora.Reset();

            ora.Start();
            int[] tomb = Feltolt2(n);
            ora.Stop();
            Console.WriteLine("eltelt idő (tömb): " + ora.ElapsedTicks);
        }

        static int[] Feltolt2(int n)
        {
            int[] eredmeny = new int[n]; //n = 100
            for (int i = 0; i < n; i++)
            {
                eredmeny[i] = i + 1;
            }
            return eredmeny;
        }

        private static void Kiir(List<int> l)
        {
            foreach (var item in l)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static List<int> Feltolt(int n)
        {
            List<int> eredmeny = new List<int>();
            for (int i = 0; i < n; i++)
            {
                eredmeny.Add(i + 1);
            }
            return eredmeny;
        }
    }
}
