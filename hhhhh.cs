using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication21
{
    class Program
    {
        static string dir = "D:\\";
        static string[] dirArray = Directory.GetDirectories(dir);
        static void Main(string[] args)
        {
            searchDir(dirArray,dirArray.Length);
        }

        static void searchDir (string[] dirArray, int count)
        {
            if(count > 0)
            {

                searchDir(dirArray, count - 1);
            }
        }


    }
}
