using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication15
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[n, m];
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            int sumGD = 0;
            int sumLGD = 0;
            int sumHGD = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (i == j)
                    {
                        sumGD += arr[i, j];
                    }
                    if (i < j)
                    {
                        sumHGD += arr[i, j];
                    }
                    if (i > j)
                    {
                        sumLGD += arr[i, j];
                    }


                }
            }

            int sumPD = 0;
            int sumLPD = 0;
            int sumHPD = 0;

            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                {

                    if (i == (m - j - 1))
                    {
                        sumPD += arr[i,j];
                    }
                    if (i > (m - 1 - j))
                    {
                        sumLPD += arr[i,j];
                    }
                    if (i < (m - 1 - j))
                    {

                        sumHPD += arr[i,j];
                    }
                }

            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }

            Console.WriteLine("сумма главной диагонали " + sumGD);
            Console.WriteLine("сумма под главной диагональю " + sumLGD);
            Console.WriteLine("сумма над главной диагональнью " + sumHGD);
            Console.WriteLine("сумма  побочной диагонали " + sumPD);
            Console.WriteLine("сумма под побочной диагональю " + sumLPD);
            Console.WriteLine("сумма над побочной диагональю " + sumHPD);


            Console.ReadKey();
        }
    }
}
