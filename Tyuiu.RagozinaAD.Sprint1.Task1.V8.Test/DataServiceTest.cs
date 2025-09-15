using Tyuiu.RagozinaAD.Sprint1.Task1.V8.Lib;
namespace Tyuiu.RagozinaAD.Sprint1.Task1.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double a = 2.0;
            double x = 1.0;
            var res = ds.Calculate(x, a);
            Assert.AreEqual(6.28, res);
        }
    }
}
