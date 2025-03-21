using System;

namespace beolvas_kiir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("hello világ");

            //1. feladat: köszöntsük a felhasználókat
            /*
            string vnev, knev;

            Console.Write("Vezeték neved: ");
            vnev = Console.ReadLine();

            Console.Write("Kereszt neved: ");
            knev = Console.ReadLine();

            Console.WriteLine("Szia " + vnev + " " + knev + "!");
            Console.WriteLine("Szia {0} {1}", vnev, knev);
            Console.WriteLine($"Szia {vnev} {knev}");
            */

            float a, b;

            Console.Write("a: ");
            a = Convert.ToSingle(Console.ReadLine());

            Console.Write("b: ");
            b = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine($"Terület: {a*b}");

            float

            Console.ReadKey();
           
        }
    }
}
