using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] vodka =  new int[10];
            int max = 0;
            for(int i = 0;i<vodka.Length;i++)
            {
                vodka[i] = Convert.ToInt32(Console.ReadLine());
                if (vodka[i] > max) //если введнное число с консоли больше предыдущего, то оно заменяется
                {
                    max = vodka[i];
                }
            }
           
            Console.WriteLine(max);
            Console.ReadKey();
            

        }
    }
}
