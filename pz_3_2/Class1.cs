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
        public int ID; //сделать приват и прописать свойства
        public float summ;
        public DateTime startTime;
        public DateTime endTime;
        public string carID;

        public ParkingTicket()
        {
            ID = 0;
            summ = 0;
            carID = "НЕИЗВЕСТНО";
            startTime = DateTime.Now;
            endTime = DateTime.Now;

        }
        public ParkingTicket(int ID)
        {
            this.ID = ID;
        }
        public ParkingTicket(float summ)
        {
            this.summ = summ;
        }
        public ParkingTicket(string carID)
        {
            this.carID = carID;
        }
        public ParkingTicket(int ID, float summ)
        {
            this.ID = ID;
            this.summ = summ;
        }
        public ParkingTicket(int ID, string carID)
        {
            this.ID = ID;
            this.carID = carID;
        }
        public ParkingTicket(float summ, string carID)
        {
            this.summ = summ;
            this.carID = carID;
        }
        public ParkingTicket(int ID, float summ, string carID)
        {
            this.ID = ID;
            this.summ = summ;
            startTime = DateTime.Now;
            endTime = DateTime.Now;
            this.carID = carID;
        }

        public void GetTicketInfo()
        {
            Console.WriteLine($"\nВаш уникальный номер талона:{ID}\nСтоимость парковки:{summ}\nВремя начала парковки:{startTime}\nВремя окончания парковки:{endTime}\nНомер авто:{carID}\n");
        }

    }
    public class Pizza
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
