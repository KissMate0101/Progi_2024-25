using System;
using System.Linq.Expressions;
using System.Threading;

namespace allat_evo_allatok
{
    internal class Program
    {

        static void Beolvas(string[] bal, string[] jobb, out int n)
        {
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string sor = Console.ReadLine();
                string[] adatok = sor.Split(' ');
                bal[i] = adatok[0];
                bal[i] = adatok[1];
            }
        }

        static void Kivalogatas(string[] bal, string[] jobb, int n, string[] allatok, out int db)
        {
            db = 0;
            for (int i = 0; i < n; i++)
            {
                if (Eleme(jobb[i], bal) && !Eleme(bal[i], allatok))
                {
                    allatok[db] = bal[i];
                    db++;
                }
            }
        }

        static bool Eleme(string s, string[] t)
        {
            int i = 0;
            while (i < t.Length && !(t[i] == s))
            {
                i++;
            }
            return i < t.Length;
        }

        static void Kiir(string[] allatok, int db)
        {
            Console.WriteLine(db);
            for (int i = 0; i < db; i++)
            {
                Console.WriteLine(allatok[i]);
            }
        }

        static void Main(string[] args)
        {
            string[] bal = new string[30];
            string[] jobb = new string[30];
            Beolvas(bal, jobb, out int n);

            string[] allatok = new string[30];
            Kivalogatas(bal, jobb, n, allatok, out int db);

            Kiir(allatok, db);
        }
    }
}