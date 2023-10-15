using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TretyakovDV.Sprint2.Task6.V7.Lib;
namespace Tyuiu.TretyakovDV.Sprint2.Task6.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression1()
        {
            DataService ds = new DataService();
            int n = 148;
            int startYear = 1990;
            string res = ds.FindMonthName(startYear, n);
            string wait = "Май";
            Assert.AreEqual(wait, res);
        }
    }
}