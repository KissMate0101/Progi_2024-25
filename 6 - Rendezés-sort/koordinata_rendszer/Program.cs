using System;
using System.IO;

namespace koordinata_rendszer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader olvas = new StreamReader("adatok.txt");
            string koordinatak = olvas.ReadLine();
            olvas.Close();

            StreamWriter kiir = new StreamWriter("ki.txt");
            int x = 0;
            int y = 0;
            kiir.WriteLine($"P({x},{y})");
            for (int i = 0; i < koordinatak.Length; i++)
            {
                if (koordinatak[i] == 'a')
                {
                    y++;

                }
                else if (koordinatak[i] == 'b')
                {
                    x++;

                }
                else if (koordinatak[i] == 'c')
                {
                    y--;

                }
                else
                {
                    x--;

                }
                kiir.WriteLine($"P({x},{y})");
            }
            kiir.Close();

            double d = Tavolsagok(0, 0, 29, 23);
            Console.WriteLine("Tavolságok: " + Math.Round(d, 0));
        }

        static double Tavolsagok(double a1, double a2, double b1, double b2)
        {
            double negyzet = (b1 - a1) * (b1 - a1) + (b2 - a2) * (b2 - a2);
            return Math.Sqrt(negyzet);
        }
    }
}
