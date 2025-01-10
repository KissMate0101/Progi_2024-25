using System;

namespace gyumulcsok
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("|Egyesével|: ");
            string[] gyumolcsok = { "alma", "banán", "citrom", "mangó" };
            Console.WriteLine("gyumolcsok");
            Console.WriteLine(gyumolcsok[0]);
            Console.WriteLine(gyumolcsok[1]);
            Console.WriteLine(gyumolcsok[2]);
            Console.WriteLine(gyumolcsok[3]);

            Console.WriteLine();
            Console.WriteLine("|Ciklussal|: ");
            for (int i = 0; i < gyumolcsok.Length; i++)
            {
                Console.WriteLine(gyumolcsok[i]);
            }

            Console.ReadKey();
        }
    }
}
