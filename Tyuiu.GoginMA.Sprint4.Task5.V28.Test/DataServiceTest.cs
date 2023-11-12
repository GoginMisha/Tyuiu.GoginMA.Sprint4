using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GoginMA.Sprint4.Task5.V28.Lib;

namespace Tyuiu.GoginMA.Sprint4.Task5.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate()
        {
            DataService ds = new DataService();
            int[,] mas2 = new int[5, 5] { { -6, -5, -4, -3, -2 }, { -1, 0, 1, 2, 3 }, { -6, -5, -4, -3, -2 }, { -1, 0, 1, 2, 3 }, { -6, -5, -4, -3, -2 } };
            int[,] res = ds.Calculate(mas2);
            int[,] wait = { { 0, 0, 0, 0, 0 }, { 0, 0, 1, 2, 3 }, { 0, 0, 0, 0, 0 }, { 0, 0, 1, 2, 3 }, { 0, 0, 0, 0, 0 } };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
