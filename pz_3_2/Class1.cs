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
        
        private int id = 0;
        private DateTime START = DateTime.UtcNow;
        private DateTime END = DateTime.Now;
        public float summ;                                              //поля и переменные 
        public string carID;
        private int ID;


        private DateTime startTime;
        private DateTime endTime;
       
        public ParkingTicket()
        {         
            ID = 0; 
            summ = 0;
            carID = "НЕИЗВЕСТНО";
            startTime = DateTime.UtcNow;                                //Если значение пользователе не будет присвоено
            endTime = DateTime.Now;
            

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


        }       //Варианты с различными введенными значениями
        public void GetTicketInfo()                                     //Классный метод с выводом описания текущего объекта
        {
            Console.WriteLine($"\nВаш уникальный номер талона:{ID}\n" +
                $"Стоимость парковки:{summ}\nВремя начала парковки:{startTime}\n" +
                $"Время окончания парковки:{endTime}\nНомер авто:{carID}\n");


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
