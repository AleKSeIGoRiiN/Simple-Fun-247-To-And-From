using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;


namespace ToAndFrom
{
    public class Data // Ввод данных с файла и вывод
    {
        public StreamWriter wr = new StreamWriter("C:\\Users\\lllll\\Documents\\GitHub\\Simple-Fun-247-To-And-From\\output.txt");
        public StreamReader reader = new StreamReader("C:\\Users\\lllll\\Documents\\GitHub\\Simple-Fun-247-To-And-From\\input.txt");
       

        public int inputArg1()
        {

            int a = Convert.ToInt32(reader.ReadLine());
            return a;
        }
        public int inputArg2()
        {
            int b = Convert.ToInt32(reader.ReadLine());
            return b;
        }
        public int inputArg3()
        {
            int t = Convert.ToInt32(reader.ReadLine());
            return t;
        }

        public void writer(int result)
        {
            wr.WriteLine(result);
        }
    }

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
            Data data = new Data();


            int a = data.inputArg1();
            int b = data.inputArg2();
            int t = data.inputArg3();
            data.reader.Close();

            CodewarsTask solution = new CodewarsTask();

            int result = solution.ToAndFrom(a, b, t);
            data.writer(result);
            data.wr.Close();
            
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
