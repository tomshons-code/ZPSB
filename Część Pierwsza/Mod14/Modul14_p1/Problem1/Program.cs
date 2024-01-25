using System;
using System.IO;

namespace Modul14_p1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
                Console.Write("Podaj nazwę pliku do zaszyfrowania: ");
                string nazwaZrodla = Console.ReadLine();
                Console.Write("Podaj nazwę pliku zaszyfrowanego: ");
                string nazwaCelu = Console.ReadLine();
                Console.Write("Podaj wartość klucza (od 0 do 255): ");
                byte klucz = Convert.ToByte(Console.ReadLine());

                FileStream zrodlo = null, cel = null;
                try
                {
                    zrodlo = new FileStream(nazwaZrodla, FileMode.Open);
                    cel = new FileStream(nazwaCelu, FileMode.Create);
                    int i = zrodlo.ReadByte();
                    while (i != -1)
                    {
                        cel.WriteByte((byte)(i ^ klucz));
                        i = zrodlo.ReadByte();
                    }
                }
                finally
                {
                    if (zrodlo != null)
                    {
                        zrodlo.Close();
                    }
                    if (cel != null)
                    {
                        cel.Close();
                    }
                }
                Console.WriteLine("Operacja szyfrowania zakończona.");
                Console.ReadKey();
        }

    }
}