using System;

namespace erme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int dob = 50;
            int dobas;
            int fej= 0, iras = 0;

            for (int i = 0; i < dob; i++)
            {
                dobas = r.Next(1, 3);
                Console.WriteLine();
                if (dobas == 1)
                {
                    Console.Write("Fej");
                    fej++;
                }
                else
                {
                    Console.Write("Írás");
                    iras++;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Fejek száma: {fej}");
            Console.WriteLine($"Írások száma száma: {iras}");

            Console.WriteLine("\nb) Érme dobás 4 írásig");

            int db = 0;

            do
            {
                dobas = r.Next(1, 3);
                if (dobas == 1)
                {
                    Console.Write("F ");
                    db = 0;
                }
                else
                {
                    Console.Write("I ");
                    db++;
                }
            } while (db != 4);

            Console.ReadKey();
        }
    }
}
