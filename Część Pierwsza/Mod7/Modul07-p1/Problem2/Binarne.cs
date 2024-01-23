using System;
using System.Text;

namespace Problem2
{
    internal class Binarne
    {
        public static void Main(string[] args)
        {
            string[] miasta = { "Poznan", "Warszawa","Czestochowa","Gdansk", "Łodź", "Krakow", "Wroclaw", "Bialystok", "Szczecin" };
            Array.Sort(miasta);
            
            Console.WriteLine("Elementy tablicy po sortowaniu: ");
            foreach (string miasto in miasta)
            {
                Console.Write("{0}, ", miasto);
            }

            Console.WriteLine("\n\nWpisz nazwę miasta: ");
            string s = Console.ReadLine();

            
            int lewy = 0, prawy = miasta.Length - 1;
            int srodek = (lewy + prawy)/2;
            int flaga;

            while (lewy <= prawy)
            {
                flaga = String.Compare(s, miasta[srodek]);
                if (flaga == 0)
                {
                    break;
                }
                else
                {
                    if (flaga < 0)
                    {
                        prawy = srodek - 1;
                    }
                    else
                    {
                        lewy = srodek + 1;

                    }   
                }
                srodek = (lewy + prawy) / 2;
            }
            
            if (lewy <= prawy)
            {
                Console.WriteLine("Podane miasto ma w tabelicy indeks {0}.", srodek);
            }
            else
            {
                Console.WriteLine("Tablica nie zawiera podanego miasta.");
            }

            Console.ReadKey();
        }
    }
}