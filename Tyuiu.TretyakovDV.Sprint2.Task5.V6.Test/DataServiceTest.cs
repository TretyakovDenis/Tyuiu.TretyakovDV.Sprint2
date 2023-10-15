using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TretyakovDV.Sprint2.Task5.V6.Lib;
namespace Tyuiu.TretyakovDV.Sprint2.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression1()
        {
            DataService ds = new DataService();
            int value1 = 2;
            int value2 = 6;
            string res = ds.FindCardNameAndValue(value1, value2);
            string wait = "Шестерка Трефы";
            Assert.AreEqual(wait, res);

        }
    }
}