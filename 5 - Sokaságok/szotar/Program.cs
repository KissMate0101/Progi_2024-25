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

            Console.WriteLine("Szópárok száma: " + magyarangol.Count);

            Console.WriteLine("Macska angolul: " + magyarangol["macska"]);
        }
    }
}
