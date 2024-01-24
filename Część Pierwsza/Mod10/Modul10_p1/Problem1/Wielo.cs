using System;

namespace Modul10_p1
{
    internal class Wielo
    {
        static double Wielomian(double x, params double[] a)
        {
            double suma = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                suma = suma * x + a[i];
            }
            return suma;
        }
        
        static double Wielomian(double x, out double stopien, params double[] a)
        {
            stopien = a.Length - 1;
            for (int i = 0; i < a.Length - 1; i--)
            {
                if (a[i] != 0)
                    break;
                stopien--;
            }
            return Wielomian(x,a);
        }

        public static void Main(string[] args)
        {
            double stopienWielomianu;
            double[] wspolczynnikiWielomianu = {1, 1, 0, 1};

            Console.WriteLine("Wartość wielomianu obliczona pierwszą metodą {0}",Wielomian(1, wspolczynnikiWielomianu));
            Console.WriteLine("Wartość wielomianu obliczona drugą metodą {0}",Wielomian(1, out stopienWielomianu, wspolczynnikiWielomianu));
            Console.WriteLine("Stopień wielomianu: {0}", stopienWielomianu);
            
            Console.WriteLine("\nInny sposób przekazania wartości współczynników wielomianu do metody");
            Console.WriteLine("Wartość wielomianu obliczona pierwszą metodą {0}", Wielomian( 1, 0, 1, 2));
            Console.WriteLine("Wartość wielomianu obliczona drugą metodą {0}", Wielomian( 1, 0, 1, 2));
            Console.WriteLine("Stopień wielomianu: {0}", stopienWielomianu);
            Console.ReadKey();
        }
    }
}