using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[n, m];
            int[] tmp = new int[m];
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    tmp[j] = arr[i, j];
                }
                Array.Sort(tmp);
                for(int k = 0; k < m; k++)
                {
                    arr[i, k] = tmp[k];
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    tmp[j] = arr[j, i];
                }
                Array.Sort(tmp);
                for (int k = 0; k < n; k++)
                {
                    arr[k, i] = tmp[k];
                }
            }


            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }
    }
}
