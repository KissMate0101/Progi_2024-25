using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karacsonyfa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            int db = 0;
            int szokoz = 6;
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 0; j < szokoz; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= db; j++)
                {
                    Random r = new Random();
                    int p = r.Next(1, 101);
                    if (p <= 10)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("*");
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else if(p <= 10)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("*");
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    Console.Write("*");
                }
                Console.WriteLine();
                db += 2;
                for (int j = 1; j < szokoz; j++)
                {
                    Console.Write(" ");
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
