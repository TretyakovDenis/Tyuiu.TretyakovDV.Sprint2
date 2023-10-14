using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TretyakovDV.Sprint2.Task4.V27.Lib;
namespace Tyuiu.TretyakovDV.Sprint2.Task4.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression1()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 5;
            double res = ds.Calculate(x, y);
            double wait = 24.6;
            Assert.AreEqual(wait, res);

        }
    }
}