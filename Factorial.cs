using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication18
{

    class Program
    {
        
        static int F(int n)
        {
            inn(n);
            int res;
            if (n == 0)
            {
                res = 1;
            }
            if (n == 1)
            {

                res = 1;
            }

            else

            {
                
                res = n * F(n - 1);
                resRes(res);

            }
            outt(n);
            return res;
        }
        public static void resRes(int x)
        {
            spaces();
            Console.WriteLine( " === "  + x);
        }
        public static void inn(int x)
        {
            spaces();
            Console.WriteLine("(" + x + ")->");
            
        }
        public static void outt(int x)
        {
            spaces();
            Console.WriteLine("(" + x + ")<-");
        }
        private static void spaces()
        {
            
                Console.Write("  *   ");
        }
        static void Main()
        {

            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("факториал числа :{0} = {1}", n, F(n));
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}



