using System;

namespace pz_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите 1-ю строку: ");
            string a1 =Console.ReadLine();
            Console.Write("Введите 2-ю строку: ");
            string a2 = Console.ReadLine();
            Console.Write("Введите 3-ю строку: ");
            string a3 = Console.ReadLine();
            Console.Write("Введите 4-ю строку: ");
            string a4 = Console.ReadLine();
            int b = 0;
            int b1 = 0;
            int b2 = 0;
            b = Math.Max(a1.Length, a2.Length);
            b1 = Math.Max(a3.Length, a4.Length);
            b2 = Math.Max(b, b1);
            if (b2 == a1.Length)
            {
                Console.WriteLine("1");
            }
            if (b2 == a2.Length)
            {
                Console.WriteLine("1");
            }
            if (b2 == a3.Length)
            {
                Console.WriteLine("3");
            }
            if (b2 == a4.Length)
            {
                Console.WriteLine("4");
            }

        }
    }
}
