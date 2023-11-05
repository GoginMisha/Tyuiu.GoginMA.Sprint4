using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GoginMA.Sprint4.Task0.V2.Lib;

namespace Tyuiu.GoginMA.Sprint4.Task0.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetSumOddArrEl()
        {
            DataService ds = new DataService();
            int[] numsArray = { 5, 3, 7, 1, 3, 9, 8, 7, 9, 4 };
            int res = ds.GetSumOddArrEl(numsArray);
            int wait = 44;
            Assert.AreEqual(wait, res);
        }
    }
}
