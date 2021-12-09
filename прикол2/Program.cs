using System;
using System.IO;
//Дан текстовый файл inFile в который пользователь через консоль пишет произвольные
//данные. После завершения ввода, проанализировать текст на наличие чисел. Содержимое 
//файла и количество чисел в тексте вывести на консоль Используйте цикл для ввода.
namespace прикол2
{
    class Program
    {
        static void Main(string[] args)
        {
            string b = " "; //просто переменные для ввода текста
            string a="";
            while(b!="") //пока пользователь не нажмет на энтер, будет выполняться цикл
            {
                b = Console.ReadLine();
                a = a + b + " ";
                Console.WriteLine(a); 
            }
            Console.WriteLine(a);
            StreamWriter writer = new StreamWriter(@"C:\Users\papov\Desktop\inFile.txt");
            writer.Write(a);
            int num;
            int e = 0;
            string[] massiv = a.Split(); //разделила текст 
            for (int i=0; i<massiv.Length; i++) //прошла по каждому элементу и если элемент=цифра, то прибавляла счетчик цифр
            {
                bool numTrue = int.TryParse(massiv[i], out num);
                if (numTrue) e++;
                numTrue = false;
            }
            Console.WriteLine(e);
            writer.Close();
        }
    }
}
