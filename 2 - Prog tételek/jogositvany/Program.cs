using System;


namespace jogositvany
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CamelCase => (addEventListener)
            //PascalCase => 
            //Kebab-Case => (List-style-type)
            int n = Convert.ToInt32(Console.ReadLine());

            string[] nevek = new string[100];
            int[] korok = new int[100];
            bool[] jogsik = new bool[100];


            //beolvasás
            int i;
            for (i = 0; i < n; i++)
            {
                string sor = Console.ReadLine();
                string[] adatok = sor.Split(' ');
                nevek[i] = adatok[0];
                korok[i] = Convert.ToInt32(adatok[1]);
                jogsik[i] = adatok[2] == "I" ;
            }

            //2. F

            int db = 0;
            for (i = 0; i < n; i++)
            {
                if (jogsik[i] == true)
                {
                    db++;
                }
            }
            double szazalek = (double) db / n *100;
            Console.WriteLine($"2) emberek százaléka jogasival: {szazalek}%");

            //3. F

            i = 0;
            while (i < n && !(korok[i] >= 30 && jogsik[i] == false))
            {
                i++;
            }
            if (i < n)
            {
                Console.WriteLine($"3) 30 év felett, de nincs jogsi: {nevek[i]}");
            }
            else
            {
                Console.WriteLine("3) Nincs ilyen ember");
            }

            //4. F

            int maxe = korok[0];
            for (i = 0; i < n; i++)
            {
                if (korok[i] > maxe)
                {
                    maxe = korok[i];
                }
            }
            int mine = korok[0];
            for (i = 0; i < n; i++)
            {
                if (korok[i] < mine)
                {
                    mine = korok[i];
                }
            }
            Console.WriteLine($"4. A külömbség a legidősebb és a legfiatalabb között: {maxe - mine}");

            //5. F

            int huszfel = 0;
            int huszal = 0;
            for (i = 0; i < n; i++)
            {
                if (korok[i] >= 20 && jogsik[i] == true)
                {
                    huszfel++;
                }
                if (korok[i] < 20 && jogsik[i] == true)
                {
                    huszal++;
                }
            }
            if (huszfel > huszal)
            {
                Console.WriteLine($"5) Igaz");
            }
            else
            {
                Console.WriteLine($"5) Hamis");
            }

            //6. F

            i = 0;
            while (i < n && !(nevek[i][0] == 'F'))
            {
                i++;
            }
            if (i<n)
            {
                Console.WriteLine($"6) Van és ez a neve: {nevek[i]}");
            }
            else
            {
                Console.WriteLine($"6) Nincs ilyen név");
            }

            //7. F

            double ossz = 0;
            for (i = n-1; i >= 10; i--)
            {
                ossz += korok[i];
            }
            Console.WriteLine($"7) Az utsó 10 ember átlag életkora: {ossz / 10}");

            //Console.ReadKey();
        }
    }
}
