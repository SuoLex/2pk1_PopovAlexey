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
//       поле summ2 для подсчета суммы за парковку
namespace pz_3._2
{
    public class ParkingTicket
    {
        private int id = 1;
        
        private int ID //сделать приват и прописать свойства
        {
            set { if (value == 0)
                    {

                    Console.WriteLine("\nВведите норм значение в следующий раз");     
                }
            else { id = value; }

            
            
            }
            get { return id; }
            
        }
        public float summ;
        public DateTime startTime;
        public DateTime endTime ;
        public string carID;
        public int summ2;
        public TimeSpan apsdkalsd; 


        public ParkingTicket()
        {         
            ID = 0; 
            summ = 0;
            carID = "НЕИЗВЕСТНО";
            startTime = DateTime.UtcNow;
            endTime = DateTime.Now;
            apsdkalsd = endTime - startTime;
            summ2 = 50 * 3;

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
            startTime = DateTime.UtcNow;
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
