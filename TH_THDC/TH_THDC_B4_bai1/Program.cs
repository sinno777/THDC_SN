using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH_THDC_B4_bai1
{
    class Program
    {
        // Import Arrray
        static int[] importArr(int n)
        {
            int[] a = new int[n];
            for(int i = 0; i<n; i++)
            {
                Console.Write($"a[{i}]: ");
                a[i] = int.Parse(Console.ReadLine());
            }
            return a;
        }
        // Export Arrray
        static void exportArr(int[] arr, int n )
        {
            Console.WriteLine("Array after import: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Arr[{i}]: {arr[i]} \t");
            }
        }
        // Search element

        // Handel main
        static void Main(string[] args)
        {
            Console.Write("Import n: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            int[] arr = importArr(n);
            exportArr(arr, n);
            //for(int i = 0; i <= n; i++)
            //{
            //    if(i == 0)
            //    {
            //        Console.Write()
            //    }
            //}
            Console.ReadKey();
        }
    }
}
