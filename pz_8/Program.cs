using System;

namespace pz_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Попов Алексей 2ПК1 Вариант 17
            int[] A = new int[10]; //создал массив
            Random rdm = new Random();
            for (int i = 0; i <= 9; i++)
            {
                A[i] = rdm.Next(1, 50); //ввел в массив рандомные числа
            }
           
            Array.Sort(A); //отсортировал массив по возрастанию
            for (int i = 0; i <=9; i++)
            {
                if (A[i] > 9) //если число было больше 9, то находилась сумма цифр по такому принципу:
                {
                    int a = A[i] / 10; //находим цифру первого разряда
                    int b = A[i] % 10; //находим цифру второго разряда
                    int cel = a + b; //складываем цифры двух разрядов
                    Console.WriteLine($"сумма цифр числа {A[i]}={cel}"); //вывод
                }
                else //если число от 1 до 9, то сумма цифр числа = самому числу
                {
                    int cell = A[i];
                    Console.WriteLine($"сумма цифр числа {A[i]}={cell}"); //вывод
                }
            }
        }
    }
}
