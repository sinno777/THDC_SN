using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH_THDC_B1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 0  1   2  3  4  5  6  7  8  9
            // 10 11 12 13 14 15 16 17 18 19
            //for (int i = 0; i <= 99; i++)
            //{
            //    if (i != 0 && i % 10 == 0)
            //        Console.Write($"\n\t{i}");
            //    else
            //        Console.Write($"\t{i}");

            //}

            Console.Write("Nhap vao canh cua hinh vuong:    ");
            int Canh = Convert.ToInt32(Console.ReadLine());
            int DienTich = Canh * Canh;
            int ChuVi = Canh * 4;

            Console.WriteLine($"Dien Tich cua hinh vuong là:    {DienTich}");
            Console.Write($"Chu Vi cua hình vuông là:   {ChuVi}");


            Console.ReadKey();

        }
    }
}
