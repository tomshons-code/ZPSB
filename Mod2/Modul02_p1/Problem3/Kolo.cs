using System;

namespace Kolo
{
    internal class Kolo
    {
        public static void Main(string[] args)
        {
            //Inicjalizacja zmiennej r
            double r;
            
            //Pobranie od użytkownika wartości dla zmiennej r
            Console.WriteLine("Podaj długość promienia: ");
            r = Convert.ToDouble(Console.ReadLine());
            
            //inicjalizacja zmiennych pole i obwod
            double pole = Math.PI * r * r;
            double obwod = 2 * Math.PI * r;
            
            //Wypisanie obwodu oraz pola koła i zakończnie programu
            Console.WriteLine("Pole koła o promieniu {0} wynosi: {1:f3}", r, pole);
            Console.WriteLine("Owdód koła o promieniu {0} wynosi: {1:f3}", r, obwod);
            Console.ReadKey();
        }
    }
}