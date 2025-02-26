using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiraly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> nevek = new List<string>();
            List<int> evszam = new List<int>();
            List<int> hossz = new List<int>();
            //Beolvas1(nevek, primek);
            //Beolvas2(nevek, primek);
            Beolvas(nevek, evszam, hossz);

            List<int> idosav = new List<int>();
            Rendezes(nevek, evszam, hossz);
            Kiir(nevek, evszam, hossz);
            //Hozzafuz(nevek, primek);
        }

        static void Kiir(List<string> nevek, List<int> evszam, List<int> hossz)
        {
            for (int i = 0; i < nevek.Count; i++)
            {
                Console.WriteLine($"{nevek[i]}, {evszam[i]}, {hossz[i]}");
            }
        }

        static void Rendezes(List<string> nevek, List<int> evszam, List<int> hossz)
        {
            for (int i = 0; i < hossz.Count; i++)
            {
                int k = i;
                for(int j = k; j < hossz.Count; j++)
                {
                    if (hossz[j] > hossz[k] || hossz[j] == hossz[k] && hossz[j] < evszam[k])
                    {
                        k = j;
                    }
                }
                Csere(nevek, i, k);
                Csere(evszam, i, k);
                Csere(hossz, i, k);
            }
        }

         static void Csere<T>(List<T> idosav, int i, int j)
        {
            (idosav[j], idosav[i]) = (idosav[i], idosav[j]);
        }

        static void Beolvas(List<string> nevek, List<int> evszam, List<int> hossz)
        {
            StreamReader reader = new StreamReader("adatok.txt");
            while (!reader.EndOfStream)
            {
                string[] sor = reader.ReadLine().Split(',');
                nevek.Add(sor[0]);
                evszam.Add(int.Parse(sor[1]));
                hossz.Add(int.Parse(sor[2]));
            }
            reader.Close();
        }

    }
}
