using System;

namespace Pierwiastek
{
    internal class Pierwiastek
    {
        public static void Main(string[] args)
        {
            //Definicja maksymalnego błędu
            const double epsilon = 0.00001;

            //Definicja zmiennych
            double a, x = 1;

            //Pobranie wartości zmiennej
            Console.Write("Podaj wartość zmiennej a: ");
            a = Convert.ToDouble(Console.ReadLine());

            //Definicja wyjątku zmiennej
            if (a <= 0)
            {
                throw new Exception("a nie może być ujemne");
            }
            
            //Obliczenia
            while (Math.Abs(x * x - a) > epsilon)
            {
                x = (x + a / x) / 2;
            }

            //Wypisanie wyniku programu
            Console.WriteLine("Wartośćią (przybliżoną) pierwiastka kwadratowego liczby {0} jest {1}.", a, x);
            
            //Zakończenie programu
            Console.ReadKey(); 
        }
    }
}