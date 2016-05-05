using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication20
{
    class Program
    {
        public static string dirD = "D:\\";
        static void Main(string[] args)
        {
            foreach (string i in SearchDirectory(dirD))
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
        static string[] SearchDirectory(string patch)
        {
            
            string[] ResultSearch = Directory.GetDirectories(patch);
            
            return ResultSearch;
        }
        
        
    }

    }

