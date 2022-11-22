using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH_THDC_B2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] songuyen = new int[9];
            for(int i = 0; i <=8;i++)
            {
                Console.Write($"Nhap so thu songuyen[{i}]");
                songuyen[i] = Convert.ToInt32(Console.ReadLine());


            }
            int max = 0;
            for (int i = 0; i <= 8; i++)
            {
                if (songuyen[i] > max)
                    max = songuyen[i];
                Console.WriteLine($"Songuyen[{i}] la: {songuyen[i]}");
            }
            Console.WriteLine($"So lon nhat trong mang la:  {max}");
            Console.ReadKey();

        }
        
    }
}
