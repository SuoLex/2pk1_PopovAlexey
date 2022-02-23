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
namespace pz_3._2
{
    public class ParkingTicket
    {
        static int All_sum = 0;                                             //два статика, потому что попросили (общая сумма талонов и общая сумма всех талонов)
        static int All_price = 0;
        private int id = 1;
        private DateTime START = DateTime.UtcNow;
        private DateTime END = DateTime.Now;
        public int price;                                               //Сумма парковки
        public float summ;                                              //поля и переменные 
        public string carID;
        public TimeSpan interval;                                       //ИНТЕРВАЛ ДЛЯ ТОГО, ЧТОБЫ СЧИТАТЬ СУММУ ПАРКОВКИ
        private int ID
        {
            set
            {
                if (value == 0)
                {
                    Console.WriteLine("\nНепустые значения ID");
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
                if (value<startTime)
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
            price = 0;

        }
        public ParkingTicket(int ID)
        {
            this.ID = ID;
        }                                 //Варианты с различными введенными значениями
        public ParkingTicket(float summ)
        {
            this.summ = summ;
        }                             //Варианты с различными введенными значениями
        public ParkingTicket(string carID)
        {
            this.carID = carID;
        }                           //Варианты с различными введенными значениями
        public ParkingTicket(int ID, float summ)
        {
            this.ID = ID;
            this.summ = summ;
        }                     //Варианты с различными введенными значениями
        public ParkingTicket(int ID, string carID)
        {
            this.ID = ID;
            this.carID = carID;
        }                   //Варианты с различными введенными значениями
        public ParkingTicket(float summ, string carID)
        {
            this.summ = summ;
            this.carID = carID;
        }               //Варианты с различными введенными значениями
        public ParkingTicket(int ID, float summ, string carID)
        {
            this.ID = ID;
            this.summ = summ;
            startTime = DateTime.UtcNow;
            endTime = DateTime.Now;
            this.carID = carID;
            interval = endTime - startTime;
            price = 50 * interval.Hours;

        }       //Варианты с различными введенными значениями
        public void GetTicketInfo()                                     //Классный метод с выводом описания текущего объекта
        {
            All_sum += 1;
            All_price += price;
            Console.WriteLine($"\nВаш уникальный номер талона:{ID}\n" +
                $"Стоимость парковки:{summ}\nВремя начала парковки:{startTime}\n" +
                $"Время окончания парковки:{endTime}\nНомер авто:{carID}\n" +
                $"Ваша цена за парковку:{price} рублей\n" +
                $"\n Общая сумма талонов:{All_sum}\n" +
                $"Общая стоимость всех талонов:{All_price}");

        }
    }
    public class Pizza                                                  //Вспомогательный класс, который помогает обозначить какие данные были введены
    {
        public Pizza(int ID, float summ, string carID)
        {
            int a = 0;
            try
            {
                if (a == 0)
                {
                    ParkingTicket pt = new ParkingTicket(ID, summ, carID); pt.GetTicketInfo();
                    a++;
                }
            }
            catch { }
            try
            {
                if (a == 0)
                {
                    ParkingTicket pt = new ParkingTicket(ID, summ); pt.GetTicketInfo();
                }
                a++;
            }
            catch { }
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
                    ParkingTicket pt = new ParkingTicket(summ, carID); pt.GetTicketInfo();
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
                    ParkingTicket pt = new ParkingTicket(summ); pt.GetTicketInfo();
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
