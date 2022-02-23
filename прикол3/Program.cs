using System;

namespace прикол3
{
    class Program
    {
        static void Main(string[] args)
        {   
            DateTime startTime;
            DateTime endTime;
            TimeSpan apsdkalsd;
            startTime = DateTime.UtcNow;
            endTime = DateTime.Now;
            apsdkalsd = endTime - startTime;
            Console.WriteLine(apsdkalsd.Hours*50);
        }
    }
}
