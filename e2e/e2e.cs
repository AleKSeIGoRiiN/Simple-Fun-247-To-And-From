using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using GUi;

namespace e2e
{
    [TestClass]
    public class e2e
    {
        [TestMethod]
        public void arg1Test()
        {
            Form1 f = new Form1();
            int arg1 = f.inputArg1();
            Assert.AreEqual(typeof(int), arg1.GetType());
        }
        [TestMethod]
        public void arg2Test()
        {
            Form1 f = new Form1();
            int arg2 = f.inputArg2();
            Assert.AreEqual(typeof(int), arg2.GetType());
        }

        [TestMethod]
        public void arg3Test()
        {
            Form1 f = new Form1();
            int arg3 = f.inputArg3();
            Assert.AreEqual(typeof(int), arg3.GetType());
        }
    }
}
