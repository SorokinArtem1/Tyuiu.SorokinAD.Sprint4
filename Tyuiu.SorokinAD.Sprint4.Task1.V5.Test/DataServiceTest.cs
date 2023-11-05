using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SorokinAD.Sprint4.Task1.V5.Lib;

namespace Tyuiu.SorokinAD.Sprint4.Task1.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = { 9, 6, 6, 9, 7, 8, 5, 9, 6, 6, 8, 6, 8, 6, 7 };
            int res = ds.Calculate(array);
            int wait = 60;
            Assert.AreEqual(wait, res);
            
        }
    }
}
