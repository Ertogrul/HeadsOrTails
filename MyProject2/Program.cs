using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            for (int i = 1; i <= 10; i++)
            {
                int sayi = random.Next(2);
                Console.WriteLine(i+". Deneme:");
                if (sayi == 1)
                
                    Console.WriteLine("Yazı");
                else
                    Console.WriteLine("Tura");
            }
            Console.ReadLine();
        }
    }
}
