using System;

namespace Wyrazenie
{
    internal class Wyrazenie
    {
        public static void Main(string[] args)
        {
            //Inicjalizacja zmiennych
            double x, y, z, v;
            
            //Pobieranie od użytkownika wartości dla x,y,z
            Console.Write("Podaj wartość zmiennej x: 1");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj wartość zmiennej y: ");
            y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj wartość zmiennej z: ");
            z = Convert.ToDouble(Console.ReadLine());
            
            //Działanie
            v = (4*x-y) / (3*(z*z+1));
            
            //Wynik działania i zakończenie programu
            Console.Write("Wartośc wyrażenia wynosi: {0}", v);
            Console.ReadKey();

        }
    }
}