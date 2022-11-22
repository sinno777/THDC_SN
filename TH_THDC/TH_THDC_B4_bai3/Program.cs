using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH_THDC_B4_bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            // check input
            int i;
            int n;
            bool reVal = true;
            Console.Write("Import n: ");
            n = int.Parse(Console.ReadLine());
            do
            {
                Console.Write("Import n > 0: ");
                reVal = int.TryParse(Console.ReadLine(), out n);

            } while (!reVal || n < 0);

         
            for( i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    break;
                }
            }
            if(i == n)
                Console.Write($"{n} la so nguyen to");
            else
                Console.Write($"{n} khong la so nguyen to");

            Console.ReadKey();
        }
    }
}
