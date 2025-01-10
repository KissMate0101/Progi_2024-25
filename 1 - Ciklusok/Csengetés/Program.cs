using System;

namespace Csengetés
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 8:00 => a nap 480. perce
            int ido = 480;
            for(int i = 0; i < 8; i++)
            {
                Console.Write($"{i+1}. óra:  {ido/60:00}:{ido%60:00} - ");
                ido += 45;
                Console.WriteLine($"{ido / 60:00}:{ido % 60:00}");
                ido += 10;
            }

            Console.ReadKey();
        }       
    }
}
