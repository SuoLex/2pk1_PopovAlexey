using System;

namespace pz_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int M = 10;
            Console.WriteLine("Зубчатый массив, состоящий из двух строк и заполненный рандомными числами:");
            Console.WriteLine($"Кол-во ячеек в первой строке = {M}");
            int N = rnd.Next(5, 35); //делаем рандом двумерный массив
            Console.WriteLine($"Кол-во ячеек во второй стркое = {N}");
            Console.WriteLine("Первый массив:") ;
            int[][] massiv = new int[2][];
            massiv[0] = new int[M];
            massiv[1] = new int[N];
            Console.WriteLine();
            for (int i = 0; i < M; i++)
            {
                massiv[0][i] = rnd.Next(0, 30);
                Console.Write("{0} ", massiv[0][i]);
            }
            Console.WriteLine();
            for (int j = 0; j < N; j++)
            {
                massiv[1][j] = rnd.Next(0, 30);
                Console.Write("{0} ", massiv[1][j]);
            }
            Console.WriteLine();
            Console.WriteLine();
            //Делаем задание 3 (новый массив [1] [2], где максимум числа из предыдущего массива)
            //Сначала находим максиимумы
            int max1 = 0;
            int max2 = 0;
            for (int i = 0; i < M; i ++)
            {
                if (max1 < massiv[0][i])
                {
                    max1 = massiv[0][i];
                } //Находим максимум 1 строки
            }
            for (int i = 0; i < N; i++)
            {
                if (max2 < massiv[1][i])
                {
                    max2 = massiv[1][i];
                } //Находим максиму 2 строки
            }

            int[] mini = new int[2] { max1, max2 };
            mini[0] = max1;
            mini[1] = max2;
            Console.WriteLine("Второй массив с двумя переменными:");
            Console.WriteLine();
            Console.WriteLine($"{mini[0]} {mini[1]}");
            Console.WriteLine();
            //Делаем последнее задание, нужно поменять в первом массиве первое значение на максимум в строке
            massiv[0][0] = max1;
            massiv[1][0] = max2;
            Console.WriteLine("Итоговый массив:");
            Console.WriteLine(  );
            for (int i =0; i<M; i++)
            {
                Console.Write($"{massiv[0][i]} ");
            }
            Console.WriteLine();
            for (int i = 0; i < N; i++)
            {
                Console.Write($"{massiv[1][i]} ");
            }
            Console.WriteLine();
        }
    }
}
