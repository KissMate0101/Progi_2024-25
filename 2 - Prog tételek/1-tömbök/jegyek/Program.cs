using System;

namespace jegyek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[] jegyek = new int[16];
            
            //jeygek genrálása
            for (int i = 0; i < jegyek.Length; i++)
            {
                jegyek[i] = r.Next(1, 6);

            }

            // jegyek kiírása
            for (int i = 0; i < jegyek.Length; i++)
            {
                Console.WriteLine(jegyek[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
