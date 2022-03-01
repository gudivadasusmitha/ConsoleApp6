using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Books = new string[5];
            Books[0] = "c#";
            Books[1] = "java";
            Books[2] = "vb.net";
            Console.WriteLine("all the element of book array is");
            int i = 0;
            Console.WriteLine("\t1\t2\t3\t");
            for(i=0;i<5;i++)
            {
                Console.WriteLine("{0}\t", Books[i]);
            }
            Console.ReadLine();
            


        }
    }
}
