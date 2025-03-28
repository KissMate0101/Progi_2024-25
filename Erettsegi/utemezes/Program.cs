using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace utemezes
{
    internal class Program
    {
        struct Taborok
        {
            public int honap1;
            public int nap1;
            public int honap2;
            public int nap2;
            public string betujel;
            public string tabor;
        }

        static void Main(string[] args)
        {
            List<Taborok> taborok = new List<Taborok>();
            int db = Beolvas(taborok);
            Kiir(taborok);
            Console.WriteLine("\n 1. F: Ennyi tábor van: " + db);
            Zenetabor(taborok);
            Legtobbjel(taborok);
            Sorszam(taborok[0].honap1, taborok[0].nap1);
        }

        static void Sorszam(int honap, int nap)
        {
            if (true)
            {

            }
        }

        static void Legtobbjel(List<Taborok> taborok)
        {
            int maxi = 0;
            for (int i = 0; i < taborok.Count; i++)
            {
                if (taborok[i].betujel.Length > taborok[maxi].betujel.Length)
                {
                    maxi = i;
                }
            }
            Console.WriteLine(" 3. F: Legtöbb jelentező: " + taborok[maxi].tabor + " " + taborok[maxi].honap1);
        }

        static void Zenetabor(List<Taborok> taborok)
        {
            List<int> kezdesek = new List<int>();
            for (int i = 0; i < taborok.Count; i++)
            {
                if (taborok[i].tabor == "zenei")
                {
                    kezdesek.Add(taborok[i].honap1);
                    Console.WriteLine($" 2. F: Zenei tábor kezdődik a {taborok[i].honap1}. hó {taborok[i].nap1}. napján.");
                }
            }
            if (kezdesek.Count == 0)
            {
                Console.WriteLine("Nincs zenei tábor");
            }
        }

        static void Kiir(List<Taborok> taborok)
        {
            for (int i = 0; i < taborok.Count; i++)
            {
                Console.WriteLine($"" +
                    $" {taborok[i].honap1}" +
                    $" {taborok[i].nap1}" +
                    $" {taborok[i].honap2}" +
                    $" {taborok[i].nap2}" +
                    $" {taborok[i].betujel}" +
                    $" {taborok[i].tabor}");
            }
        }

        static int Beolvas(List<Taborok> taborok)
        {
            StreamReader sr = new StreamReader("taborok.txt");
            int db = 0;
            while (!sr.EndOfStream)
            {
                string[] sor = sr.ReadLine().Split('\t');
                Taborok tabor = new Taborok
                {
                    honap1 = int.Parse(sor[0]),
                    nap1 = int.Parse(sor[1]),
                    honap2 = int.Parse(sor[2]),
                    nap2 = int.Parse(sor[3]),
                    betujel = sor[4],
                    tabor = sor[5]
                };
                taborok.Add(tabor);
                db++;
            }
            sr.Close();
            return db;
        }
    }
}
