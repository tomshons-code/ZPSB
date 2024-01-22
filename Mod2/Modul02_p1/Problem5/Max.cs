using System;

namespace Max
{
    internal class Max
    {
        public static void Main(string[] args)
        {
            //Deklaracja zmiennych
            int a, b, max;
            
            //Pobranie wartości zmiennych
            Console.Write("Podaj pierwszą wartość: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj pierwszą wartość: ");
            b = Convert.ToInt32(Console.ReadLine());
            
            //Wyznaczenie warości max
            max = a > b ? a : b;
            
            Console.WriteLine("Wartość maksymalna wynosi: {0}.", max);
            
            //Zakończenie programu
            Console.ReadKey();

        }
    }
}