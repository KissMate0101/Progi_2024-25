using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace repter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nevek = {"Kovács Anna", "Nagy Péter", "Szabó Éva", "Tóth Márk",
                              "Kiss Júlia", "Molnár Tamás", "Farkas Dóra", "Horváth István",
                              "Varga Krisztina", "Simon Balázs", "Lukács Zoltán", "Takács Emese" };
            double[] tomegek = { 22.3, 12, 7.5, 18.44, 35, 28, 14.12, 8, 16.9, 5.8, 30, 24 };

            int n = tomegek.Length;

            // 1.) minimum kivákasztás

            int i;
            int mini = 0;
            for (i = 1; i < n; i++)
            {
                if (tomegek[i] < tomegek[mini])
                {
                    mini = i;
                }
            }
            Console.WriteLine("1. feladat " + nevek[mini]);

            // 2.) keresés tétel = Eldöntés + kiválasztás

            i = 0;

            while (i < n && !(tomegek[i] > 30))
            {
                i++;
            }
            if (i < n)
            {
                Console.WriteLine("2. " + nevek[i]);
            }
            else
            {
                Console.WriteLine("2. Nincs 30-nál nehezebb!");
            }

            // NaN --> Not a Number
            
            double osszeg = 0;
            int db = 0;
            for (i = 0; i < n; i++)
            {
                if (tomegek[i] < 20)
                {
                    osszeg += tomegek[i];
                    db++;
                }
                
            }
            double atlag = osszeg / db;
            Console.WriteLine($"3. {atlag:0.00} kg");

            if (db == 0)
            {
                atlag = osszeg / db;
                Console.WriteLine($"3. az átlag: {atlag}");
            }

            // Van e 5-nél kisebb vagy egyenlő szám?

            i = 0;
            while (i < n && !(5 >= tomegek[i]))
            {
                i++;

            }
            if (i < n)
            {
                Console.WriteLine($"4. Nem igaz ...");
            }
            else
            {
                Console.WriteLine($"4. Igaz ...");
            }

            int nevdb = 0;
            for (i = 0; i < n; i++)
            {
                if (nevek[i].Length > 10)
                {
                    nevdb++;
                }
            }
            Console.WriteLine($"5. Utasok neve hosszabb 10 karakternél: {nevdb}");

            int utaskg = 0;
            for (i = 0; i < n-1; i++)
            {
                if (tomegek[i] > tomegek[i+1])
                {
                    utaskg++;
                }
            }
            Console.WriteLine($"6. Ennyi utasnak volt könnyebb a csomgaja az előtte felszálónál: {utaskg}");

            double dora = 14.12;
            int doradb = 0;
            for (i = 0; i < n; i++)
            {
                if (tomegek[i] < dora)
                {
                    doradb++;
                }
            }
            Console.WriteLine($"7. Ennyi utasnak volt könnyebb a csomgagja Farkas Dóránál: {doradb}");

            int maxi = 1;
            for (i = 1; i < n; i++)
            {
                if (tomegek[i] > tomegek[maxi] && tomegek[i] > 9 && tomegek[i] < 21)
                {
                    maxi = i;
                }
            }
            Console.WriteLine($"8. Neki a legnehezebb a csomagja 10 és 20 kg között: {nevek[maxi]}");   

            Console.ReadKey();
        }
    }
}
