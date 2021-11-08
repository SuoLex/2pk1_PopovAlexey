using System;

namespace pz_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int M = 10;
            Console.WriteLine($"Кол-во ячеек в первой строке = {M}");
            int N = rnd.Next(5, 35); //делаем рандом двумерный массив
            Console.WriteLine($"Кол-во ячеек во второй стркое = {N}");

            // Объявляем ступенчатый массив
            int[][] massiv = new int[2][];
            massiv[0] = new int[M];
            massiv[1] = new int[N];

            // Инициализируем ступенчатый массив
            for (int i = 0; i < M; i++)
            {
                massiv[0][i] = rnd.Next(0,10) ;
                Console.Write("{0} ", massiv[0][i]);
            }

            Console.WriteLine();
            for (int j = 0; j < N; j++)
            {
                massiv[1][j] = rnd.Next(0, 10);
                Console.Write("{0} ", massiv[1][j]);
            }



        }
    }
}
