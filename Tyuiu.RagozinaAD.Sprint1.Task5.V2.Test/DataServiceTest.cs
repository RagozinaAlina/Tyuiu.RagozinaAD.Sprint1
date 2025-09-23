using Tyuiu.RagozinaAD.Sprint1.Task5.V2.Lib;
namespace Tyuiu.RagozinaAD.Sprint1.Task5.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            double F = 100;
            DataService ds = new DataService();
            double res = ds.FahrenheitToСelsius(F);

            int result = Convert.ToInt32(res);

            int wait = 38;
            Assert.AreEqual(wait, result);
        }
    }
}
