using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nama;
            int umur, tahun;
            Console.WriteLine("=================================================");
            Console.WriteLine("Aplikasi Cek Umur");
            Console.WriteLine("=================================================");
            Console.WriteLine("\nMasukan nama anda :");
            nama = Console.ReadLine();
            Console.WriteLine("Masukan tahun lahir anda :");
            tahun = int.Parse(Console.ReadLine());
            Console.WriteLine("\n===============================================");
            umur = 2024 - tahun;
            Console.WriteLine("Nama Anda : {0}", nama);
            Console.WriteLine("Umur Anda : {0} tahun", umur);
            Console.ReadKey();
        }
    }
}
