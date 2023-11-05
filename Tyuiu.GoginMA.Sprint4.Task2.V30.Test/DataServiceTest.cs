using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GoginMA.Sprint4.Task2.V30.Lib;

namespace Tyuiu.GoginMA.Sprint4.Task2.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate()
        {
            DataService ds = new DataService();
            int[] numsArray = { 2, 4, 4, 7, 2, 5, 4, 3, 3, 4, 5, 3 };
            int res = ds.Calculate(numsArray);
            int wait = 4725;
            Assert.AreEqual(wait, res);
        }
    }
}
