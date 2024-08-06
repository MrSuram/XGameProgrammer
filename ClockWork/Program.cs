using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sec;
            double minute, hour;
            Console.WriteLine("===================================");
            Console.WriteLine("Konversi Detik");
            Console.WriteLine("===================================");
            Console.WriteLine("\nMengubah detik menjadi Menit dan Jam");
            Console.WriteLine("\nMasukan Detik : ");
            sec = int.Parse(Console.ReadLine());
            minute = sec / 60;
            hour = minute / 60;
            Console.WriteLine("\n{0} menit" ,minute);
            Console.WriteLine("{0} jam",hour);
            Console.ReadKey();
        }
    }
}
