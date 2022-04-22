using System;

namespace pz_9_2
{
    public delegate int MyDelegate(int max);

class Visitor
    {
        static int args;
        public event MyDelegate Event;
        public int Visitor1(int max)
        {
            for (int i = 0; i < max; i++)
            {
                args = i + 1;
                Event?.Invoke(args);
            }
            if (max < 0) Console.WriteLine("Введите корректное значение");
            
            
            return 0;
        }
    }
    class Program
    {
         static void Main(string[] args)
        {
      
            
            Console.Write("Введите количество посетителей:");
            int max;
            try { max = Convert.ToInt32(Console.ReadLine()); }
            catch { max = -1; }


            Visitor controller = new Visitor();
            controller.Event += Visitor_Event;
            controller.Visitor1(max);

            }

        private static int Visitor_Event(int max)
        {
            Console.Write($"Посетитель {max} ");
            if (max > 30) Console.WriteLine("- стоит ограничение мест! Не больше 30!");
            
            else Console.WriteLine("- успешно");
            
            return 0;
        }

        

    }
  
}
