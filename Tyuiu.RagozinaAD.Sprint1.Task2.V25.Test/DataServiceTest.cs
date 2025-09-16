using Tyuiu.RagozinaAD.Sprint1.Task2.V25.Lib;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Tyuiu.RagozinaAD.Sprint1.Task2.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 2;
            var res = ds.ConvertRadsToDegrees(x);
            Assert.AreEqual(114.650, res);
         
        }
    }
}
