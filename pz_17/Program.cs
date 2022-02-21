using System;

namespace pz_17
{
    class Program
    {
        static int Burger( int[] massiv)
        {
             
            int o = 0;
            int e = 1;
            for (int i = 0; i < massiv.Length; i++)
            {
                e = massiv[i];

                while (e % 2 == 0 & e > 0)
                {
                    e = e / 2;
                    if (e == 1)
                    { o++; }
                }

            }
           

            Console.WriteLine($"Количетсво чисел, которые являются степенью числа 2:{o}");
            return 0;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите числа и далее нажмите ENTER:");
            string a = "1";
            int aa = 0;
            int[] massiv = new int[1];
            int[] massiv2 = new int[1];


            for (int o=0;a!="";o++)
            {
                
                a = Console.ReadLine();
                if (a != "" & aa==0)
                {
                    massiv2 = new int[massiv.Length+1];
                    for (int q = 0; q < massiv.Length; q++)
                    {
                        massiv2[q] = massiv[q];
                    }
                    

                    massiv=null;
                    aa=1;
                    massiv2[o] = Convert.ToInt32(a);
                }
                else if (a!="" & aa==1)
                {
                    massiv = new int[massiv2.Length + 1]; 
                    for (int q = 0; q < massiv2.Length; q++)
                    {
                        massiv[q] = massiv2[q];
                    }


                    massiv2 = null;
                    aa = 0;
                    massiv[o] = Convert.ToInt32(a);
                }
            }
            if(massiv==null)
            {
                massiv = new int[massiv2.Length];
                for (int q = 0; q < massiv2.Length; q++)
                {
                    massiv[q] = massiv2[q];
                }
            }
            
            Burger( massiv);


        }
    }
}