using System;

namespace pz_3._2
{//          Член класса название особенности
 //          поле ID Уникальный номер талона
 //          поле summ Стоимость парковки
 //          поле startTime Время начала парковки
 //          поле endTime Время окончания парковки
 //          поле carID Номер авто
 //          метод GetTicketInfo() выводит описание текущего объекта
    class Program
    {
        static void Main(string[] args)
        {
            string b = "";
            while (b == "")
            {
                Console.Write("Ваш уникальный номер талона:");
                int ID = 0;
                try
                {
                    ID = Convert.ToInt32(Console.ReadLine());
                }
                catch { }
                Console.Write("Стоимость парковки:");
                float summ = 0;
                try
                {
                    summ = Convert.ToInt32(Console.ReadLine());
                }
                catch { }

                Console.Write("Номер авто:");
                string carID = Console.ReadLine();

                if (carID == "") carID = "НЕИЗВЕСТНО";


                Pizza gtt = new Pizza(ID, summ, carID);
                Console.WriteLine("Если хотите продолжить, нажмите ENTER");
                b = Console.ReadLine();
            }

        }
    }
}