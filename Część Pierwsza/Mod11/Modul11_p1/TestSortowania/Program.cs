using System;
using Sortowanie.Properties;

namespace TestSortowania
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] liczby = new int[10];
            Random r = new Random();
            Console.WriteLine("Tablica przed sortowaniem:");
            for (int i = 0; i < liczby.Length; i++)
            {
                liczby[i] = r.Next(0, 1001);
                Console.Write("{0}, ", liczby[i]);
            }

            QuickSort.Sortuj(liczby);

            Console.WriteLine("\n\nTablica po sortowaniu:");
            foreach (int i in liczby)
            {
                Console.Write("{0}, ", i);
            }

            Console.ReadKey();
        }

    }
}