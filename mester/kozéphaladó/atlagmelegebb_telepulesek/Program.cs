using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atlagmelegebb_telepulesek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, m;
            int[,] matrix = new int[1000, 1000];
            Beolvas(matrix, out n, out m);

            double[] atlagtomb = AtlagMel(matrix, n, m);

            int max = Maxsor(atlagtomb, n);
            Console.WriteLine(max);
        }

        static void Beolvas(int[,] matrix, out int n, out int m)
        {
            string[] sor = Console.ReadLine().Split(' ');
            n = Convert.ToInt32(sor[0]);
            m = Convert.ToInt32(sor[1]);

            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = Convert.ToInt32(s[j]);
                }
            }
        }

        static double[] AtlagMel(int[,] matrix, int n, int m)
        {
            double[] atlagtomb = new double[1000];
            for (int i = 0; i < n; i++)
            {
                int ossz = 0;
                for (int j = 0; j < m; j++)
                {
                    ossz += matrix[i, j];
                }
                double atlag = (double)ossz / m;
                atlagtomb[i] = atlag;
            }
            return atlagtomb;
        }

        static int Maxsor(double[] atlagtomb, int n)
        {
            int maxi = 0;
            for (int i = 0; i < n; i++)
            {
                if (atlagtomb[maxi] > atlagtomb[i])
                {
                    maxi = i;
                }
            }
            return maxi + 1;
        }
    }
}
