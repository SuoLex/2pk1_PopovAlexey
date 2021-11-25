using System;

namespace pz_17
{
    class Program
    {
        static int Burger( int[] massiv)
        {
             
            int o = 0;
            int e = 1;
            for (int i = 0; i < massiv.Length; i++)
            {
                e = massiv[i];

                while (e % 2 == 0 & e > 0)
                {
                    e = e / 2;
                    if (e == 1)
                    { o++; }
                }

            }
           

            Console.WriteLine($"Количетсво чисел, которые являются степенью числа 2:{o}");
            return 0;
        }
        static void Main(string[] args)
        {
            int[] massiv = { 16, 5, 67, 8, 4096,-2 };

            Burger( massiv);


        }
    }
}