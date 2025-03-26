using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;

namespace Epitmenyado
{
    internal class Program
    {
        struct Lakas
        {
            public string adoszam; // A lakás tulajdonosának adószáma
            public string utca;
            public string hsz;
            public char sav;
            public int terulet;
        }

        //struct Savszorzo
        //{
        //    public int a;
        //    public int b;
        //    public int c;
        //}

        // int a, b, c
        // List<int> (3 elemű)
        // struct Savszorzo (adattagok: a, b, c)
        // Dictionary<char, int>
        static void Main(string[] args)
        {
            List<Lakas> lakasok = new List<Lakas>();
            Dictionary<char, int> adok = new Dictionary<char, int>();
            Beolvas(lakasok, adok);
            F2(lakasok);
            F3(lakasok);
            Ado('A', 800, adok);
            F5(lakasok, adok);
        }

        static void F5(List<Lakas> lakasok, Dictionary<char, int> adok)
        {
            int dba = 0;
            int dbb = 0;
            int dbc = 0;

            int osszdbA = 0;
            int osszdbB = 0;
            int osszdbC = 0;
            for (int i = 0; i < lakasok.Count; i++)
            {
                if (lakasok[i].sav == 'A')
                {
                    dba++;
                    osszdbA += Ado(lakasok[i].sav, lakasok[i].terulet, adok);
                }
                else if (lakasok[i].sav == 'B')
                {
                    dbb++;
                    osszdbB += Ado(lakasok[i].sav, lakasok[i].terulet, adok);
                }
                else
                {
                    dbc++;
                    osszdbC += Ado(lakasok[i].sav, lakasok[i].terulet, adok);
                }
            }
            Console.WriteLine("5. feladat");
            Console.WriteLine($"A sávba {dba} telek esik, az adó {osszdbA} Ft.");
            Console.WriteLine($"B sávba {dbb} telek esik, az adó {osszdbB} Ft.");
            Console.WriteLine($"C sávba {dbc} telek esik, az adó {osszdbC} Ft.");
        }

        static int Ado(char sav, int alapterulet, Dictionary<char, int> adok)
        {
            int ado = adok[sav] * alapterulet;
            if (ado < 10000)
            {
                return 0;
            }
            return ado;
        }

        static void F3(List<Lakas> lakasok)
        {
            // Kiválogatás
            Console.Write("3. feladat. Egy tulajdonos adószáma: ");
            string adoszam = Console.ReadLine();
            int db = 0;
            for (int i = 0; i < lakasok.Count; i++)
            {
                if (lakasok[i].adoszam == adoszam)
                {
                    db++;
                    Console.WriteLine($"{lakasok[i].utca} utca {lakasok[i].hsz}");
                }
            }
            if (db == 0)
            {
                Console.WriteLine("Nem szerepel az adatállományban.");
            }
        }

        static void F2(List<Lakas> lakasok)
        {
            Console.WriteLine($"2. feladat. A mintában {lakasok.Count} telek szerepel.");
        }

        static void Beolvas(List<Lakas> lakasok, Dictionary<char, int> adok)
        {
            StreamReader reader = new StreamReader("utca.txt");
            string[] adatok = reader.ReadLine().Split(); // { "800", "600", "100" } 
            adok.Add('A', int.Parse(adatok[0]));
            adok.Add('B', int.Parse(adatok[1]));
            adok.Add('C', int.Parse(adatok[2]));
            while (!reader.EndOfStream)
            {
                string[] sor = reader.ReadLine().Split();
                Lakas ujlakas = new Lakas
                {
                    adoszam = sor[0],
                    utca = sor[1],
                    hsz = sor[2],
                    sav = char.Parse(sor[3]), // "C" => 'C'
                    terulet = int.Parse(sor[4])
                };
                lakasok.Add(ujlakas);
            }
            reader.Close();
        }
    }
}