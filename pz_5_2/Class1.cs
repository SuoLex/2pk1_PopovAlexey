using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//          Член класса название особенности
//          поле ID Уникальный номер талона
//          поле summ Стоимость парковки
//          поле startTime Время начала парковки
//          поле endTime Время окончания парковки
//          поле carID Номер авто
//          метод GetTicketInfo() выводит описание текущего объекта
namespace pz_5._2
{
    public class ParkingTicket
    {
        static int All_sum = 0;                                             //два статика, потому что попросили (общая сумма талонов и общая сумма всех талонов)
        static float All_price = 0;
        private int id = 0;
        private DateTime START = DateTime.UtcNow;
        private DateTime END = DateTime.Now;
        public float summ;                                              //поля и переменные 
        public string carID;
        public TimeSpan interval;                                       //ИНТЕРВАЛ ДЛЯ ТОГО, ЧТОБЫ СЧИТАТЬ СУММУ ПАРКОВКИ
        private int ID
        {
            set
            {
                if (value == 0)
                {
                    Console.WriteLine("\n!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!Непустые значения ID!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                }
                else { id = value; }
            }
            get { return id; }
        }
        private DateTime startTime
        {
            set
            {
                if (value > endTime)
                {
                    Console.WriteLine("\nВремя начала парковки строго меньше времени окончания");
                }
                else { START = value; }
            }
            get
            {
                return START;
            }
        }
        private DateTime endTime
        {
            set
            {
                if (value < startTime)
                {
                    Console.WriteLine("\nВремя начала парковки строго меньше времени окончания");
                }
                else { END = value; }
            }
            get
            {
                return END;
            }
        }
        //------------------------------------------------------------------------------------------------------------------------
        public ParkingTicket()
        {
            ID = 0;
            summ = 0;
            carID = "НЕИЗВЕСТНО";
            startTime = DateTime.UtcNow;                                //Если значение пользователе мне будте присвоено
            endTime = DateTime.Now;
            interval = endTime - startTime;


        }
        public ParkingTicket(int ID)
        {
            this.ID = ID;
        }                                                               //Варианты с различными введенными значениями

        public ParkingTicket(string carID)
        {
            this.carID = carID;
        }                                                              //Варианты с различными введенными значениями
        public ParkingTicket(int ID, string carID)
        {
            this.ID = ID;
            startTime = DateTime.UtcNow;
            endTime = DateTime.Now;
            this.carID = carID;
            interval = endTime - startTime;
            summ = 50 * interval.Hours;

        }       //Варианты с различными введенными значениями
                //------------------------------------------------------------------------------------------------------------------------
        public void GetTicketInfo()                                     //Классный метод с выводом описания текущего объекта
        {
            All_sum += 1;
            All_price += summ;
            Console.WriteLine(
                $"\nВаш уникальный номер талона:{ID}" +
                $"\nНомер авто:{carID}" +
                $"\nВремя начала парковки:{startTime}" +
                $"\nВремя окончания парковки:{endTime}" +
                $"\nСтоимость парковки:{summ}" +
                $"\n\n Общая сумма талонов:{All_sum}" +
                $"\nОбщая стоимость всех талонов:{All_price}\n");
        }

    }
    public class SpecialParkingTicket : ParkingTicket                   //Парковочный талон постоянного клиента
    {
        public int SKIDKA = 10;
        public float skidka
        {
            set { SKIDKA = Convert.ToInt32(value);
                
            }
            get { return SKIDKA; }
        }
        public void Ticket()
        {
            Console.WriteLine(skidka);
        }
        
    }
    public class Pizza                                                  //Вспомогательный класс, который помогает обозначить какие данные были введены
    {
        public Pizza(int ID, string carID)
        {
            int a = 0;
            try
            {
                if (a == 0)
                {
                    ParkingTicket pt = new ParkingTicket(ID, carID); pt.GetTicketInfo();
                }
                a++;
            }
            catch { }
            try
            {
                if (a == 0)
                {
                    ParkingTicket pt = new ParkingTicket(ID); pt.GetTicketInfo();
                }
                a++;
            }
            catch { }
            try
            {
                if (a == 0)
                {
                    ParkingTicket pt = new ParkingTicket(carID); pt.GetTicketInfo();
                }
                a++;
            }
            catch { }
        }
    }
}

