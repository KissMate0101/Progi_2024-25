using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace random_paratlan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            string szam = "";
            for (int i = 0; i < 7; i++)
            {
                
                int ptl = r.Next(5) * 2 + 1;
                szam = szam + ptl;
            }
            Console.WriteLine($"A generált 7db szám: {szam}");

            Console.ReadKey();
        }
    }
}
