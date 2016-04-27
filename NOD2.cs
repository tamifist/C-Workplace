using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());


            while (a != b)  // пока не станут равными

               {
                if (a > b)  // которая состоит из меньшего числа и разницы между большим и меньшим числом
                {
                    a = a - b; 
                }else
                {
                    b = b - a;
                }

            }


            Console.WriteLine(a); // найденное число
            Console.ReadKey();

        }
    }
}
