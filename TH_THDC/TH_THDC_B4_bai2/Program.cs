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
            int n;
            bool reVal =true; 
            do
            {
                Console.Write("Import n > 0: ");
                reVal = int.TryParse(Console.ReadLine(),out n);
                
            } while (!reVal || n < 0);
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
