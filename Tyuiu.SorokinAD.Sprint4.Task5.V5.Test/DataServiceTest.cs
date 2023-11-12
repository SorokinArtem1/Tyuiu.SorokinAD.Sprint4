using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SorokinAD.Sprint4.Task5.V5.Lib;

namespace Tyuiu.SorokinAD.Sprint4.Task5.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] array = new int[3,3] { { -3, -5, -1 }, { 2, 3, -1 },{ 0, 8, 2 } };
            int res = ds.Calculate(array);
            int wait = 15;
            Assert.AreEqual(wait, res);
        }
    }
}
