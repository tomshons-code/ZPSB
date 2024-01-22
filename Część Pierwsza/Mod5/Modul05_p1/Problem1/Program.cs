using System;

enum MetodyCalkowania
{
    Prostokatow = 1,
    Trapezow = 2
    
}

namespace Modul05_p1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            double a = 0, b = 1;
            uint n = 10;
            MetodyCalkowania metoda = MetodyCalkowania.Prostokatow;

            char c;
            do
            {
                Console.WriteLine("Przedział całkowania: <{0}; {1}>",a ,b);
                Console.WriteLine("Liczba podziałów: {0}", n);
                Console.WriteLine("Metoda całkowania: {0}", metoda);
                Console.WriteLine("-----------------");
                Console.WriteLine("A - Zmiana przedziału");
                Console.WriteLine("B - Zmiana liczby podziałów");
                Console.WriteLine("C - Zmiana metody całkowania");
                Console.WriteLine("D - Policz całkę");
                Console.WriteLine("K - Koniec");
                c = Console.ReadKey(true).KeyChar;

                switch (c)
                {
                    
                    case 'A':
                    case 'a':
                        do
                        {
                            if (a > b)
                            {
                                Console.Write("Początek musi być mniejszy od końca: ");
                            }
                            Console.WriteLine("Podaj początek przedziału: ");
                            a = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Podaj koniec przedziału: ");
                            b = Convert.ToDouble(Console.ReadLine());
                        } while (a > b);
                        break;
                    
                    case 'B':
                    case 'b':
                        Console.WriteLine("Podaj liczbę podziałów: ");
                        n = Convert.ToUInt32(Console.ReadLine());
                        if (n == 0)
                        {
                            throw new Exception("Liczba podziałów musi być większa od zera");
                        }
                        break;
                    
                    case 'C':
                    case 'c':
                        int m = 1;
                        do
                        {
                            if (m != 1)
                            {
                                Console.Write("Naciśnij 1 lub 2: ");
                            }
                            Console.WriteLine("Podaj metodę liczenia całki: ");
                            Console.WriteLine("\t1 - Metoda prostokątów");
                            Console.WriteLine("\t2 - Metoda trapezów");
                            m = Convert.ToInt32(Console.ReadLine());
                        } while (!(m == 1 || m == 2));
                        metoda = (MetodyCalkowania)m;
                        break;
               
                    case 'D':
                    case 'd':
                        double suma = 0;
                        double dx = (b - a) / n;
                        double x = a;
                        switch (metoda)
                        {
                            case MetodyCalkowania.Prostokatow:
                                for (int i = 0; i < n; i++)
                                {
                                    x += dx;
                                    suma += x * x * x * (x + 1) + 2;
                                }
                                suma *= dx;
                                break;
                            case MetodyCalkowania.Trapezow:
                                for (int i = 1; i < n; i++)
                                {
                                    x += dx;
                                    suma += x * x * x * (x + 1) + 2;
                                }
                                suma += (a * a * a * (a + 1) + b * b * b * (b + 1) + 4) / 2;
                                suma *= dx;
                                break;
                        }
                        Console.WriteLine("Przybliżona wartość całki funkcji w przedziale <{0}; {1}> wynosi: {2}",a,b,suma);
                        Console.ReadKey(true);
                        break;
                }
            } while (!(c == 'K' || c == 'k'));
        }
    }
}