using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToAndFrom;
using System.IO;

namespace GUi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public StreamWriter Writer = new StreamWriter("C:\\Users\\lllll\\Documents\\GitHub\\Simple-Fun-247-To-And-From\\input.txt");

        public int inputArg1()
        {
            int arg1 = Convert.ToInt32(edStart);
            return arg1;
        }

        public int inputArg2()
        {
            int arg2 = Convert.ToInt32(edEnd);
            return arg2;
        }

        public int inputArg3()
        {
            int arg3 = Convert.ToInt32(edTime);
            return arg3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Data data = new Data();

            Writer.WriteLine(inputArg1());
            Writer.WriteLine(inputArg2());
            Writer.WriteLine(inputArg3());
            data.reader.Close();

            int a = data.inputArg1();
            int b = data.inputArg2();
            int t = data.inputArg3();
            data.reader.Close();

            CodewarsTask solution = new CodewarsTask();

            int result = solution.ToAndFrom(a, b, t);
            data.writer(result);
            data.wr.Close();

            if (result == 0)
            {
                sul.Text = "incorrect data entered";
            }
            else
            {
                sul.Text = Convert.ToString(result);
            }
        }
    }
}
