using Tyuiu.RagozinaAD.Sprint1.Task3.V1.Lib;
namespace Tyuiu.RagozinaAD.Sprint1.Task3.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            double wait = 6.28;
            var res = ds.CylinderVolume(x,y);
            Assert.AreEqual(wait, res);
        }
    }
}
