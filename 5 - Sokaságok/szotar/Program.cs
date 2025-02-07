using System;
using System.Collections.Generic;

namespace szotar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // szotar -> Dictionary - Map - Asszociatív tömb

            Dictionary<string, string> magyarangol = new Dictionary<string, string>();
            magyarangol.Add("kutya", "dog");
            magyarangol.Add("macska", "cat");
            magyarangol.Add("oroszlan", "lion");
            magyarangol.Add("alma", "apple");
            magyarangol.Add("elefánt", "elephant");
            //magyarangol.Add("kutya", "hound"); // nem lehet 2x ugyan az a kulcs

            magyarangol.Remove("alma");

            Console.WriteLine("Szópárok száma: " + magyarangol.Count);

            Console.WriteLine("Macska angolul: " + magyarangol["macska"]);

            Console.WriteLine("a lion szót tudjuk-e magyarul? " + magyarangol.ContainsKey("oroszlán"));
            Console.WriteLine("a lion szót tudjuk-e magyarul? " + magyarangol.ContainsValue("lion"));
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine();
            //Kiir(magyarangol);

            Console.Clear();

            List<string> gyumolcsok = new List<string> { "narancs", "alma", "körte",
                                                         "alma", "narancs", "alma",
                                                         "alma", "szilva", "narancs" };

            Dictionary<string, int> mennyisegek = new Dictionary<string, int>();
            Megszamol(gyumolcsok, mennyisegek);
            Kiir(magyarangol);
            LegTobbMennyiseg(mennyisegek);
            string keresettgy = CsakEgy(mennyisegek);
            Console.WriteLine(keresettgy);
        }

        static string CsakEgy(Dictionary<string, int> mennyisegek)
        {
            Console.WriteLine();
            Console.Write("Van e olyan gyümölcs amiből csak 1 van? ");
            bool vanE = false;
            string keresettgy = "";
            foreach (string gyumolcs in mennyisegek.Keys)
            {
                if (mennyisegek[gyumolcs] == 1)
                {
                    vanE = true;
                    return gyumolcs;
                }
            }
            return "";
        }

        static void LegTobbMennyiseg(Dictionary<string, int> mennyisegek)
        {
            Console.WriteLine();
            Console.Write("A legnagyob érték: ");
            int maxe = int.MinValue;
            string maxkulcs = "";
            foreach (string gyumolcs in mennyisegek.Keys)
            {
                if (mennyisegek[gyumolcs] > maxe)
                {
                    maxe = mennyisegek[gyumolcs];
                    maxkulcs = gyumolcs;
                }
            }
            Console.WriteLine(maxe + " / " + maxkulcs);
        }

        static void Megszamol(List<string> gyumolcsok, Dictionary<string, int> mennyisegek)
        {
            foreach (string gyumolcs in gyumolcsok)
            {
                if (mennyisegek.ContainsKey(gyumolcs))
                {
                    mennyisegek[gyumolcs]++;
                }
                else
                {
                    mennyisegek.Add(gyumolcs, 1);
                }
            }
            
        }

        //static void Kiir(Dictionary<string, string> szotar)
        //{
        //    Console.WriteLine("magyar - angol szótár: ");
        //    Console.WriteLine();
        //    //Dictionary<string, string>.KeyCollection kulcsok = szotar.Keys;
        //    foreach (var kulcs in szotar.Keys)
        //    {
        //        Console.WriteLine(kulcs + " - " + szotar[kulcs]);
        //    }
        //}

        static void Kiir<TKey, Tvalue>(Dictionary<TKey, Tvalue> szotar)
        {
            Console.WriteLine();
            Console.WriteLine("magyar - angol szótár: ");
            Console.WriteLine();
            //Dictionary<string, string>.KeyCollection kulcsok = szotar.Keys;
            foreach (TKey kulcs in szotar.Keys)
            {
                Console.WriteLine(kulcs + " - " + szotar[kulcs]);
            }
        }
    }
}
