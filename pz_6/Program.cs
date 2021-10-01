using System;

namespace pz_6 //Попов Алексей 2ПК1 17 Вариант
{
    class Program
    {
        static void Main(string[] args)
        {
            double y ;
            double x =0;
            double b = (double) 2.3;
            double a = (double)1.45; //ввел все переменные
            while ( x <= 1 & x>=0) //сделал цикл с двойным условием
            {
                y = (double)x + b * x * Math.Sin(a); //ввел формулу
                Console.WriteLine(y); //вывод значения
                x = x + 0.1; //сделал шаг=0.1
            }
        }
    }
}
