using System;
using System.Runtime.InteropServices;

namespace kocka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //a)
            Console.WriteLine("Hányszor dobj? ");
            Console.WriteLine("---------------");
            int n = Convert.ToInt32(Console.ReadLine());
            Random r = new Random();

            for (int i = 0; i <= n; i++)
            {
                int a = r.Next(1, 7);
                Console.Write($"{a} ");
            }

            //b) Dobáljunk amíg 6-ost nem kapunk!
            Console.WriteLine();
            Console.WriteLine("/////////////////////////////////");
            Console.WriteLine();
            Console.WriteLine("\nDobásaid amíg nem kaptál 6-ot: ");
            Console.WriteLine("---------------------------------");
            int b;
            do
            {
                b = r.Next(1, 7);
                Console.Write($"{b} ");

            } while (b != 6);
            
                
            
            
            Console.ReadKey();
        }
    }
}
