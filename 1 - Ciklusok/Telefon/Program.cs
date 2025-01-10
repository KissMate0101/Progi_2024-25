using System;

namespace Telefon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // írjuk ki n-szer, hogy "Nem mobilozok az iskolában"
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{i+1:00}. Nem mobilzok az iskoléban!");
            }

            Console.WriteLine("\n"); /* \n-->sortörés, \t--> tab */
 
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"{i:00}. Nem mobilzok az iskoléban!");
            }

            Console.WriteLine("\n");

            int j = 1;
            while (j <= n)
            {
                Console.WriteLine($"{j:00}. Nem mobilzok az iskoléban!");
                j++;
            }

            Console.ReadKey();
        }
    }
}
