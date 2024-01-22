using System;

namespace Problem2
{
    internal class Iloczyn
    {
        public static void Main(string[] args)
        {
            const int N = 3;
            const int M = 3;
            const int K = 3;

            double[,] macierzA = new double[N, K];
            double[,] macierzB = new double[K, M];
            double[,] macierzC = new double[N, M];
            
            Console.WriteLine("Podaj elemty macierzy A.");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < K; j++)
                {
                    Console.Write("A[{0},{1}] = ", i+1, j+1);
                    macierzA[i, j] = Convert.ToDouble(Console.ReadLine() );
                }
            }
            
            Console.WriteLine("Podaj elementy macierzy B.");
            for (int i = 0; i < K; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write("B[{0},{1}] = ", i+1, j+1);
                    macierzB[i, j] = Convert.ToDouble(Console.ReadLine() );
                }
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    macierzC[i, j] = 0;
                    for (int k = 0; k < K; k++)
                    {
                        macierzC[i, j] += macierzA[i, k] * macierzB[k, j];
                    }
                }
            }
            
            Console.WriteLine("\nWynikiem mnożenia podanych macierzy jest macierz:");
            for (int i = 0; i < macierzC.GetLength(0); i++)
            {
                for (int j = 0; j < macierzC.GetLength(1); j++)
                {
                    Console.Write("{0,10}, ", macierzC[i, j]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }
}