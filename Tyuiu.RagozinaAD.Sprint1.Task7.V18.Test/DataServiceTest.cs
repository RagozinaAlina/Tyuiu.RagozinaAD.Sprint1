﻿using Tyuiu.RagozinaAD.Sprint1.Task7.V18.Lib;
namespace Tyuiu.RagozinaAD.Sprint1.Task7.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 2;
            double wait = 3.047;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
