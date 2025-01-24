using System;
using System.Collections.Generic;

namespace halmaz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //elemeknek nincs sorrendje, nem indexelhetők, egy elem csak egyszer szerepelhet 
            HashSet<int> halmaz = new HashSet<int> { 4, 6, 1, 2, 2, 1, 2 };
            Console.WriteLine("Elemszám: " + halmaz.Count);
            Console.WriteLine();

            halmaz.Add(13);
            Kiir(halmaz);
            Console.WriteLine();
            Console.WriteLine("--------------------------------");
            Console.WriteLine();

            HashSet<string> v1 = new HashSet<string> { "Bence", "Réka", "Máté", "Pisti", "Johanna", "Kata" };
            HashSet<string> v2 = new HashSet<string> { "Máté", "Zalán", "Csaba", "Kata", "Bence" };
            Kiir("1. verseny", v1);
            Kiir("2. verseny", v2);
            Kiir("Metszet: ");
        }

        

        static void Kiir(HashSet<int> halmaz)
        {
            Console.Write("Lista elemei: ");
            Console.Write("{ ");
            int db = 0;
            foreach (int elem in halmaz)
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
            Console.Write(" }");
        }
    }

        private static void Kiir(string v, HashSet<string> v2)
        {
            throw new NotImplementedException();
        }
    }
