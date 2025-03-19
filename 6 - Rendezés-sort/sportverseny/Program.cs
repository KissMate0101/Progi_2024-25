using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sportverseny
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> nevek = new List<string>();
            List<string> orszagok = new List<string>();
            List<int> pontok = new List<int>();
            Beolvas(nevek, orszagok, pontok);

            Rendez(nevek, orszagok, pontok);

            Kiir(nevek, orszagok, pontok);


        }

        static void Kiir(List<string> nevek, List<string> orszagok, List<int> pontok)
        {
            StreamWriter sw = new StreamWriter("rendezett.txt");
            int db = 1;
            int hely = 1;
            sw.WriteLine($"{db}. {nevek[0]} ({orszagok[0]}) - {pontok[0]}");
            for (int i = 1; i < nevek.Count - 1; i++)
            {
                if(pontok[i] > pontok[i - 1])
                {
                    db++;
                }
                else
                {
                    hely += db;
                    db = 1;
                }
                sw.WriteLine($"{db}. {nevek[i]} ({orszagok[i]}) - {pontok[i]}");
            }
            sw.Close();
            Console.WriteLine("Fájlba írás megtörtént!");
        }

        static void Rendez(List<string> nevek, List<string> orszagok, List<int> pontok)
        {
            // i: Hány rendezett elem van már a tömb végén!
            for (int i = 0; i < pontok.Count; i++)
            {
                for (int j = 0; j < pontok.Count - i - 1; j++)
                {
                    if (pontok[j] < pontok[j + 1] ||
                        (pontok[i] == pontok[i+1] &&
                        nevek[j].CompareTo(nevek[j+1]) == 1))
                    {
                        Csere(pontok, j, j + 1);
                        Csere(nevek, j, j + 1);
                        Csere(orszagok, j, j + 1);
                    }
                }
            }
        }

        static void Csere<T>(List<T> pontok, int i, int j)
        {
            (pontok[i], pontok[j]) = (pontok[j], pontok[i]);
        }

        static void Beolvas(List<string> nevek, List<string> orszagok, List<int> pontok)
        {
            StreamReader reader = new StreamReader("eredmeny.csv");
            while(!reader.EndOfStream)
            {
                string[] sor = Console.ReadLine().Split(',');
                nevek.Add(sor[0]);
                orszagok.Add(sor[1]);
                pontok.Add(int.Parse(sor[2]));
            }
            reader.Close();
        }
    }
}
