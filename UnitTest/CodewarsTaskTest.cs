using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ToAndFrom;

namespace UnitTest
{
    [TestClass]
    public class CodewarsTaskTest
    {
        // unit-тесты

        [TestMethod]
        public void algorithmTest() // работа алгоритма
        {
            CodewarsTask Task = new CodewarsTask();
            int arg1 = 10;
            int arg2 = 15;
            int arg3 = 6;
            int expected = 14;

            int result = Task.ToAndFrom(arg1, arg2, arg3);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void timeTest()  // третий аргумент (время) не может быть меньше трёх
        {
            CodewarsTask Task = new CodewarsTask();
            int arg1 = 125;
            int arg2 = 345;
            int arg3 = 2;
            int expected = 0;

            int result = Task.ToAndFrom(arg1, arg2, arg3);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void equalityTest() // первый и второй аргумент не могут быть равны
        {
            CodewarsTask Task = new CodewarsTask();
            int arg1 = 10;
            int arg2 = 10;
            int arg3 = 5;
            int expected = 0;

            int result = Task.ToAndFrom(arg1, arg2, arg3);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void positiveArg1Test() // первый аргумент должен быть положительный
        {
            CodewarsTask Task = new CodewarsTask();
            int arg1 = -1;
            int arg2 = 10;
            int arg3 = 8;
            int expected = 0;

            int result = Task.ToAndFrom(arg1, arg2, arg3);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void positiveArg2Test() // второй аргумент должен быть положительный
        {
            CodewarsTask Task = new CodewarsTask();
            int arg1 = 10;
            int arg2 = -17;
            int arg3 = 28;
            int expected = 0;

            int result = Task.ToAndFrom(arg1, arg2, arg3);
            Assert.AreEqual(expected, result);
        }
    }
}
