using System;

namespace Problem4
{
    internal class zgadnijliczbe
    {
        public static void Main(string[] args)
        {
            //Deklaracja stałych
            const int a = 0;
            const int b = 200;
            
            //Deklaracja zmiennych
            int n, m;
            
            //Generator
            Random generator = new Random();
            n = generator.Next(a, b + 1);
            
            //Zgadywanie
            do
            {
                Console.WriteLine("Podaj wartość wylosowanej liczby. Wartośc jest z przediału: <{0} - {1}>", a, b);
                m = Convert.ToInt32(Console.ReadLine());
                if (m < n)
                {
                    Console.WriteLine("Wartość podana jest za mała"); 
                }
                if (m > n)
                {
                    Console.WriteLine("Wartość podana jest za duża"); 
                }
            } 
            while (m != n);
            
            //Zgadnięcie liczby
            Console.WriteLine("Gratulacje!!! Odgadłeś liczbę.");
            
            //Zalończenie programu
            Console.ReadKey();
        }
    }
}