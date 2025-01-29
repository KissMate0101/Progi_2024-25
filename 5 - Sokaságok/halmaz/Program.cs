
using System;
using System.Collections.Generic;

namespace Halmaz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            List<int> lista = new List<int> { 4, 6, 1, 2, 2, 1, 2 };
            Console.WriteLine(lista.Count);
            Console.WriteLine("A lista 1. eleme: " + lista[0]);
            */

            // Halmaz:
            // 1. Elemeknek nincs sorrendje -> nem indexelhető
            // 2. Egyediek az elemei.
            HashSet<int> halmaz = new HashSet<int> { 4, 6, 1, 2, 2, 1, 2 };
            Console.WriteLine("Halmaz elemszáma: " + halmaz.Count);
            //Console.WriteLine("A halmaz 1. eleme: " + halmaz[0]);

            halmaz.Add(13); // { 4, 6, 1, 2, 13 }
            halmaz.Remove(6);
            Console.WriteLine("Eleme-e a 13-mas? " + halmaz.Contains(13)); // tartalmazza

            Kiir("Halmaz elemei: ", halmaz);

            Console.WriteLine();
            Console.WriteLine("--------------------------------------");
            Console.WriteLine();


            HashSet<string> halmaz1 = new HashSet<string> { "Bence", "Réka", "Máté", "Pisti", "Johanna", "Kata" };
            HashSet<string> halmaz2 = new HashSet<string> { "Máté", "Zalán", "Csaba", "Kata", "Bence" };
            Kiir("1. Verseny: ", halmaz1);
            Kiir("2. Verseny: ", halmaz2);
            Kiir("\nMindkettő: ", Metszet(halmaz1, halmaz2));

            Console.WriteLine();
            Console.WriteLine("-------------Házi feladat-------------");
            Console.WriteLine();
            Kiir("Legalább egyik verseny: ", Unio(halmaz1, halmaz2));

            Console.WriteLine();
            Console.WriteLine("--------------------------------------");
            Console.WriteLine();
            Kiir("Csak az 1. versenyen indultak: ", Kulonbseg(halmaz1, halmaz2));

            Console.WriteLine();
            Console.WriteLine("--------------------------------------");
            Console.WriteLine();
            HashSet<string> bitfarago = new HashSet<string> { "Máté", "Csaba", "Zalán" };
            Console.WriteLine("Részhalmaz-e (halmaz1): " + Reszhalmaz(bitfarago, halmaz1));
            Console.WriteLine("Részhalmaz-e (halmaz2): " + Reszhalmaz(bitfarago, halmaz2));

            Console.WriteLine();
            Console.WriteLine("--------------------------------------");
            Console.WriteLine();//Van e olyan aki mindket versenyen elindult?
            Console.WriteLine("Mindkét verseny: " + MindKet(bitfarago, halmaz1));

            Console.WriteLine();
            Console.WriteLine("--------------------------------------");
            Console.WriteLine();

            HashSet<string> metszet = new HashSet<string>(halmaz1);
            metszet.IntersectWith(halmaz2);
            Kiir("Mindkettő: ", metszet);

            Console.WriteLine();

            HashSet<string> unio = new HashSet<string>(halmaz1);
            unio.UnionWith(halmaz2);
            Kiir("Legalább egyik verseny: ", unio);

            Console.WriteLine();

            HashSet<string> kulonbseg = new HashSet<string>(halmaz1);
            kulonbseg.ExceptWith(halmaz2);
            Kiir("Csak az 1. versenyen indultak: ", kulonbseg);

            Console.WriteLine();

            Console.WriteLine("Részhalmaz-e: " + bitfarago.IsSubsetOf(halmaz1));
            Console.WriteLine("Részhalmaz-e: " + bitfarago.IsSubsetOf(halmaz2));
            Console.WriteLine("Valódi részhalmaz-e: " + bitfarago.IsProperSubsetOf(halmaz2));

            Console.WriteLine();

            Console.WriteLine("Van e közös elem: " + bitfarago.Overlaps(halmaz1));
        }
            static bool MindKet(HashSet<string> halmaz1, HashSet<string> halmaz2)
        {
            bool mindket = false;
            foreach (string elem in halmaz1)
            {
                if (halmaz2.Contains(elem))
                {
                    mindket = true;
                }
            }
            return mindket;
        }

        static bool Reszhalmaz(HashSet<string> halmaz1, HashSet<string> halmaz2)
        {
            foreach (string elem in halmaz1)
            {
                if (!halmaz2.Contains(elem))
                {
                    return false;
                }
            }
            return true;
        }

        static HashSet<string> Kulonbseg(HashSet<string> halmaz1, HashSet<string> halmaz2)
        {
            HashSet<String> kulonbseg = new HashSet<string>();
            foreach (string elem in halmaz1)
            {
                if (!halmaz2.Contains(elem))
                {
                    kulonbseg.Add(elem);
                }
            }
            return kulonbseg;
        }

        static HashSet<string> Unio(HashSet<string> v1, HashSet<string> v2)
        {
            HashSet<string> unio = new HashSet<string>(v1);
            foreach (string elem in v2)
            {
                unio.Add(elem);
            }
            return unio;

        }

            static HashSet<string> Metszet(HashSet<string> v1, HashSet<string> v2)
        {
            HashSet<string> metszet = new HashSet<string>();
            foreach (string elem in v1)
            {
                if (v2.Contains(elem))
                {
                    metszet.Add(elem);
                }
            }
            return metszet;
        }

        static void Kiir<T>(string szoveg, HashSet<T> halmaz)
        {
            Console.Write(szoveg);
            Console.Write("{ ");
            int db = 0;
            foreach (T elem in halmaz)
            {
                db++;
                if (db < halmaz.Count)
                {
                    Console.Write(elem + ", ");
                }
                else
                {
                    Console.Write(elem);
                }
            }
            Console.WriteLine(" }");
        }
    }
}
