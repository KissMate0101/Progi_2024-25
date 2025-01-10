using System;

namespace szamelmelet
{
    internal class Program
    {
        static bool PrimE(int n)
        {
            if (n < 2)
            {
                return false;
            }
            int i = 2;
            while (i <= Math.Sqrt(n) && !(n % i == 0))
            {
                i++;
            }
            return i < Math.Sqrt(n);
        }

        static int[] Primsz(int[] x, out int db)
        {
            int[] y = new int[1000];
            db = 0;
            for (int i = 0; i < x.Length; i++)
            {
                if (PrimE(x[i]))
                {
                    y[db] = x[i];
                    db++;
                }
            }
            return y;
        }

        static void Kiir(int[] x, int db)
        {

            Console.WriteLine("Prímszámook");
            for (int i = 0; i < db; i++)
            {
                Console.Write(x[i] + " ");
            }
        }

        static int OsztokSzama(int a)
        {
            int db = 0;
            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                {
                    db++;
                }
            }
            return db;
        }

        static int SokOsztos(int[] c)
        {
            int i = 0;
            while (i < c.Length && !(OsztokSzama(c[i]) >= 20))
            {
                i++;
            }
            if (i < c.Length)
            {
                return c[i];
            }
            else
            {
                return 0;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(PrimE(17));
            Console.WriteLine(PrimE(35));
            Console.WriteLine(PrimE(2));
            Console.WriteLine(PrimE(1));

            int[] pr = Primsz(new int[] { 7, 23, 6, 42, 73, 2, 3, 9, 1, 5 },out int db);
            Kiir(pr, db);

            Console.WriteLine(OsztokSzama(6));
            Console.WriteLine(OsztokSzama(1001));
            Console.WriteLine(OsztokSzama(360));

            int husz = SokOsztos(new int[] { 6, 1001, 48, 360, 75 });
            Console.WriteLine(husz);
        }
    }
}
