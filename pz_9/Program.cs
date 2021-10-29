using System;

namespace pz_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int M = rnd.Next(1, 10); //делаем рандом двумерный массив
            Console.WriteLine($"Кол-во столбцов={M}");
            int N = rnd.Next(1, 10); //делаем рандом двумерный массив
            Console.WriteLine($"Кол-во строк={N}");
            string [] q = { "Q","W","E","R", "T", "Y", "U", "I", "O", "P", "A", "S", "D", "F", "G", "H", "J", "K", "L", "Z", "X", "C", "V", "B", "N", "M", }; //сделал "библиотеку" рандом символов английского алфавита
            string [,] A = new string[M,N]; //сделал двумерный массив
            int i = 1;
            int f = 1;
            int QQ=0, WW=0, EE=0, RR=0, TT=0, YY=0;
            for (i = 0; i < M; i++)
            {
                for (f = 0; f < N; f++)
                {
                    int qq = rnd.Next(q.Length); // Сделал рандом число, подходящее для библиотеки (от 0 до 26)
                    if (qq==0)
                    {
                        QQ++;
                    }
                    else if (qq==1)
                    {
                        WW++;
                    }
                    else if (qq == 2)                // Вот вопрос, а мне так нужно со всеми переменными сделать?) или есть способ полегче
                    {
                        EE++;
                    }
                    else if (qq == 3)
                    {
                        RR++;
                    }
                    else if (qq == 4)
                    {
                        TT++;
                    }
                    else if (qq == 5)
                    {
                        YY++;
                    }
                    A[i, f] = q[qq];
                    Console.Write($"{A[i, f]} "); //вывод массива в красивом виде
                }
                Console.WriteLine();
            }
            Console.WriteLine($"В двумерном массиве кол-во символов Q={QQ}");
            Console.WriteLine($"В двумерном массиве кол-во символов W={WW}");
            Console.WriteLine($"В двумерном массиве кол-во символов E={EE}");
            Console.WriteLine($"В двумерном массиве кол-во символов R={RR}");     //такое 26 раз тоже не хочется делать, но я могу впринципе
            Console.WriteLine($"В двумерном массиве кол-во символов T={TT}");
            Console.WriteLine($"В двумерном массиве кол-во символов Y={YY}");






        }
    }
}
