using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variablevariety
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int    a = 9;
            double b = 7.55;
            string c = "Hello World";
            bool   d = true;
            char   e = 'z';
            
            Console.WriteLine("Tampilkan variabel yang tepat menggunakan tipe data yang tepat pula!");
            Console.WriteLine();
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.ReadKey();
        }
    }
}
