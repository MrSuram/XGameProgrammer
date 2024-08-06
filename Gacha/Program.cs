using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gacha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int num = 0;
            Console.Write("Trigger gacha? : Y/N ");
            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                Console.WriteLine();
                num = rnd.Next(100);
                Console.WriteLine("Your number is : {0}", num);
                if (num <= 40)
                {
                    Console.WriteLine("Dapet C Tier");
                }else if(num <=70)
                {
                    Console.WriteLine("Dapet B Tier");
                }else if(num <= 90)
                {
                    Console.WriteLine("Dapet A Tier");
                }else if (num <= 100)
                {
                    Console.WriteLine("Dapet S Tier");
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Out of Range!");
                }
            }else if(Console.ReadKey().Key == ConsoleKey.N)
            {
                Console.WriteLine("BYE!");
            }
            else
            {
                throw new Exception("\nINPUT SOMETHING!");
            }
        }
    }
}
