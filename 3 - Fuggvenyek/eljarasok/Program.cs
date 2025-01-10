using System;
using System.Runtime.InteropServices;
using System.Xml;

namespace eljarasok
{
    internal class Program
    {
        static void Kiir(string s)
        {
             Random r = new Random();
             int n = r.Next(3, 10);
             for (int i = 0; i < n; i++)
             {
                Console.WriteLine(s);
             }        
        }

        static void Beolvas(out int n)
        {
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fuggvényen belül: " + n);
        }

        //ref - cím szerinti paraméter átadás
        static void Duplaz(ref int a)
        {
            if (a % 2 != 0)
            {
                a *= 2;
            }
        }

        static void Novel(int[] t)
        {
            for (int i = 0; i < t.Length; i++)
            {
                t[i]++;
            }
        }

        static void Kiir(int[] t)
        {
            for (int i = 0; i < t.Length; i++)
            {
                Console.Write(t[i] + " ");
            }
        }

        static void Main(string[] args)
        {
            Kiir("kifli");

            Beolvas(out int n);
            Console.WriteLine("Fuggvény után: " + n);

            int a = 7;
            Duplaz(ref a);
            Console.WriteLine("Új 'a' érték: " + a);

            int[] t = { 5, 7, -3 };
            Novel(t);
            Kiir(t);
        }
    }

}