using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace időkonv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int ora = r.Next(24);
            int perc = r.Next(60);
            int mperc = r.Next(60);
            Console.WriteLine($"Idő {ora:00} : {perc:00} : {mperc:00}");

            int masodperc;

            masodperc = ora * 3600 + perc * 60 + mperc;
            Console.WriteLine($"ennyi másodperc telt el reggel óta: {masodperc}");
            int hour = masodperc / 3600;
            int maradek = masodperc % 3600;
            int min = maradek / 60;
            int sec = maradek % 60;

            Console.WriteLine($"Visszaváltva: {hour} óra {min} perc {sec} masodperc");

            Console.ReadKey();
        }
    }
}
