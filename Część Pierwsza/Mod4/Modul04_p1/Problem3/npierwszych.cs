using System;

namespace N_pierwszych
{
    internal class npierwszych
    {
        public static void Main(string[] args)
        {
            //Deklaracja zmiennych
            ulong iloczyn = 1, suma = 0;
            ushort a, k, n;

            //Pobranie wartości zmiennych
            Console.Write("Podaj wartość zmiennej n: ");
            n = Convert.ToUInt16(Console.ReadLine());
            Console.Write("Podaj wartość zmiennej k: ");
            k = Convert.ToUInt16(Console.ReadLine());

            //Przypisanie wartości zmiennej k do zmiennej a
            a = k;

            //Obliczenia
            for (int i = 0; i < n; i++)
            {
                suma += a;
                checked
                {
                    iloczyn *= a;
                }
                a += k;
            }

            //Wypisanie wyniku
            Console.WriteLine($"suma = {0}",suma);
            Console.WriteLine($"iloczyn = {0}",iloczyn);

            //Zakończenie programu
            Console.ReadKey();
        }
    }
}