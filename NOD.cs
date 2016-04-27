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

            
            while (a != 0 && b != 0) //цикл продолжается пока число останется без остатка т.е. будет ровно 0, если остатка нету, то число и есть НОД
                if (a > b) // если останется остаток от деления, то большее число заменяем остатком
                     { 
                    a = a % b;
                        }
                else {
                    b = b % a;
                        }


            Console.WriteLine(a + b);
            Console.ReadKey();

        }
    }
}
