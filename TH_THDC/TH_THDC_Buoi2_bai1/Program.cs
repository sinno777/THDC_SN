using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH_THDC_Buoi2_bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nhap a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("nhap b: ");
            int b = int.Parse(Console.ReadLine());

            int tam;
            tam = b;
            b = a;
            a = tam; 
            Console.WriteLine($"So a sau khi hoa vi: {a}");
            Console.Write($"so b sau khi hoa vi: {b}");
            Console.ReadKey();
        }
    }
}
