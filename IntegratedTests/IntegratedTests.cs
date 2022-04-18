using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using ToAndFrom;

namespace IntegratedTests
{

    [TestClass]
    public class IntegratedTests
    {
        public StreamReader wr = new StreamReader("C:\\Users\\lllll\\Documents\\GitHub\\Simple-Fun-247-To-And-From\\output.txt");
        public StreamReader reader = new StreamReader("C:\\Users\\lllll\\Documents\\GitHub\\Simple-Fun-247-To-And-From\\input.txt");
        [TestMethod]
        public void typeArg1Test() //проверка типа 
        {
            Data input = new Data();
            int result = input.inputArg1();
            Assert.AreEqual(typeof(int), result.GetType());

        }
        [TestMethod]
        public void typeArg2Test() //проверка типа 
        {
            Data input = new Data();
            int result = input.inputArg2();
            Assert.AreEqual(typeof(int), result.GetType());

        }
        [TestMethod]
        public void typeArg3Test() //проверка типа 
        {
            Data input = new Data();
            int result = input.inputArg3();
            Assert.AreEqual(typeof(int), result.GetType());

        }
        [TestMethod]
        public void ResultTest() //проверка решения алгоритма и записанного значения в файле
        {
            Data input = new Data();
            CodewarsTask Task = new CodewarsTask();
            int result = Task.ToAndFrom(Convert.ToInt32(reader.ReadLine()), Convert.ToInt32(reader.ReadLine()), Convert.ToInt32(reader.ReadLine()));
            int resultFile = Convert.ToInt32(wr.ReadLine());
            Assert.AreEqual(result, resultFile);

        }
    }
}
