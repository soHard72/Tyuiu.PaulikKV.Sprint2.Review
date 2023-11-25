using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PaulikKV.Sprint2.TaskReview.V1.Lib;

namespace Tyuiu.PaulikKV.Sprint2.TaskReview.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 1;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = false;
            Assert.AreEqual(wait, res);
        }
    }
}
