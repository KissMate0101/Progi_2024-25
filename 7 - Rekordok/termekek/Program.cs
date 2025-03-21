
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;

namespace Termekek
{
    internal class Program
    {
        struct Termek // Product
        {
            public string nev; // name
            public int ar; // prince
            public bool elelmiszerE; // isFood
        }

        static void Main(string[] args)
        {
            List<Termek> termekek = new List<Termek>(); // products
            Beolvas(termekek);
            Kiir(termekek);

            Osszegzes(termekek);

            Legdragabb(termekek);

            List<string> elelmiszerek = CsakElelmiszer(termekek);
            Kiir(elelmiszerek);

            Console.WriteLine();
            Console.WriteLine("\nDrágább, mint a szomszédai: " + Draga(termekek));

            Rendez(termekek);
            Console.WriteLine();
            Kiir(termekek);
        }

        static void Rendez(List<Termek> termekek)
        {
            for (int i = 0; i < termekek.Count; i++)
            {
                int mini = i;
                for (int j = mini; j < termekek.Count; j++)
                {
                    if (termekek[i].ar > termekek[mini].ar)
                    {
                        mini = j;
                    }
                }
                Csere(termekek, i, mini);
            }
        }

        static void Csere(List<Termek> termekek, int i, int mini)
        {
            (termekek[mini], termekek[i]) = (termekek[i], termekek[mini]);
        }

        static string Draga(List<Termek> termekek)
        {
            int i = 1;
            while (i < termekek.Count && !(termekek[i].ar > termekek[i - 1].ar && termekek[i].ar > termekek[i + 1].ar))
            {
                i++;
            }
            if (i < termekek.Count)
            {
                return termekek[i].nev;
            }
            else
            {
                return "-";
            }
        }

        static void Kiir(List<string> elelmiszerek)
        {
            Console.WriteLine();
            for (int i = 0; i < elelmiszerek.Count; i++)
            {
                Console.Write(elelmiszerek[i] + ", ");
            }
        }

        static List<string> CsakElelmiszer(List<Termek> termekek)
        {
            List<string> elelmiszerek = new List<string>();
            for (int i = 0; i < termekek.Count; i++)
            {
                if (termekek[i].elelmiszerE)
                {
                    elelmiszerek.Add(termekek[i].nev);
                }
            }
            return elelmiszerek;
        }

        static Termek Legdragabb(List<Termek> termekek)
        {
            int maxi = 0;
            Termek maxe = termekek[0];
            for (int i = 0; i < termekek.Count; i++)
            {
                if (termekek[i].ar > termekek[maxi].ar)
                {
                    maxi = i ;
                    maxe = termekek[i];
                }
            }
            Console.WriteLine($"\nA legdrágább termék: {maxe.nev} - {maxe.ar}Ft, {maxi}. elem");
            return maxe;
        }

        static int Osszegzes(List<Termek> termekek)
        {
            int ossz2 = 0;
            foreach (Termek termek in termekek)
            {
                ossz2 += termek.ar;
            }
            Console.WriteLine("\nAz árak összege(foreach): " + ossz2 + " Ft");

            int ossz = 0;
            for (int i = 0; i < termekek.Count; i++)
            {
                ossz += termekek[i].ar;
            }
            Console.WriteLine("Az árak összege(for): " + ossz + " Ft");
            return ossz;
        }

        static void Kiir(List<Termek> termekek)
        {
            for (int i = 0; i < termekek.Count; i++)
            {
                //string tipus;
                //if (termekek[i].elelmiszerE)
                //{
                //    tipus = "élelmiszer";
                //}
                //else
                //{
                //    tipus = "tárgy";
                //}
                string tipus = termekek[i].elelmiszerE ? "élelmiszer" : "tárgy";
                Console.WriteLine($"{termekek[i].nev}: {termekek[i].ar} Ft ({tipus})");
            }
        }

        static void Beolvas(List<Termek> termekek)
        {
            StreamReader sr = new StreamReader("be.txt");
            while (!sr.EndOfStream)
            {
                string[] sor = sr.ReadLine().Split(';');
                Termek termek = new Termek
                {
                    nev = sor[0],
                    ar = int.Parse(sor[1]),
                    elelmiszerE = int.Parse(sor[2]) == 1
                };
                termekek.Add(termek);
            }
            sr.Close();
        }
    }
}
