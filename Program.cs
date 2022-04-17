using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToAndFrom
{
    internal class Program
    {

        public static int ToAndFrom(int a, int b, int t)
        {
            int here = 0;


            return here;
        }

        static void Main(string[] args)
        {
            int a = Convert.ToInt32( Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int t = Convert.ToInt32(Console.ReadLine());

            int here = ToAndFrom(a, b, t);
            
            Console.WriteLine(here);


        }
    }
}
