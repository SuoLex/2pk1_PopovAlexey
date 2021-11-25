using System;
//Реализуйте метод, принимающий в качестве параметра целое число n и возвращающий
//массив размерности [n, n], заполненный по правилу: элементы главной и побочной диагонали
//= ‘*’, пересечение диагоналей = ‘o’, остальные элементы заполнены пробелами.

namespace простота
{
    class Program
    {
        static char Spagetti(ref char[,] massiv, int n)
        {
            int l = n;
            int h = 0;
            int c = n / 2;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        massiv[i, j] = '*';
                        
                        if (n%2==1& j==c)
                        {
                            massiv[i, j] = 'o';
                            l--;
                            h++;
                        }
                        Console.Write($"{massiv[i, j]} ");
                    }
                    else
                    {
                        if (i == h & j ==l-1 )
                        {
                            massiv[i, j] = '*';
                            Console.Write($"{massiv[i, j]} ");
                            l--;
                            h++;
                        }
                        else
                        {
                            massiv[i, j] = ' ';
                            Console.Write($"{massiv[i, j]} ");
                        }
                    }
                }
                Console.WriteLine();
            }


            return' ';
        }
        static void Main(string[] args)
        {
            Console.Write("Введите число n:");
            int n = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine();
            char[,] massiv = new char[n,n];
            Spagetti( ref massiv, n);
   
            
        }
    }
}