﻿using System;
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
                if (a > b)
                {
                    a = a - b;
                }else
                {
                    b = b - a;
                }

            }


            Console.WriteLine(a);
            Console.ReadKey();

        }
    }
}
