using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lingkaran
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int r;
            double luas, keliling;
            Console.WriteLine("=========================================================");
            Console.WriteLine("Mesin Pencari Luas dan Keliling Lingkaran Otomatis");
            Console.WriteLine("=========================================================");
            Console.WriteLine("\nCarilah luas dan keliling lingkaran jika phi = 3,14!");
            Console.WriteLine("Masukan r : ");
            r = int.Parse(Console.ReadLine());
            luas = r * r * (3.14);
            keliling = 2 * (3.14) * r;
            Console.WriteLine("\nHasilnya : ");
            Console.WriteLine("\nLuas " + luas);
            Console.WriteLine("Keliling " +  keliling);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("hint : gunakan tipe data yang tepat!");
            Console.ReadKey();
        }
    }
}
