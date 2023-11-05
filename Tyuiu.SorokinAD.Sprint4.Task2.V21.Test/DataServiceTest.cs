using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SorokinAD.Sprint4.Task2.V21.Lib;

namespace Tyuiu.SorokinAD.Sprint4.Task2.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 1, 2, 3, 4, 5, 6, 7, 1 };
            int res = ds.Calculate(array);
            int wait = 2304;
            Assert.AreEqual(wait, res);
        }
    }
}
