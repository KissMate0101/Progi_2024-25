using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace rendezes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Stopwatch ora = new Stopwatch();

            //List<int> lista = new List<int> { 5, 3, 8, 5, 2 }; // 2, 3, 5, 5, 8
            List<int> lista = Feltolt(10000);
            //Console.Write("Eredeti lista: ");
            //Kiir(lista);

            Console.WriteLine();

            List<int> b = new List<int>(lista);
            ora.Start();
            lista.Sort();
            ora.Stop();
            long idosort = ora.ElapsedTicks;
            //Console.Write("Rendezett lista (.Sort() - al)");
            //Kiir(lista);

            Console.WriteLine();
            ora.Reset();

            ora.Start();
            MinRendez(lista);
            ora.Stop();
            long mindrendez = ora.ElapsedTicks;
            //Console.Write("Rendezett lista (minimum kiválasztassál): ");
            //Kiir(lista);

            Console.WriteLine("\nSort ideje: " + idosort);
            Console.WriteLine("MIndrendez ideje: " + mindrendez);
            ora.Reset();

            List<int> c = new List<int>(lista);
            ora.Start();
            Buborekos(c);
            ora.Stop();
            long Buborekosrendezes = ora.ElapsedTicks;
            Console.Write("Buborékos rendetés: " +  Buborekosrendezes);
            //Kiir(c);

            Console.WriteLine();
        }

        static void Buborekos(List<int> lista)
        {
            int n = lista.Count;
            for (int i = 0; i < n; i++)
            {
                bool csere = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (lista[j] > lista[j + 1])
                    {
                        Csere(lista, i, j + 1);
                        csere = true;
                    }
                }
                if (!csere) return;
            }
        }

        static List<int> Feltolt(int n)
        {
            Random r = new Random();
            List<int> eredmény = new List<int>();
            for (int i = 0; i < n; i++)
            {
                eredmény.Add(r.Next(1, 101));
            }
            return eredmény;
        }

        static void Kiir(List<int> lista)
        {
            Console.WriteLine();
            foreach (int item in lista)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static void MinRendez(List<int> lista)
        {
            for (int i = 0; i < lista.Count - 1; i++)
            {
                int mini = i;
                for (int j = mini + 1; j < lista.Count; j++)
                {
                    if (lista[j] < lista[mini])
                    {
                        mini = j;
                    }
                }
                Csere(lista, i, mini);
            }
        }

        static void Csere(List<int> lista, int i, int j)
        {
            //int seged = lista[i];
            //lista[i] = lista[j];
            //lista[j] = seged;
            (lista[j], lista[i]) = (lista[i], lista[j]);
        }
    }
}
