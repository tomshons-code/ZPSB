using System;
using System.Xml;

namespace Modul03_p1
{
    internal class Pierwiastek
    {
        public static void Main(string[] args)
        {
            //Deklaracja zmiennych
            double a, b, c, x1, x2, delta;

            //Utworzenie bloku try-catch
            try
            {
                //Pobranie wartości
                Console.Write("Podaj wartość parametru a: ");
                a = Convert.ToDouble(Console.ReadLine());
                
                //Weryfikacja parametru a
                if (a == 0)
                {
                    throw new Exception("Parametr a powinien być różny od zera.");
                }
                
                //Pobranie klejnych zmiennych
                Console.Write("Podaj wartość parametru b: ");
                b = Convert.ToDouble(Console.ReadLine());
                Console.Write("Podaj wartość parametru c: ");
                c = Convert.ToDouble(Console.ReadLine());
                
                //Obliczenie Delty
                delta = b * b - 4* a * c;
                
                //Weryfikacja czy Delta jest większa od zera i obliczenie pierwiastków
                if (delta > 0)
                {
                    x1 = (-b - Math.Sqrt(delta))/(2*a);
                    x2 = (-b + Math.Sqrt(delta))/(2*a);
                    Console.WriteLine("Równanie ma dwa pierwiastki:");
                    Console.WriteLine("\tx1 = {0}", x1);
                    Console.WriteLine("\tx2 = {0}", x2);
                }
                else
                {
                    if (delta == 0)
                    {
                        x1 = -b / (2 * a);
                        Console.WriteLine("Równanie ma jeden pierwiastek rzeczywisty:");
                        Console.WriteLine("\tx1 = {0}", x1);
                    }
                    else
                    {
                        Console.WriteLine("Równanie nie ma pierwiastków rzeczywistych");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Program został perwany. {0}", ex);
            }
            
            //Zakończenie programu
            Console.ReadKey();

        }
    }
}