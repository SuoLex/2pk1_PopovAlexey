using System;

namespace pz_5 //Попов Алексей 2ПК1 Вариант 17 на всякий случай подпишу
{
    class Program
    {
        static void Main(string[] args)
        {//Задание №1 Вариант 17
            Console.WriteLine("Задание №1");
            int i; //задал переменную i
            for (i = 10; i <= 80; i=i + 4) //сделал цикл: от 10 до 80 в шаге = 4
            {
                Console.WriteLine(i); //каждое значение цикла будет выводиться
            }
            //Задание №2 Вариант 17
            Console.WriteLine("Задание №2");
            int n; //задал переменную n 
            for (n=1;n<=7;n++) //сделал цикл: от 1 до 7 в шаге = 1
            {
                Console.Write("B"); //Без перехода на новую строчку пишу "B"
            }
            Console.WriteLine();
            //Задание №3 Вариант 17
            Console.WriteLine("Задание №3");
            int e; //задал переменную e
            for (e=1; e<=7;e++) //сделал цикл
            {
                Console.WriteLine("#######");
            }
            //Задание №4 Вариант 17
            Console.WriteLine("Задание №4");
            int o; //задал переменную o
            for (o=5; o<=100;o=o+5) //сделал цикл
            {
                Console.WriteLine(o);
            }
            //Задание №5 Вариант 17
            Console.WriteLine("Задание №5");
            int i1 = 5; //Ввожу необходимые переменные
            int j = 70;
            int k;
            int p = (j-i1-19)/2; //формула для подсчета кол-ва операций, где p - кол-во операций
            for (k = 0;k<=p; i1++,k++) //Цикл 
            {
                    Console.WriteLine($"i={i1}, j={j}, их разница ={j - i1}"); //вывод значений
                    j = j - 1;
            }
        }
    }
}
