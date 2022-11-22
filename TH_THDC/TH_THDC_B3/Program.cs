using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH_THDC_B3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap ban kinh cua hinh cau:  ");
            int bk = Convert.ToInt32(Console.ReadLine());
            double The_tich = (4*Math.PI*Math.Pow(bk,3))/ 3;
            Console.WriteLine($"The Tich cua Hinh cau la: {The_tich:0.00}");
        }
    }
}
