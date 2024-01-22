using System;

namespace Wyrazenie
{
    internal class Wyrazenie
    {
        public static void Main(string[] args)
        {
            //Deklarazja zmiennych
            double x, y, z;
            
            //Pobranie wartośći zmiennych
            Console.Write("Podaj wartośc zmiennej x:" );
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj wartośc zmiennej y:" );
            y = Convert.ToDouble(Console.ReadLine());
            
            //Sprawdzenie zmiennych x i y w przypadku mniejszym od zera
            if (x < 0 && y < 0)
            {
                z = x * y; 
            }
            else //Sprawdzenie zmiennych x i y w przypadku równym zero
            {
                if (x == 0 || y == 0)
                {
                    z = 10;
                }
                else
                {
                    z = x + y;
                }
            }
            
            //Wypisanie wartości zmiennej
            Console.Write("z = {0}", z);
            
            //Zakończenie programu
            Console.ReadKey();

        }
    }
}