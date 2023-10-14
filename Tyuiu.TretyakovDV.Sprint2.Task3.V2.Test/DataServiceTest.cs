using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TretyakovDV.Sprint2.Task3.V2.Lib;
namespace Tyuiu.TretyakovDV.Sprint2.Task3.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression1()
        {
            DataService ds = new DataService();
            double x = 4;
            double res = ds.Calculate(x);
            double wait = -44.654;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidExpression2()
        {
            DataService ds = new DataService();
            double x = 2;
            double res = ds.Calculate(x);
            double wait = 2;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidExpression3()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            double wait = -0.577;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidExpression4()
        {
            DataService ds = new DataService();
            double x = -7;
            double res = ds.Calculate(x);
            double wait = -77;
            Assert.AreEqual(wait, res);
        }
    }
}