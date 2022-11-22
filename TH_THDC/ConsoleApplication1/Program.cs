using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        // input n element,loop arrray and export max value element
        static void Main(string[] args)
        {
            Console.Write("Import n: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            // import arr
            for(int i = 0; i<=n; i++)
            {
                Console.Write($"a[{i}]: ");
                a[i] = int.Parse(Console.ReadLine());
            }
            // export arr
            for (int i = 0; i <= n; i++)
            {
                Console.Write(a[i] + "\t");
            }

            Console.ReadKey();
        }
    }
}
