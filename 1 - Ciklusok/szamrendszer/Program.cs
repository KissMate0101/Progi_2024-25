using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szamrendszer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 22;
            string eredm = "";
            while (n != 0)
            {
                int maradek = n % 2;
                n = n / 2;
                eredm = maradek + eredm;
            }
            Console.WriteLine($"2-es számrendszerben: {eredm}");
            Console.ReadKey();
        }
    }
}
