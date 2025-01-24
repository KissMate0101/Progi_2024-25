using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mestereshazi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> nevek = new List<string>();
            List<int> pontok = new List<int>();
            int n;
            int maxpont;
            Beolvas(nevek, pontok, out n, out maxpont);

            List<string> a = new List<string>();
            List<string> b = new List<string>();
            List<string> c = new List<string>();
            List<string> d = new List<string>();

            Szetvalogat(maxpont, pontok, nevek, a, b, c, d);

            Kiir(a);
            Kiir(b);
            Kiir(c);
            Kiir(d);
        }

        static void Kiir(List<string> nevek)
        {
            Console.Write(nevek.Count + ";");
            foreach (string nev in nevek)
            {
                Console.Write(nev + ";");
            }
            Console.WriteLine();
        }

        static void Szetvalogat(int maxpont, List<int> pontok, List<string> nevek, List<string> a, List<string> b, List<string> c, List<string> d)
        {
            for (int i = 0; i < pontok.Count; i++)
            {
                double sz = (double)pontok[i] / maxpont * 100;
                if (sz >= 90)
                {
                    a.Add(nevek[i]);
                }
                else if (sz >= 80)
                {
                    b.Add(nevek[i]);
                }
                else if (sz >= 70)
                {
                    c.Add(nevek[i]);
                }
                else if (sz >= 60)
                {
                    d.Add(nevek[i]);
                }
            }
        }

        static void Beolvas(List<string> nevek, List<int> pontok, out int n, out int maxpont)
        {
            string[] sor = Console.ReadLine().Split(' ');
            n = int.Parse(sor[0]);
            maxpont = int.Parse(sor[1]);
            for (int i = 0; i < n; i++)
            {
                sor = Console.ReadLine().Split(';');
                nevek.Add(sor[0]);
                pontok.Add(int.Parse(sor[1]));
            }
        }
    }
}
