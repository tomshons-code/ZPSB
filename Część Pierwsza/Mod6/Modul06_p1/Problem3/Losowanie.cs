using System;

namespace Problem3
{
    internal class Losowanie
    {
        public static void Main(string[] args)
        {
            byte[] numery = new byte[6];

            Random genrator = new Random();
            int index = 0;
            int i;
            bool flaga;
            do
            {
                numery[index] = (byte)genrator.Next(1, 50);
                flaga = true;
                for (i = 0; i < index; i++)
                {
                    if (numery[index] == numery[i])
                    {
                        flaga = false;
                        break;
                    }
                }
                if (flaga)
                {
                    index++;
                }
            } while (index<6);
            
            Console.WriteLine("Wylosowane liczby to: ");
            foreach (var numer in numery)
            {
                Console.Write("{0}, ", numer);
            }

            Console.ReadKey();
        }
    }
}