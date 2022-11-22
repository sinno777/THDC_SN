using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH_THDC_Buoi2_bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"mu 3 cua {n} la: {Math.Pow(n, 3)}");
            Console.ReadKey();

        }
    }
}
