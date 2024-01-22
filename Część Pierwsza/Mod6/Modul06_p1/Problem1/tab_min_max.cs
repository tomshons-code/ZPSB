using System;

namespace Modul06_p1
{
    internal class tab_min_max
    {
        public static void Main(string[] args)
        {
            int[] tablica = new int[15];

            Random generator = new Random();
            for (int i = 0; i < tablica.Length; i++)
            {
                tablica[i] = generator.Next(0, 101);
            }
            
            Console.WriteLine("Wylosowano następujące wartości");
            foreach (var i in tablica)
            {
                Console.Write("{0}, ", i);
            }

            int indexMax = 0;
            for (int i = 1; i < tablica.Length; i++)
            {
                if (tablica[indexMax] < tablica[i])
                {
                    indexMax = i;
                }
            }

            int indexMin = 0;
            for (int i = 1; i < tablica.Length; i++)
            {
                if (tablica[indexMin] > tablica[i])
                {
                    indexMin = i;
                }
            }

            indexMax = 0;
            indexMin = 0;
            for (int i = 1; i < tablica.Length; i++)
            {
                if (tablica[indexMin] > tablica[i])
                {
                    indexMin = i;
                }

                if (tablica[indexMax] < tablica[i])
                {
                    indexMax = i;
                }
            }
            
            Console.WriteLine("\n\nElement najmniejszy o indeksie {0} posiada wartość {1}.", indexMin, tablica[indexMin]);
            Console.WriteLine("Element największy o indeksie {0} posiada wartość {1}.", indexMax, tablica[indexMax]);
            Console.ReadKey();

        }
    }
}