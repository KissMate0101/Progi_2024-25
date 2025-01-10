using System;

namespace hatványozás
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 2;
            const int n = 10;

            double eredm = 1;
            for(int i = 0; i < n; i++)
            {
                eredm *= a;
            }
            Console.WriteLine($"{a}^{n} = {eredm}");

            Console.ReadKey();
        }
    }
}
