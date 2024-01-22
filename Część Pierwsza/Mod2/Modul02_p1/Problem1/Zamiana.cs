using System;

namespace Modul02
{
    internal class Zamiana
    {
        public static void Main(string[] args)
        {
            //Inicjacja zmiennych
            double a, b, tmp;
            
            //Pobieranie wartości zmiennych a i b od użytkownika
            Console.WriteLine("Podaj wartość zmiennej a");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj wartość zmiennej b");
            b = Convert.ToDouble(Console.ReadLine());
            
            //wymiana wartości a i b przy pomocy zmiennej tmp
            tmp = a;
            a = b;
            b = tmp;
            
            //Wypisanie wartości zmiennych i zakończenie programu
            Console.WriteLine("a = {0}, b = {1}", a, b);
            Console.ReadKey();
        }
    }
}