using System;

namespace negyzetek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int n;

            Console.Write("n: ");
            n = Convert.ToInt32(Console.ReadLine());
            while(n <= 0)
            {
                Console.WriteLine("NEM JÓ! Pozitív egész számot adj meg");
                Console.Write("n: ");
                n = Convert.ToInt32(Console.ReadLine());
            }*/
            int n;
            do
            {
                Console.WriteLine("NEM JÓ! Pozitív egész számot adj meg");
                Console.Write("n: ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n <= 0);

            Console.WriteLine("A; feladat");
            for (int i = 0; i < n; i++)
            {
                Console.Write(i*i + " ");
            }

            Console.WriteLine();

            //c) n-ig írjuk ki a nlgyzetszámokat
            //12 => 0 1 4 9
            Console.WriteLine("\nB; feladat");
            int j = 0;
            while (j*j < n)
            {
                Console.Write(j*j + " ");
                j++;
            }

            Console.WriteLine();

            //c) n-ig írjuk ki a nlgyzetszámokat
            //12 => 0 1 4 9
            Console.WriteLine("\nC; feladat");
            int k = 0;
            int negyzet = k * k;
            while (negyzet < n)
            {
                Console.Write(negyzet + " ");
                k++;
                negyzet = k * k;
            }
            Console.ReadKey();
        }
    }
}
