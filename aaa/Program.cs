using System;

namespace aaa
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] W = { 1, 5, 2, 4, 5, 28, 4, 1 };
            int h1 = 0; int h2 = 0;
            Array.Sort(W); Array.Reverse(W);
               for (int i = 0; i< W.Length; i++)
               { if (h1 < h2)
                {
                    h1 = h1 + W[i];
                }
               else
                {
                    h2 = h2 + W[i];
                }
                
            }
            Console.WriteLine(h1);
            Console.WriteLine(h2);


        }
    }
}
