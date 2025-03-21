using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace epitmenyado
{
    internal class Program
    {
        struct Telkek
        {
            public string adoszam;
            public string utca;
            public string hazszam;
            public char sav;
            public int negyzetmeter;
        }

        struct Savszorzo
        {
            public int a;
            public int b;
            public int c;
        }

        static void Main(string[] args)
        {
            List<Telkek> telkek = new List<Telkek>();
            Beolvas(telkek);
            Kiir(telkek);

            Savszorzo savszorzo = new Savszorzo { a = 800, b = 600, c = 180};
        }

        static void Kiir(List<Telkek> telkek)
        {
            for (int i = 0; i < telkek.Count; i++)
            {
                Console.WriteLine($"" +
                    $"{telkek[i].adoszam}" +
                    $"{telkek[i].utca}" +
                    $"{telkek[i].hazszam}" +
                    $"{telkek[i].sav}" +
                    $"{telkek[i].negyzetmeter}");
            }
        }

        static void Beolvas(List<Telkek> telkek)
        {
            StreamReader sr = new StreamReader("utca.txt");
            while (!sr.EndOfStream)
            {
                string[] sor = sr.ReadLine().Split(';');
                Telkek telek = new Telkek
                {
                    adoszam = sor[0],
                    utca = sor[1],
                    hazszam = sor[2],
                    sav = char.Parse(sor[3]),
                    negyzetmeter = int.Parse(sor[4])
                };
                telkek.Add(telek);
            }
            sr.Close();
        }
    }
}
