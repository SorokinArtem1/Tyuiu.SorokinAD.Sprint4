using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SorokinAD.Sprint4.Task0.V2.Lib;

namespace Tyuiu.SorokinAD.Sprint4.Task0.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = { 5, 3, 7, 1, 3, 9, 8, 7, 9, 4 };
            int res = ds.GetSumOddArrEl(array);
            int wait = 44;
            Assert.AreEqual(wait, res);
        }
    }
}
