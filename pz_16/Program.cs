using System;
namespace pz_16
{
    class Program
    {

        static void Swap(  int X,int Y, int e)
        {
            int A, B, C, D = 0;

            if (e==0)
            {
                B = X;
                A = Y;
                Console.WriteLine($"Число A в данный момент:{A}\nЧисло B в данный момент:{B}");
            }
            if (e==1)
            {
                C = Y;
                D = X;
                Console.WriteLine($"Число C в данный момент:{C}\nЧисло D в данный момент:{D}\n");
            }
            if (e==2)
            {
                B = Y;
                C = X;
                Console.WriteLine($"Число B в конечный момент:{B}\nЧисло C в конечный момент:{C}\n");
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Введите значение A:");
            int a = Convert.ToInt16(Console.ReadLine());
            Console.Write("Введите значение B:");
            int b = Convert.ToInt16(Console.ReadLine());
            Swap(  a, b, 0);
            Console.Write("Введите значение C:");
            int c = Convert.ToInt16(Console.ReadLine());
            Console.Write("Введите значение D:");
            int d = Convert.ToInt16(Console.ReadLine());
            Swap( c, d, 1);
            Console.WriteLine("Числа B и C равны:");
            Swap(a, d, 2);
            
        }

    }

}