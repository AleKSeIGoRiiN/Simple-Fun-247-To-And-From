using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToAndFrom
{


    public class CodewarsTask  //решение задачи
    {
        public int ToAndFrom(int a, int b, int t)
        {
            
            int passages;
            int chek;
            int result = 0;

            

            if (t >= 3 && a != b && a>=1 && b>=1)
            {
                if (a < b)
                {

                    if (t <= (b - a))
                    {
                        result = a + t;
                    }
                    else
                    {
                        passages = t % (b - a);
                        chek = t / (b - a);

                        if(chek % 2 == 0)
                        {
                            result = a + passages;
                        }
                        else
                        {
                            result = b - passages;
                        }
                        
                    }

                }
                else if (a > b)
                {

                    if (t <= (b - a) * (-1))
                    {
                        result = a - t;
                    }
                    else
                    {
                        passages = t % ((b - a) * (-1));
                        chek = t / ((b - a) * (-1));
                        if (chek % 2 != 0)
                        {
                            result = a - passages;
                        }
                        else
                        {
                            result = b + passages;
                        }


                    }
                }
            }

            return result;
        }


        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int t = Convert.ToInt32(Console.ReadLine());

            CodewarsTask solution = new CodewarsTask();

            int result = solution.ToAndFrom(a, b, t);
            
            if(result == 0)
            {
                Console.WriteLine(result);
                Console.WriteLine("incorrect data entered");
                Console.ReadKey(true);
            }
            else
            {
                Console.WriteLine(result);
                Console.ReadKey(true);
            }
            

        }

    }
   

}
