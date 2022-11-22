using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH_THDC_B4_bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            // check input
            bool flag = true;
            int n = 0;
            bool reVal; 
            do
            {
                Console.Write("Import n > 0: ");
                reVal = int.TryParse(Console.ReadLine(),out n);
                if (n > 0)
                {
                    flag = false;
                }
                if (reVal == false)
                {
                    flag = false;
                }
            } while (flag);
            // loop arr to search number % 3 = 0 
            for(int i = 1; i <= n; i++)
            {
                if(i % 3 == 0)
                {
                    Console.Write($"{i} \t");
                }
            }
            Console.ReadKey();
        }
    }
}
