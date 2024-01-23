using System;

namespace Modul07_p1
{
    internal class Wstawianie
    {
        public static void Main(string[] args)
        {
            double[] tablica = new double[15];
            Random generator = new Random();

            for (int i = 0; i < tablica.Length; i++)
            {
                tablica[i] = generator.NextDouble();
            }
            
            Console.WriteLine("Wylosowano następujące wartości: ");
            foreach (double i in tablica)
            {
                Console.WriteLine("{0:f3}; ", i);   
            }
            
            //Sposób 1
            
            // double x;
            // int j;
            // for (int i = 0; i < tablica.Length; i++)
            // {
            //     x = tablica[i];
            //     for (j = i-1; j >= 0 && x < tablica[j] ; j--)
            //     {
            //         tablica[j + 1] = tablica[j];
            //     }
            //
            //     tablica[j + 1] = x; 
            // }

            //Sposób 2
            
            int j, l, p, m;
            double x;
            for (int i = 0; i < tablica.Length; i++)
            {
                x = tablica[i];
                l = 0;
                p = i - 1;
                while (l <= p)
                {
                    m = (l + p) / 2;
                    if (x <tablica[m])
                    {
                        p = m - 1;
                    }
                    else
                    {
                        l = m + 1;
                    }
                }
            
                for (j = i-1; j >= l; j--)
                {
                    tablica[j + 1] = tablica[j];
                }
                tablica[j + 1] = x;
            }
            
            Console.WriteLine("\nElementy tablicy po sortowaniu:");
            foreach (double i in tablica)
            {
                Console.Write("{0:f3}, ", i);
            }

            Console.ReadKey();
        }
    }
}